using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brandon_Rowe_Test_1
{
    public partial class Form1 : Form
    {
        private decimal checkingTotal = 0m;
        private decimal savingTotal = 0m;
        private decimal iraTotal = 0m;
        private decimal total = 0m;


        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName;
                string lastName;
                string outputName;

                firstName = firstNameTextBox.Text;
                lastName = lastNameTextBox.Text;

                
                outputName = firstName + " " + lastName;
                outputNameLabel.Text = outputName.ToString();
                
                outputNameLabel.Visible = true;
                accountActivitiesLabel.Visible = true;
                accountActivityGroupBox.Visible = true;
                instructFirstNameLabel.Visible = false;
                instructLastNameLabel.Visible = false;
                firstNameTextBox.Visible = false;
                lastNameTextBox.Visible = false;
                addValueTextBox.Focus();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void checkingAccountButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal depositAmount;

                depositAmount = decimal.Parse(addValueTextBox.Text);

                checkingTotal += depositAmount;

                checkingAccountTextBox.Text = checkingTotal.ToString();

                total = checkingTotal + savingTotal + iraTotal;
                totalTextBox.Text = total.ToString("C");
            }
            catch
            {
                MessageBox.Show("Please enter a valid number in the deposit/withdraw textbox.");
            }
        }

        private void savingAccountButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal depositAmount;

                depositAmount = decimal.Parse(addValueTextBox.Text);

                savingTotal += depositAmount;

                savingAccountTextBox.Text = savingTotal.ToString();

                total = checkingTotal + savingTotal + iraTotal;
                totalTextBox.Text = total.ToString("C");
            }
            catch
            {
                MessageBox.Show("Please enter a valid number in the deposit/withdraw textbox.");
            }
        }

        private void iraButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal depositAmount;

                depositAmount = decimal.Parse(addValueTextBox.Text);

                iraTotal += depositAmount;

                iraTextBox.Text = iraTotal.ToString();

                total = checkingTotal + savingTotal + iraTotal;
                totalTextBox.Text = total.ToString("C");
            }
            catch
            {
                MessageBox.Show("Please enter a valid number in the deposit/withdraw textbox.");
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            addValueTextBox.Text = " ";
            checkingAccountTextBox.Text = " ";
            savingAccountTextBox.Text = " ";
            iraTextBox.Text = " ";
            totalTextBox.Text = " ";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
