using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Test_application
{
    public partial class InputNameCountryForm : Form
    {
        InsertCountryForm insertCountryForm;

        public InputNameCountryForm()
        {
            InitializeComponent();
            insertCountryForm = new InsertCountryForm();
        }

        private void GetInformationButton_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(
                "Такой страны в базе данных не найдено.\nХотите добавить данную страну?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
                insertCountryForm.nameCountryTextBox.Text = inputNameCountryTextBox.Text;
                insertCountryForm.Show();
        }

        private void CloseInputNameCountryFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inputNameCountryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symbol = e.KeyChar;
            if ((symbol < 'А' || symbol > 'я') && symbol != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
