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

namespace Lab10_5
{
    public partial class Form1 : Form
    {
        private StreamWriter fil;
        private StreamReader inFile;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            try 
            {
                fil.Close();
                txtBxName.Clear();
                txtBxTotal.Clear();
                inFile = new StreamReader("employee.txt");
                string inValue;
                while ((inValue = inFile.ReadLine()) != null)
                {
                    if (inValue.Contains("Name")) 
                    {
                        txtBxDisplay.Text += inValue + "\r\n";
                    }
                    else if (inValue.Contains("Pay")) 
                    {
                        txtBxDisplay.Text += inValue + "\r\n\r\n";
                    }
                }
            }
            catch (IOException err) { MessageBox.Show(err.Message); }


        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            try
            {
                string text;
                double payRate, hours, total;
                payRate = double.Parse(txtBxPay.Text);
                hours = double.Parse(txtBxHours.Text);

                if (hours > 40)
                {
                    total = payRate * 40 + payRate * 1.5 * (hours - 40);
                }
                else
                {
                    total = payRate * hours;
                }

                txtBxTotal.Text = total.ToString("C2");


                text = "Employee Name: " + txtBxName.Text + "\nNumber: " + txtBxNum.Text +
                    "\nTotal amount of Pay: " + txtBxTotal.Text + "\n";

                fil.WriteLine(text);

                MessageBox.Show("The employee data is computed and stored.");

                txtBxDisplay.Clear();
                txtBxHours.Clear();
                txtBxNum.Clear();
                txtBxPay.Clear();


            }
            catch (DirectoryNotFoundException err)
            {
                MessageBox.Show(err.Message);
            }
            catch (IOException err)
            {
                MessageBox.Show(err.Message);
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

        private void Form1_Load(object sender, EventArgs e)
        {
            fil = new StreamWriter("employee.txt");
        }
    }
}
