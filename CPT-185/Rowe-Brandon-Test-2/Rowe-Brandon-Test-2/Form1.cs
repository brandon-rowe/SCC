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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double Average(int[] iArray)
        {
            int total = 0;
            double average;

            for (int index = 0; index < iArray.Length; index++)
            {
                total += iArray[index];
            }

            average = total / iArray.Length;
            return average;
        }

        private double Highest(int[] iArray)
        {
            double highest = iArray[0];

            for (int index = 1; index < iArray.Length; index++)
            {
                if (iArray[index] > highest)
                {
                    highest = iArray[index];
                }
            }
            return highest;
        }

        private double Lowest(int[] iArray)
        {
            double lowest = iArray[0];

            for (int index = 1; index < iArray.Length; index++)
            {
                if (iArray[index] < lowest)
                {
                    lowest = iArray[index];
                }
            }
            return lowest;

        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            try
            {
                const int SIZE = 10;
                double[] salaries = new double[SIZE];
                int index = 0;
                double highestSalary;
                double lowestSalary;
                double averageSalary;
                int totalRecords = SIZE;
                string concat = "";
                StreamReader inputFile;
                

                inputFile = File.OpenText("salaries.txt");

                while (!inputFile.EndOfStream && index < salaries.Length)
                {
                    salaries[index] = double.Parse(inputFile.ReadLine());
                    index++;
                }
                inputFile.Close();
                                            

                highestSalary = Highest(salaries);
                lowestSalary = Lowest(salaries);
                averageSalary = Average(salaries);

                outputLabel.Text = "The total Salaries: " + concat + "The number of records: " + totalRecords.ToString() + concat + concat +
                    "The average: " + averageSalary.ToString("n2") + concat +"The largest salary: " + highestSalary.ToString("n2") + concat + "The smallest salary: " + lowestSalary.ToString("n2");
                             

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

                
        }
    }
}
