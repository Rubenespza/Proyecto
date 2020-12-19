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
    public partial class Cajero : Form
    {
        public Cajero()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
          
            txtpassword.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtpassword.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtpassword.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtpassword.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtpassword.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtpassword.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtpassword.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtpassword.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtpassword.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtpassword.Text +="9";
        }

        private void lbldelete_Click(object sender, EventArgs e)
        {
            txtpassword.Text = null;
        }

        private void lblenter_Click(object sender, EventArgs e)
        {
            string password= Properties.Settings.Default.Password;
            if (txtpassword.Text == password)
            {
                tabControl1.SelectTab(1);
            }
            else
            {
                MessageBox.Show("Lo sentimos, Su PIN es incorrecto", "Validacion");
                txtpassword.Text = "";
            }
            
        }

        private void btnbalance_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
            



        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            tabControl1.SelectTab(0);
            txtpassword.Text = "";


        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WithDraw(2000);
        }
        private void WithDraw(double Cantidad)
        {
            double balance = double.Parse(aux.Text);
            if (balance >= Cantidad)

            {
                double z = balance - Cantidad;
                Properties.Settings.Default.Capital = Convert.ToString(z);
                Properties.Settings.Default.Save();
                MessageBox.Show("Por favor Retire su dinero, Gracias por su coperacion");
            }
            else
            {
                MessageBox.Show("No posee Fondos Suficientes, Intente otra Cantidad");
            }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            WithDraw(1000);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WithDraw(500);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WithDraw(300);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WithDraw(100);
        }
    }
    }

