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
        double operand1;
        double operand2;
        string operation;
        double output = 0.0;
        bool opr = false;

        public Form1()
        {
            InitializeComponent();
        }        

        private void zero_button_Click(object sender, EventArgs e)
        {
            if (opr)
            {
                outputLabel.Text = "";
                opr = false;
            }
            outputLabel.Text = outputLabel.Text + "0";
        }

        private void one_button_Click(object sender, EventArgs e)
        {
            if (opr)
            {
                outputLabel.Text = "";
                opr = false;
            }
            outputLabel.Text = outputLabel.Text + "1";
        }

        private void two_button_Click(object sender, EventArgs e)
        {
            if (opr)
            {
                outputLabel.Text = "";
                opr = false;
            }
            outputLabel.Text = outputLabel.Text + "2";
        }

        private void three_button_Click(object sender, EventArgs e)
        {
            if (opr)
            {
                outputLabel.Text = "";
                opr = false;
            }
            outputLabel.Text = outputLabel.Text + "3";
        }

        private void four_button_Click(object sender, EventArgs e)
        {
            if (opr)
            {
                outputLabel.Text = "";
                opr = false;
            }
            outputLabel.Text = outputLabel.Text + "4";
        }

        private void five_button_Click(object sender, EventArgs e)
        {
            if (opr)
            {
                outputLabel.Text = "";
                opr = false;
            }
            outputLabel.Text = outputLabel.Text + "5";
        }

        private void six_button_Click(object sender, EventArgs e)
        {
            if (opr)
            {
                outputLabel.Text = "";
                opr = false;
            }
            outputLabel.Text = outputLabel.Text + "6";
        }

        private void seven_button_Click(object sender, EventArgs e)
        {
            if (opr)
            {
                outputLabel.Text = "";
                opr = false;
            }
            outputLabel.Text = outputLabel.Text + "7";
        }

        private void eight_button_Click(object sender, EventArgs e)
        {
            if (opr)
            {
                outputLabel.Text = "";
                opr = false;
            }
            outputLabel.Text = outputLabel.Text + "8";
        }

        private void nine_button_Click(object sender, EventArgs e)
        {
            if (opr)
            {
                outputLabel.Text = "";
                opr = false;
            }
            outputLabel.Text = outputLabel.Text + "9"; ;
        }

        private void plus_button_Click(object sender, EventArgs e)
        {
            try
            {
                operand1 = Convert.ToDouble(outputLabel.Text);
                operation = "+";
                opr = true;
                stringLabel.Text = outputLabel.Text + " +";
            }
            catch
            {
                MessageBox.Show("Please enter valid calculations to perform.");
            }
        }

        private void minus_button_Click(object sender, EventArgs e)
        {
            try
            {

                operand1 = Convert.ToDouble(outputLabel.Text);
                operation = "-";
                opr = true;
                stringLabel.Text = outputLabel.Text + " -";
            }
            catch
            {
                MessageBox.Show("Please enter valid calculations to perform.");
            }
        }

        private void multiply_button_Click(object sender, EventArgs e)
        {
            try
            {
                operand1 = Convert.ToDouble(outputLabel.Text);
                operation = "*";
                opr = true;
                stringLabel.Text = outputLabel.Text + " *";
            }
            catch
            {
                MessageBox.Show("Please enter valid calculations to perform.");
            }
        }

        private void division_button_Click(object sender, EventArgs e)
        {
            try
            {
                operand1 = Convert.ToDouble(outputLabel.Text);
                operation = "/";
                opr = true;
                stringLabel.Text = outputLabel.Text + " /";
            }
            catch
            {
                MessageBox.Show("Please enter valid calculations to perform.");
            }
        }
                
        private void period_button_Click(object sender, EventArgs e)
        {
            if (outputLabel.Text.Contains("."))
            {
                outputLabel.Text = outputLabel.Text;
            }
            else
            {
                outputLabel.Text = outputLabel.Text + ".";
            }
        }

        private void equal_button_Click(object sender, EventArgs e)
        {
            try
            {
                operand2 = Convert.ToDouble(outputLabel.Text);
                switch (operation)
                {
                    case "+": output = operand1 + operand2;
                        outputLabel.Text = Convert.ToString(output);
                        stringLabel.Text = operand1 + " + " + operand2;
                        break;

                    case "-": output = operand1 - operand2;
                        outputLabel.Text = Convert.ToString(output);
                        stringLabel.Text = operand1 + " - " + operand2;
                        break;

                    case "*": output = operand1 * operand2;
                        outputLabel.Text = Convert.ToString(output);
                        stringLabel.Text = operand1 + " * " + operand2;
                        break;

                    case "/": if (operand1 == 0 || operand2 == 0)
                        {
                            outputLabel.Text = "0.0";
                            break;
                        }
                        else
                        {
                            output = operand1 / operand2;
                            outputLabel.Text = Convert.ToString(output);
                            stringLabel.Text = operand1 + " / " + operand2;
                            break;
                        }

                    case "%": output = operand1 % operand2;
                        outputLabel.Text = Convert.ToString(output);
                        stringLabel.Text = Convert.ToString(operand1 + (operand1/100));
                        break;
                }
            
            }
            catch 
            {
                MessageBox.Show("Please enter valid calculations to perform.");
            }

         }

        private void clear_button_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "";
            stringLabel.Text = "";
        }

        private void Backspace_Button_Click(object sender, EventArgs e)
        {
            try
            {
                outputLabel.Text = outputLabel.Text.Remove(outputLabel.Text.Length - 1, 1);
            }
            catch
            {
                MessageBox.Show("Unable to backspace further.");
            }
        }

        private void CE_Button_Click(object sender, EventArgs e)
        {
            outputLabel.Text = string.Empty;
        }

        private void percent_button_Click(object sender, EventArgs e)
        {
            try
            {
                stringLabel.Text = "";
                operand1 = Convert.ToDouble(outputLabel.Text);
                operation = "%";
                opr = true;
                stringLabel.Text += outputLabel.Text + "%";
            }
            catch
            {
                MessageBox.Show("Please enter valid calculations to perform.");
            }
        }

        private void plus_minus_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (outputLabel.Text.Contains("-"))
                {
                    outputLabel.Text = outputLabel.Text.Remove(0, 1);
                }                         
                else
                {
                    outputLabel.Text = "-" + outputLabel.Text;
                }
            }
            catch
            {
                MessageBox.Show("Please enter valid calculations to perform.");
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(outputLabel.Text);
        }

        private void sqrtButton_Click(object sender, EventArgs e)
        {
            if (outputLabel.Text != string.Empty)
            {
                stringLabel.Text = "";
                stringLabel.Text += "sqrt(" + outputLabel.Text + ")";
                outputLabel.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(outputLabel.Text)));
                operation = "Sqrt";
                opr = true;
            }
            else
            {
                MessageBox.Show("Please enter valid calculations to perform.");
            }

        }

        private void inverse_button_Click(object sender, EventArgs e)
        {
            if (outputLabel.Text != string.Empty)
            {
                stringLabel.Text = "";
                stringLabel.Text += "reciproc(" + outputLabel.Text + ")";
                double ans = Convert.ToDouble("1") / Convert.ToDouble(outputLabel.Text);
                outputLabel.Text = ans.ToString();
                operation = "Inv";
                opr = true;
            }
            else
            {
                MessageBox.Show("Please enter valid calculations to perform.");
            }
        }

        private void aboutCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutCalc().ShowDialog();
        }        

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "0":
                    zero_button.PerformClick();
                    break;
                case "1":
                    one_button.PerformClick();
                    break;
                case "2":
                    two_button.PerformClick();
                    break;
                case "3":
                    three_button.PerformClick();
                    break;
                case "4":
                    four_button.PerformClick();
                    break;
                case "5":
                    five_button.PerformClick();
                    break;
                case "6":
                    six_button.PerformClick();
                    break;
                case "7":
                    seven_button.PerformClick();
                    division_button.PerformClick();
                    break;
                case ".":
                    period_button.PerformClick();
                    break;
                case "8":
                    eight_button.PerformClick();
                    break;
                case "9":
                    nine_button.PerformClick();
                    break;
                case "-":
                    minus_button.PerformClick();
                    break;
                case "+":
                    plus_button.PerformClick();
                    break;
                case "*":
                    multiply_button.PerformClick();
                    break;
                case "/":
                    break;
                default:;
                    break;

            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                outputLabel.Text += Clipboard.GetText(TextDataFormat.Text).ToString();
            }

        }
                
    }
}
