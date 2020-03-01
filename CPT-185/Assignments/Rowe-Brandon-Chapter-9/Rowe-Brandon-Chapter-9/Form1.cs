using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_Chapter_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox1().ShowDialog();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            nutritionForm nutriForm = new nutritionForm();
            if (radBanana.Checked)
            {
                nutriForm.lblFood.Text = "1 banana";
                nutriForm.lblCalorie.Text = "100";
                nutriForm.lblFatGrams.Text = "0.4";
                nutriForm.lblCarbGrams.Text = "27";
            }
            else if (radioPopcorn.Checked)
            {
                nutriForm.lblFood.Text = "1 cup of air-popped popcorn";
                nutriForm.lblCalorie.Text = "31";
                nutriForm.lblFatGrams.Text = "0.4";
                nutriForm.lblCarbGrams.Text = "6";
            }
            else if (radioBlueberryMuffin.Checked)
            {
                nutriForm.lblFood.Text = "1 large blueberry muffin";
                nutriForm.lblCalorie.Text = "385";
                nutriForm.lblFatGrams.Text = "9";
                nutriForm.lblCarbGrams.Text = "67";
            }

            nutriForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
