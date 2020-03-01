using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_11_Lecture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHours_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtIDnumber.Text != "")
            {
                string name, id, track;

                name = txtName.Text;
                id = txtIDnumber.Text;

                if (radInfo.Checked)
                {
                    track = "Information Systems";
                }
                else
                {
                    track = "Software Engineering";
                }

                CompSciStudent csStudent =
                    new CompSciStudent(name, id, track);

                lblHours.Text = csStudent.RequiredHours.ToString("n1");
                lblTrack.Text = csStudent.AcademicTrack;
            }
            else
            {
                MessageBox.Show("A box was left blank");
            }

        }

        private void txtClear_Click(object sender, EventArgs e)
        {
            txtIDnumber.Text = " ";
            txtName.Text = " ";
            lblHours.Text = " ";
            lblTrack.Text = " ";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
