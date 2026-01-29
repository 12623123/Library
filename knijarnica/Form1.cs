using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace knijarnica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox_dostavchik.Show();
            groupBox_prodajba.Hide();
            groupBox_stoki.Hide();
            groupBox_oborot.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox_dostavchik.Hide();
            groupBox_prodajba.Show();
            groupBox_stoki.Hide();
            groupBox_oborot.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox_dostavchik.Hide();
            groupBox_prodajba.Hide();
            groupBox_stoki.Show();
            groupBox_oborot.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox_dostavchik.Hide();
            groupBox_prodajba.Hide();
            groupBox_stoki.Hide();
            groupBox_oborot.Show();
        }


        private void button5_Click_1(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=knijarnica;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            SqlCommand command = new SqlCommand("Insert into Dostavchici_na_knijarnicatra values (@naimenovanie, @EIKEGN, @telefon,@email,@lice_na_kontakta)", connection);
            command.Parameters.AddWithValue("@naimenovanie", textBox_name.Text);
            command.Parameters.AddWithValue("@EIKEGN", textBox_egn.Text);
            command.Parameters.AddWithValue("@telefon", textBox_telefon.Text);
            command.Parameters.AddWithValue("@email", textBox_email.Text);
            command.Parameters.AddWithValue("@lice_na_kontakta", textBox_kontakt.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Successfuly saved");

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            string prodajnacena = textBox_cena.Text.Trim();
            string dostavchik_egn = textBox_dostavchik_egn.Text.Trim();
            int stoka_id = Convert.ToInt32(textBox_stoki.Text.Trim());
            string broi = textBox_broi.Text.Trim();
            string dateText = textBox_data.Text.Trim();

            if (!DateTime.TryParseExact(dateText, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            {
                MessageBox.Show("Неправилен формт. Моля използвайте YYYY-MM-DD формата.");
                return;
            }
            dateText = date.ToString("yyyy-MM-dd");



            string query = "INSERT INTO Prodajbi_za_denq (prodajnacena, stoka_id,broi,dostavchik_egn,data) VALUES (@prodajnacena, @stoka_id, @broi,@dostavchik_egn,@data)";
            using (SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=knijarnica;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@prodajnacena", prodajnacena);
                command.Parameters.AddWithValue("@stoka_id", stoka_id);
                command.Parameters.AddWithValue("@broi", broi);
                command.Parameters.AddWithValue("@dostavchik_egn", dostavchik_egn);
                command.Parameters.AddWithValue("@data", dateText);
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
            }

            MessageBox.Show("Продажбата беше запазена успешно!");
        }










        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=knijarnica;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From stoki", connection);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }
        private void button8_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value.Date;

            string query = "SELECT stoka_id, broi, prodajnacena FROM Prodajbi_za_denq WHERE data = @data";
            using (SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=knijarnica;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@data", date.ToString("yyyy-MM-dd"));
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    listBox1.Items.Clear();

                    while (reader.Read())
                    {
                        int stoka_id = reader.GetInt32(0);
                        int broi = reader.GetInt32(1);
                        decimal prodajnacena = reader.GetDecimal(2);
                        string itemText = $"Стока(№ на стоката): {stoka_id}, брои: {broi}, продадена за {prodajnacena}лв";
                        listBox1.Items.Add(itemText);
                    }
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string query = "SELECT SUM(prodajnacena) FROM Prodajbi_za_denq WHERE data = @data";
            using (SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=knijarnica;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@data", dateTimePicker1.Value.Date);
                connection.Open();

                object result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    decimal totalSales = (decimal)result;
                    string itemText = $"Оборота за деня е {totalSales}лв";
                    listBox1.Items.Clear();
                    listBox1.Items.Add(itemText);
                }
                else
                {
                    string itemText = "За този ден няма продажби";
                    listBox1.Items.Clear();
                    listBox1.Items.Add(itemText);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

