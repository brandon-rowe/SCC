using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rowe_Brandon_Chapter_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
                const double PERCENTAGE = 0.01;
                int count = 1;
                int totalCount;
                double increase;
                double population;

                appPopulationListBox.Items.Add("Day" + "         " + "Approximate Population");

                if (double.TryParse(startingNumberTextBox.Text, out population))
                {
                    if (double.TryParse(averageDailyIncreaseTextBox.Text, out increase))
                    {
                        if (int.TryParse(numberDaysTextBox.Text, out totalCount))
                        {
                            
                            increase = increase * PERCENTAGE;
                            while (count <= totalCount) 
                            {
                                appPopulationListBox.Items.Add(count + "              " + population.ToString());
                                population = population + (increase * population);                                
                                count = count + 1;
                            }                          
                            
                        }
                        else
                        {
                            MessageBox.Show("Invalid value for number of days to be calculated.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid value for average daily increase percentage.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid value for starting number of organisms.");
                }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            startingNumberTextBox.Text = " ";
            averageDailyIncreaseTextBox.Text = " ";
            numberDaysTextBox.Text = " ";
            appPopulationListBox.Items.Clear();
            startingNumberTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
