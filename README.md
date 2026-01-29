To use the app, you need to place the database files in the application folder; otherwise, it will not work.

First, download the database files knijarnica.mdf and knijarnica.ldf.

Then, open the Add Connection menu from the Server Explorer, change the Data Source to Microsoft SQL Server Database File, and add the .mdf file.

If everything is done correctly, the database will appear in the Server Explorer. Open the database and check the tables.

Next, click on the database. In the bottom-left corner, a Properties menu will appear. In this menu, find and copy the connection string.

After that, place the connection string on every line that looks like this:

SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=knijarnica;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

If there is a problem with the string, make sure to place @ in front of it, as shown in the code above.



