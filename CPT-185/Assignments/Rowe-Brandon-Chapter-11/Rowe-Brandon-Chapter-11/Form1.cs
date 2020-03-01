using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rowe_Brandon_Chapter_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tblContractBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblContractBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productionDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productionDataSet.tblContract' table. You can move, or remove it, as needed.
            this.tblContractTableAdapter.Fill(this.productionDataSet.tblContract);

        }

        private void highestCostButton_Click(object sender, EventArgs e)
        {
            double max;
            max = (double)tblContractTableAdapter.ScalarQueryHighest();
            highestLabel.Text = max.ToString("c");
        }

        private void SortAscButton_Click(object sender, EventArgs e)
        {
            tblContractTableAdapter.FillBySessionType(this.productionDataSet.tblContract);
        }

        private void SortDesButton_Click(object sender, EventArgs e)
        {
            tblContractTableAdapter.FillBySessionTypeDes(this.productionDataSet.tblContract);
        }

        private void numberRowsButton_Click(object sender, EventArgs e)
        {
            double cnt;
            cnt = (double)tblContractTableAdapter.ScalarQueryCount();
            rowsLabel.Text = cnt.ToString();
        }

        private void avgCostButton_Click(object sender, EventArgs e)
        {
            double avg;
            avg = (double)tblContractTableAdapter.ScalarQueryAverageCost();
            averageLabel.Text = avg.ToString("c");
        }

        private void lowestCostButton_Click(object sender, EventArgs e)
        {
            double min;
            min = (double)tblContractTableAdapter.ScalarQueryLowest();
            lowestLabel.Text = min.ToString("c");
        }

        private void totalCostButton_Click(object sender, EventArgs e)
        {
            double total;
            total = (double)tblContractTableAdapter.ScalarQueryTotal();
            totalLabel.Text = total.ToString("c");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            rowsLabel.Text = "";
            averageLabel.Text = "";
            highestLabel.Text = "";
            lowestLabel.Text = "";
            totalLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
