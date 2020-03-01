using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brandon_Rowe_Lecture_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            string[] montharray = {"January", "February", "March", "April", "May", "June", "July", "August", "September",
                                    "October", "November", "December"};
            string[] carolina5 = { "10", "16", "18", "25", "29" };
            string concat ="";
            int match = 0;
            if (string.IsNullOrEmpty(cmbOne.Text) || string.IsNullOrEmpty(cmbTwo.Text)
                || string.IsNullOrEmpty(cmbThree.Text) || string.IsNullOrEmpty(cmbFour.Text)
                || string.IsNullOrEmpty(cmbFive.Text) || string.IsNullOrEmpty(cmbMonth.Text))
                MessageBox.Show("No selections or missing selections");
            else
            {
                lblMonthMsg.Text = "Your were born in " + montharray[cmbMonth.SelectedIndex].ToString();
                if ((string)cmbOne.SelectedItem == carolina5[0])
                {
                    concat = concat + cmbOne.SelectedItem + " ";
                    match++;
                }
                if ((string)cmbOne.SelectedItem == carolina5[1])
                {
                    concat = concat + cmbTwo.SelectedItem + " ";
                    match++;
                }
                if ((string)cmbOne.SelectedItem == carolina5[2])
                {
                    concat = concat + cmbThree.SelectedItem + " ";
                    match++;
                }
                if ((string)cmbOne.SelectedItem == carolina5[3])
                {
                    concat = concat + cmbFour.SelectedItem + " ";
                    match++;
                }
                if ((string)cmbOne.SelectedItem == carolina5[4])
                {
                    concat = concat + cmbFive.SelectedItem + " ";
                    match++;
                }
            }
        }
    }
}
