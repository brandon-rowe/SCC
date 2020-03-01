using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimelessDesignGPACalculator
{
    public partial class frmIntro : Form
    {
        public frmIntro()
        {
            InitializeComponent();
        }

        private void btn202_MouseEnter(object sender, EventArgs e)
        {
            lblClassDescription.Visible = true;
            lblClassDescription.Text = "SQL Programming";
        }

        private void btn202_MouseLeave(object sender, EventArgs e)
        {
            lblClassDescription.Text = "";
        }

        private void btn206_MouseEnter(object sender, EventArgs e)
        {
            lblClassDescription.Visible = true;
            lblClassDescription.Text = "Advanced Event Driven Programming";
        }

        private void btn206_MouseLeave(object sender, EventArgs e)
        {
            lblClassDescription.Text = "";
        }

        private void btn168_MouseEnter(object sender, EventArgs e)
        {
            lblClassDescription.Visible = true;
            lblClassDescription.Text = "Programming Logic and Design";
        }

        private void btn168_MouseLeave(object sender, EventArgs e)
        {
            lblClassDescription.Text = "";
        }

        private void btn202_Click(object sender, EventArgs e)
        {
            CPT202 cpt202 = new CPT202();
            cpt202.ShowDialog();
        }
    }
}
