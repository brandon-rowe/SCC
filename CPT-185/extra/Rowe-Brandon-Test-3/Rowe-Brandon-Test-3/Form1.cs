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

        private void byRecordButton_Click(object sender, EventArgs e)
        {
            ByRecord details = new ByRecord();
            details.ShowDialog();
            this.tblPlanTableAdapter.Fill(this.jobDataSet.tblPlan);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void sortPlanAscButton_Click(object sender, EventArgs e)
        {
            this.tblPlanTableAdapter.FillByCostASC(this.jobDataSet.tblPlan);
        }

        private void sortPlanDescButton_Click(object sender, EventArgs e)
        {
            this.tblPlanTableAdapter.FillByCostDesc(this.jobDataSet.tblPlan);
        }

        private void planTotalButton_Click(object sender, EventArgs e)
        {
            decimal totalCost;
            totalCost = (decimal)tblPlanTableAdapter.ScalarQueryTotal();
            MessageBox.Show("Total Cost: " + totalCost.ToString());
        }

        private void planAverageButton_Click(object sender, EventArgs e)
        {
            double avg;
            avg = (double)tblPlanTableAdapter.ScalarQueryAverage();
            MessageBox.Show("Average Cost: " + avg.ToString());
        }

        private void planCostbelowButton_Click(object sender, EventArgs e)
        {
            this.tblPlanTableAdapter.FillByCostLess1000(this.jobDataSet.tblPlan);
        }

        private void planCostAboveButton_Click(object sender, EventArgs e)
        {
            this.tblPlanTableAdapter.FillByCostGreater4000(this.jobDataSet.tblPlan);
        }

        private void checkedFeeWaivButton_Click(object sender, EventArgs e)
        {
            this.tblPlanTableAdapter.FillByFeeWaived(this.jobDataSet.tblPlan);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
