using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_application
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void inputNameCountryButton_Click(object sender, EventArgs e)
        {
            InputNameCountryForm form2 = new InputNameCountryForm();
            form2.Show();
        }

        private void outputOfAllCountriesFromTheDatabaseButton_Click(object sender, EventArgs e)
        {
            SelectAllCountriesForm form4 = new SelectAllCountriesForm();
            form4.Show();
        }

        private void aboutFunctionalityToolStripMenuItemMainWindow_Click(object sender, EventArgs e)
        {
            HelpForm form5 = new HelpForm();
            form5.Show();
        }

        private void aboutDevelopersToolStripMenuItemMainWindow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчик: Жуков Егор Геннадьевич.");
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
