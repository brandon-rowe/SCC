using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rowe_Brandon_Chapter_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            string fromDistance, toDistance;

            if (fromListBox.SelectedIndex != -1 && toListBox.SelectedIndex != -1 && inputTextBox.Text != " ")
            {
                double distance = double.Parse(inputTextBox.Text);
                fromDistance = fromListBox.SelectedItem.ToString();
                toDistance = toListBox.SelectedItem.ToString();

                if (fromDistance == toDistance)
                    resultLabel.Text = distance.ToString();
                else if (fromDistance == "Inches" && toDistance == "Feet")
                    resultLabel.Text = (distance / 12).ToString("n2");
                else if (fromDistance == "Inches" && toDistance == "Yards")
                    resultLabel.Text = (distance / 36).ToString("n2");
                else if (fromDistance == "Feet" && toDistance == "Inches")
                    resultLabel.Text = (distance * 12).ToString("n2");
                else if (fromDistance == "Feet" && toDistance == "Yards")
                    resultLabel.Text = (distance / 3).ToString("n2");
                else if (fromDistance == "Yards" && toDistance == "Inches")
                    resultLabel.Text = (distance * 36).ToString("n2");
                else if (fromDistance == "Yards" && toDistance == "Feet")
                    resultLabel.Text = (distance * 3).ToString("n2");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = " ";
            fromListBox.SelectedIndex = -1;
            toListBox.SelectedIndex = -1;
            resultLabel.Text = " ";
            inputTextBox.Focus();
        }
    }
}
