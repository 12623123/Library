# Library Management Application

A C# Windows Forms desktop application for managing the day-to-day operations of a small library or bookstore. The application uses a local Microsoft SQL Server database to store supplier, inventory, and sales information.

## What the application does

The main window is divided into several sections:

- **Suppliers** — Add and save supplier information, including the supplier name, identification number, telephone number, email address, and contact person.
- **Sales** — Record sales by entering the product number, quantity, selling price, supplier identification number, and sale date. Dates must use the `YYYY-MM-DD` format.
- **Inventory** — View the products currently stored in the database in a table.
- **Daily turnover** — Select a date to view the sales made on that day and calculate the total revenue for the selected date.

All changes and searches are saved to or loaded from the `knijarnica` SQL Server database. The application is intended for a local Windows environment and provides a simple graphical interface for managing library or bookstore records.

## Requirements

Before running the application, install:

- Visual Studio with the .NET desktop development workload
- SQL Server LocalDB
- SQL Server Data Tools, if required by your Visual Studio installation

## Database setup

The application uses a local Microsoft SQL Server database named `knijarnica`.

The repository includes the following database files:

- `knijarnica.mdf` — database data file
- `knijarnica.ldf` — database transaction log file

### Attach the database in Visual Studio

1. Open the solution in Visual Studio.
2. Open **View → Server Explorer**.
3. Right-click **Data Connections** and select **Add Connection**.
4. Set **Data source** to **Microsoft SQL Server Database File**.
5. Select `knijarnica.mdf` from the project directory.
6. Confirm that the database and its tables appear in Server Explorer.
7. Copy the generated connection string from the database connection properties.

### Configure the application

Update the connection string in the application's configuration file, if available.

For example:

```csharp
Data Source=(localdb)\MSSQLLocalDB;
Initial Catalog=knijarnica;
Integrated Security=True;
Connect Timeout=30;
```

If the project currently stores the connection string directly in C# files, replace the existing value wherever it appears:

```csharp
SqlConnection connection = new SqlConnection(
    @"YOUR_CONNECTION_STRING_HERE");
```

The `@` before the string is required when the connection string contains Windows-style backslashes.

> Recommendation: Move the connection string into `App.config` instead of duplicating it throughout the source code.

Example:

```xml
<connectionStrings>
  <add name="LibraryDatabase"
       connectionString="Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=knijarnica;Integrated Security=True;Connect Timeout=30"
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

Then retrieve it in C#:

```csharp
using System.Configuration;
using System.Data.SqlClient;

var connectionString =
    ConfigurationManager.ConnectionStrings["LibraryDatabase"].ConnectionString;

using var connection = new SqlConnection(connectionString);
```

## Running the application

1. Open the solution in Visual Studio.
2. Make sure the database is attached and the connection string is configured.
3. Select the application project as the startup project.
4. Build the solution using **Build → Build Solution**.
5. Run the application with **F5** or **Ctrl+F5**.

## Troubleshooting

### The database cannot be found

Verify that:

- `knijarnica.mdf` exists in the expected directory.
- The database is attached in Server Explorer.
- The connection string points to the correct database.
- SQL Server LocalDB is installed and running.

### The connection string does not work

The generated connection string may contain an absolute path specific to your computer. Reattach the `.mdf` file on your machine and use the newly generated connection string.

### The application cannot find a table

Open the database in Server Explorer and confirm that the required tables exist. If the tables are missing, use a valid copy of the database files.

## Notes

The database files are binary SQL Server files and should not be edited manually. Keep backup copies before making database changes.
