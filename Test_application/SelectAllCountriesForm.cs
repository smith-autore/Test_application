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
using System.Configuration;

namespace Test_application
{
    public partial class SelectAllCountriesForm : Form
    {
        SqlConnection sqlConnection;
        public SelectAllCountriesForm()
        {
            InitializeComponent();
        }

        private async void selectAllCountriesForm_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CountryCS"].ConnectionString;

            sqlConnection = new SqlConnection(connectionString);

            await sqlConnection.OpenAsync();

            await LoadCountriesAsync();
        }

        private async Task LoadCountriesAsync()
        {
            SqlDataReader sqlReader = null;

            string query = "SELECT [Name_country], [Country_code], [Name_city], [Area], [Population], [Name_region] FROM [Countries] cn INNER JOIN [Cities] ct ON cn.[Capital] = ct.[Id_city] INNER JOIN [Regions] rg ON cn.[Region] = rg.[Id_region]";

            SqlCommand getCountriesCommand = new SqlCommand(query, sqlConnection);

            try
            {
                sqlReader = await getCountriesCommand.ExecuteReaderAsync();

                List<string[]> data = new List<string[]>();

                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[6]);

                    data[data.Count - 1][0] = sqlReader[0].ToString();
                    data[data.Count - 1][1] = sqlReader[1].ToString();
                    data[data.Count - 1][2] = sqlReader[2].ToString();
                    data[data.Count - 1][3] = sqlReader[3].ToString();
                    data[data.Count - 1][4] = sqlReader[4].ToString();
                    data[data.Count - 1][5] = sqlReader[5].ToString();
                }
                foreach (string[] s in data)
                    selectAllCountriesDataGridView.Rows.Add(s);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null && !sqlReader.IsClosed)
                {
                    sqlReader.Close();
                }
            }
        }

        private void selectAllCountriesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }

        private async void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectAllCountriesDataGridView.Rows.Clear();

            SqlDataReader sqlReader = null;

            string query = "SELECT [Name_country], [Country_code], [Name_city], [Area], [Population], [Name_region] FROM [Countries] cn INNER JOIN [Cities] ct ON cn.[Capital] = ct.[Id_city] INNER JOIN [Regions] rg ON cn.[Region] = rg.[Id_region]";

            SqlCommand getCountriesCommand = new SqlCommand(query, sqlConnection);

            try
            {
                sqlReader = await getCountriesCommand.ExecuteReaderAsync();

                List<string[]> data = new List<string[]>();

                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[6]);

                    data[data.Count - 1][0] = sqlReader[0].ToString();
                    data[data.Count - 1][1] = sqlReader[1].ToString();
                    data[data.Count - 1][2] = sqlReader[2].ToString();
                    data[data.Count - 1][3] = sqlReader[3].ToString();
                    data[data.Count - 1][4] = sqlReader[4].ToString();
                    data[data.Count - 1][5] = sqlReader[5].ToString();
                }
                foreach (string[] s in data)
                    selectAllCountriesDataGridView.Rows.Add(s);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }
    }
}
