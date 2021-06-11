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


namespace Lab10_3
{
    public partial class FileAccessApp : Form
    {
        private StreamReader inFile;    // stream reader,writer need to write here!
        public FileAccessApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            int total = 0;
            double avg;
            int count = 0;
            string inValue;

            try
            {
                inFile = new StreamReader("file.txt");

                while ((inValue = inFile.ReadLine()) != null) 
                {
                    total += int.Parse(inValue);
                    count++;
                }

                avg = (double) total / count;

                lblDisplayResult.Text = "Average Value: " + avg.ToString("F2");

            }
            catch (Exception err) { MessageBox.Show(err.Message); }

        }

        private void btnSmallest_Click(object sender, EventArgs e)
        {
            string inValue;
            int smaller;

            try
            {
                inFile = new StreamReader("file.txt");

                smaller = int.Parse(inFile.ReadLine());

                while ((inValue = inFile.ReadLine()) != null)
                {
                    if (int.Parse(inValue) < smaller)
                    {
                        smaller = int.Parse(inValue);
                    }
                }

                lblDisplayResult.Text = "Smallest Value: " + smaller.ToString("F0");

            }
            catch (Exception err) { MessageBox.Show(err.Message); }
        }

        private void btnLargest_Click(object sender, EventArgs e)
        {
            string inValue;
            int larger;

            try
            {
                inFile = new StreamReader("file.txt");

                larger = int.Parse(inFile.ReadLine());

                while ((inValue = inFile.ReadLine()) != null)
                {
                    if (int.Parse(inValue) > larger)
                    {
                        larger = int.Parse(inValue);
                    }
                }

                lblDisplayResult.Text = "Largest Value: " + larger.ToString("F0");

            }
            catch (Exception err) { MessageBox.Show(err.Message); }
        }
    }
}
