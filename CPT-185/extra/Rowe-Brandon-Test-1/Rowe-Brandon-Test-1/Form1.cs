using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rowe_Brandon_Test_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectAuto;

                  if (autoListBox.SelectedIndex != -1)
                    {
                        selectAuto = autoListBox.SelectedItem.ToString();

                        switch (selectAuto)
                        { 
                            case "Lamborghini":
                                selectAuto.Text = "Lamborghini";
                                break;
                            case "Ferrari":
                                selectAuto.Text = "Ferrari";
                                break;
                            case "Corvette"
                                selectAuto.Text = "Corvette";
                        }
                    }
                                        
                  else
                  {
                      MessageBox.Show("Please make a selection or blank or invalid tax rate");
                  }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {


        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selectAuto_Click(object sender, EventArgs e)
        {

        }

        private void TransmissionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string transLabel; 

            if (TransmissionListBox.SelectedIndex = -1)
            {
                MessageBox.Show("Please make a selection or blank or invalid tax rate");
            }

            else
            {
                transLabel = TransmissionListBox.SelectedItem.ToString();
            }
        }
    }
}
