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

namespace Random_Number_File_Writer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int num;
            int randomNumber;

            Random rand = new Random();

            if(int.TryParse(tboxNum.Text, out num))
            {
                
                try
                {
                    StreamWriter outputFile = null;
                    diaSave.Filter = "Text files (*.txt)|*.txt|CSV files (*.csv)|*.csv";

                    if (diaSave.ShowDialog() == DialogResult.OK)
                    { 
                        outputFile = File.CreateText(diaSave.FileName);

                        for (int i = 1; i <= num; i++)
                        {
                            randomNumber = rand.Next(1, 101);

                            outputFile.WriteLine("Random Number #" + i + ": " + randomNumber);
                        }
                        outputFile.Close();

                        MessageBox.Show("The numbers were saved to the file successfully.");

                        tboxNum.Text = "";
                        tboxNum.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Operation was cancelled.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
