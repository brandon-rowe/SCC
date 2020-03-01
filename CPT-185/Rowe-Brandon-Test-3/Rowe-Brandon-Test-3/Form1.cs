using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rowe_Brandon_Test_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tblPlanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblPlanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jobDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jobDataSet.tblPlan' table. You can move, or remove it, as needed.
            this.tblPlanTableAdapter.Fill(this.jobDataSet.tblPlan);

        }

        private void sortAscButton_Click(object sender, EventArgs e)
        {
            tblPlanTableAdapter.FillByPlanCostAsc(this.jobDataSet.tblPlan);
        }

        private void sortDesButton_Click(object sender, EventArgs e)
        {
            tblPlanTableAdapter.FillByPlanCostDes(this.jobDataSet.tblPlan);
        }

        private void planCostBelowButton_Click(object sender, EventArgs e)
        {
            tblPlanTableAdapter.FillByPlanCostBelow1000(this.jobDataSet.tblPlan);
        }

        private void planCostAboveButton_Click(object sender, EventArgs e)
        {
            tblPlanTableAdapter.FillByPlanCostAbove4000(this.jobDataSet.tblPlan);
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            double total;
            total = (double)tblPlanTableAdapter.ScalarQueryTotal();
            MessageBox.Show("Total Cost: " + total.ToString("c"));
        }

        private void averageButton_Click(object sender, EventArgs e)
        {
            double avg;
            avg = (double)tblPlanTableAdapter.ScalarQueryAverage();
            MessageBox.Show("Average Cost: " + avg.ToString("c"));
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }

        private void recordButton_Click(object sender, EventArgs e)
        {
            ByRecord record = new ByRecord();
            record.ShowDialog();
            this.tblPlanTableAdapter.Fill(this.jobDataSet.tblPlan);
        }

        private void checkWaivedButton_Click(object sender, EventArgs e)
        {
            tblPlanTableAdapter.FillByFeeWaived(this.jobDataSet.tblPlan);
        }
    }
}
