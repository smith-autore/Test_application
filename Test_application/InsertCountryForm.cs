using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_application
{
    public partial class InsertCountryForm : Form
    {
        SqlConnection sqlConnection;

        public InsertCountryForm()
        {
            InitializeComponent();
        }

        private async void InsertCountryForm_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Test (CRM GURU)\Test_application\Test_application\Information_on_contries.mdf;Integrated Security=True;Connect Timeout=30";

            sqlConnection = new SqlConnection(connectionString);

            await sqlConnection.OpenAsync();
        }

        private void InsertCountryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }

        private async void insertCountryButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameCountryTextBox.Text) && !string.IsNullOrWhiteSpace(nameCountryTextBox.Text) &&
                !string.IsNullOrEmpty(countryCodeTextBox.Text) && !string.IsNullOrWhiteSpace(countryCodeTextBox.Text) &&
                !string.IsNullOrEmpty(capitalTextBox.Text) && !string.IsNullOrWhiteSpace(capitalTextBox.Text) &&
                !string.IsNullOrEmpty(regionTextBox.Text) && !string.IsNullOrWhiteSpace(regionTextBox.Text))
            {
                SqlCommand insertCountriesCommand = new SqlCommand("INSERT INTO [Countries] (Name_country, Country_code, Capital, Area, Population, Region)VALUES(@Name_country, @Country_code, @Capital, @Area, @Population, @Region)", sqlConnection);

                insertCountriesCommand.Parameters.AddWithValue("Name_country", nameCountryTextBox.Text);

                insertCountriesCommand.Parameters.AddWithValue("Country_code", countryCodeTextBox.Text);

                insertCountriesCommand.Parameters.AddWithValue("Area", areaTextBox.Text);

                insertCountriesCommand.Parameters.AddWithValue("Population", populationTextBox.Text);

                await insertCountriesCommand.ExecuteNonQueryAsync();

                SqlCommand insertCitiesCommand = new SqlCommand("INSERT INTO [Cities] (Name_city)VALUES(@Name_city)", sqlConnection);

                insertCitiesCommand.Parameters.AddWithValue("Name_city", capitalTextBox.Text);

                await insertCitiesCommand.ExecuteNonQueryAsync();

                SqlCommand insertRegionsCommand = new SqlCommand("INSERT INTO [Regions] (Name_region)VALUES(@Name_region)", sqlConnection);

                insertRegionsCommand.Parameters.AddWithValue("Name_region", regionTextBox.Text);

                await insertRegionsCommand.ExecuteNonQueryAsync();
            }
            else
            {
                MessageBox.Show(
                "Поля 'Название страны', 'Код страны', 'Столица', 'Регион' должны быть заполнены!",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void backInsertCountryFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nameCountryTextBox.Clear();
            countryCodeTextBox.Clear();
            capitalTextBox.Clear();
            areaTextBox.Clear();
            populationTextBox.Clear();
            regionTextBox.Clear();
        }

        private void nameCountryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b')
            {
                e.Handled = true;
            }
        }

        private void countryCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'A' || l > 'Z') && l != '\b')
            {
                e.Handled = true;
            }
        }

        private void capitalTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symbol = e.KeyChar;
            if ((symbol < 'А' || symbol > 'я') && symbol != '\b')
            {
                e.Handled = true;
            }
        }

        private void areaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void populationTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void regionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symbol = e.KeyChar;
            if ((symbol < 'А' || symbol > 'я') && symbol != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
