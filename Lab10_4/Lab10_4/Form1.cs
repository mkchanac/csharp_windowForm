using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab10_4
{
    public partial class Form1 : Form
    {
        private StreamWriter fil;
        private StreamReader inFile;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                fil = new StreamWriter("user.txt");
            }
            catch (DirectoryNotFoundException err)
            {
                MessageBox.Show(err.Message);
            }
            catch (IOException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string phone;

                phone = txtBxPh1.Text + txtBxPh2.Text + txtBxPh3.Text;

                txtBxDisplay.Clear();

                User user = new User(txtBxName.Text, txtBxAddress.Text, phone);

                fil.WriteLine(user.ToString());


                MessageBox.Show("The data was stored properly.");

                txtBxAddress.Clear();
                txtBxName.Clear();
                txtBxPh1.Clear();
                txtBxPh2.Clear();
                txtBxPh3.Clear();

            }
            catch (FormatException err)
            {
                MessageBox.Show(err.Message);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            fil.Close();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            fil.Close();

            if (File.Exists("user.txt")) 
            {
                try
                {
                    string inValue;
                    inFile = new StreamReader("user.txt");

                    while ((inValue = inFile.ReadLine()) != null)
                    {
                        txtBxDisplay.Text += inValue + "\r\n";
                    }
                }
                catch (DirectoryNotFoundException err)
                {
                    MessageBox.Show(err.Message);
                }
                catch (IOException err)
                {
                    MessageBox.Show(err.Message);
                }



            }
        }
    }
}
