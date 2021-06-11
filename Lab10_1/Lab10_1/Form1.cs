using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblBagStyle_Click(object sender, EventArgs e)
        {

        }

        private void btnClearSelect_Click(object sender, EventArgs e)
        {
            lstBxBagStyle.ClearSelected();
            txtBxQuan.Clear();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (lstBxBagStyle.SelectedItem == null || txtBxQuan.Text == null)
            {
                try
                {
                    throw new Exception("Error. The selections are not made.");
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }

            }

            else
                MessageBox.Show(lstBxBagStyle.SelectedItem.ToString() + " is selected.");

            try
            {
                int quan;
                string total = "";
                double ship = 0; ;
                double bagPrice = 0;
                string bagStyle;
                double totalCost = 0;

                quan = int.Parse(txtBxQuan.Text);

                if (quan > 10)
                {
                    try
                    {
                        throw new Exception("You can only buy up to 10 bags per selection.");
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
                else
                {
                    if (rdBtnOverNight.Checked)
                    {
                        ship = 0.1;
                    }
                    else if (rdBtnThreeDay.Checked)
                    {
                        ship = 0.07;
                    }
                    else if (rdBtnStandard.Checked)
                    {
                        ship = 0.05;
                    }

                    bagStyle = lstBxBagStyle.SelectedItem.ToString();


                    bagPrice = double.Parse(bagStyle.Substring(bagStyle.Length - 5, 5));

                    totalCost = (double)quan * bagPrice * (1 + ship);

                    total = totalCost.ToString("C2");


                    MessageBox.Show("The total cost for the purchase is " + total +
                        ", bag price is " + bagPrice.ToString("C2") +
                        ", quantity is " + quan +
                        " and shipping charge is " + ship.ToString("P") + ".");
                }

            }
            catch (FormatException err)
            {
                MessageBox.Show(err.Message);
            }
            catch (DivideByZeroException err)
            {
                MessageBox.Show(err.Message);
            }
            catch (ArgumentException err)
            {
                MessageBox.Show(err.Message);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }


        }

        private void rdBtnOverNight_Click(object sender, EventArgs e)
        {

        }

        private void rdBtnOverNight_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
