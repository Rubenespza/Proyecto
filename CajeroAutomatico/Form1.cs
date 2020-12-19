using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico
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

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.Name = txtName.Text;
                Properties.Settings.Default.LastName = txtlastname.Text;
                Properties.Settings.Default.Password = txtPIN.Text;
                Properties.Settings.Default.Capital = txtbalance.Text;
                Properties.Settings.Default.Save();
                MessageBox.Show("Cliente Registrado");
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtName.Text = Properties.Settings.Default.Name;
            txtlastname.Text = Properties.Settings.Default.LastName;
            txtPIN.Text = Properties.Settings.Default.Password;
            txtbalance.Text = Properties.Settings.Default.Capital;
        }
    }
}
