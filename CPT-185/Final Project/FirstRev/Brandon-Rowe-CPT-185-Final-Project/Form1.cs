using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brandon_Rowe_CPT_185_Final_Project
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double output = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void zero_button_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "";
            input += "0";
            outputLabel.Text += input;
        }

        private void one_button_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "";
            input += "1";
            outputLabel.Text += input;
        }

        private void two_button_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "";
            input += "2";
            outputLabel.Text += input;
        }

        private void three_button_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "";
            input += "3";
            outputLabel.Text += input;
        }

        private void four_button_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "";
            input += "4";
            outputLabel.Text += input;
        }

        private void five_button_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "";
            input += "5";
            outputLabel.Text += input;
        }

        private void six_button_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "";
            input += "6";
            outputLabel.Text += input;
        }

        private void seven_button_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "";
            input += "7";
            outputLabel.Text += input;
        }

        private void eight_button_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "";
            input += "8";
            outputLabel.Text += input;
        }

        private void nine_button_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "";
            input += "9";
            outputLabel.Text += input;
        }

        private void plus_button_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void minus_button_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void multiply_button_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void division_button_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }
                
        private void period_button_Click(object sender, EventArgs e)
        {
            input += ".";
        }

        private void equal_button_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                output = num1 + num2;
                outputLabel.Text = output.ToString();
            }
            else if (operation == '-')
            {
                output = num1 - num2;
                outputLabel.Text = output.ToString();
            }
            else if (operation == '*')
            {
                output = num1 * num2;
                outputLabel.Text = output.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    output = num1 / num2;
                    outputLabel.Text = output.ToString();
                }
                else
                {
                    outputLabel.Text = "Cannot Divide by Zero";
                }
            }

         }

        private void clear_button_Click(object sender, EventArgs e)
        {
            outputLabel.Text = " ";
            input = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
