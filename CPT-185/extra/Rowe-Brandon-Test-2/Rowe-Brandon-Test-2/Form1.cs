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

namespace Rowe_Brandon_Test_2
{
    public partial class CPT_185_Test_2 : Form
    {
        public CPT_185_Test_2()
        {
            InitializeComponent();
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            try
            {
                const int SIZE = 10;
                double[] salaries = new double[SIZE];
                int index = 0;
                

                StreamReader inputFile;

                inputFile = File.OpenText("salaries.txt");

                while (!inputFile.EndOfStream && index < salaries.Length)
                {
                    salaries[index] = double.Parse(inputFile.ReadLine());
                    index++;
                }

                inputFile.Close();

               
                double total = 0;

                for (int index1 = 0; index1 < salaries.Length; index1++)
                {
                    total += salaries[index1];
                }
                                
                lblNumberRecords.Text = ("The total salaries: " + total.ToString("c"));

                double average;
                average = total / salaries.Length;               
                lblAverage.Text = ("The average: " + average.ToString("c"));

                double largest = salaries[0];

                for (int index2 = 1; index2 < salaries.Length; index2++)
                {
                    if (salaries[index2] > largest)
                        largest = salaries[index2];
                }

                lblLargest.Text = ("The largest salary: " + largest.ToString("c"));

                double smallest = salaries[0];

                for (int index3 = 1; index3 < salaries.Length; index3++)
                {
                    if (salaries[index3] < smallest)
                        smallest = salaries[index3];
                }

                lblSmallest.Text = ("The smallest salary: " + smallest.ToString("c"));

            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
