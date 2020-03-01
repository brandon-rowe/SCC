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
    public partial class ByRecord : Form
    {
        public ByRecord()
        {
            InitializeComponent();
        }

        private void tblPlanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblPlanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jobDataSet);

        }

        private void ByRecord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jobDataSet.tblPlan' table. You can move, or remove it, as needed.
            this.tblPlanTableAdapter.Fill(this.jobDataSet.tblPlan);

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
