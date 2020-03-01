using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brandon_Rowe_Chapter_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateObject_Click(object sender, EventArgs e)
        {
             if (txtName.Text != "" && txtNumber.Text != "" && txtPay.Text != "" && txtShift.Text != "")
            {
                string name, id, shift, pay;
               

                name = txtName.Text;
                id = txtNumber.Text;
                shift = txtShift.Text;
                pay = txtPay.Text;
                                                 
                Employee pdEmployee =
                    new Employee(name, id);
                 
                lblName.Text = name;
                lblNumber.Text = id;
                lblShift.Text = shift;
                lblPay.Text = pay;
            }
            else
            {
                MessageBox.Show("A box was left blank");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = " ";
            txtNumber.Text = " ";
            txtPay.Text = " ";
            txtShift.Text = " ";
            lblName.Text = " ";
            lblNumber.Text = " ";
            lblPay.Text = " ";
            lblShift.Text = " ";
            txtName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
