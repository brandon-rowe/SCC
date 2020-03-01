namespace Rowe_Brandon_Test_3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tblPlanBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tblPlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobDataSet = new Rowe_Brandon_Test_3.JobDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tblPlanBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tblPlanDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.byRecordButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.sortPlanAscButton = new System.Windows.Forms.Button();
            this.sortPlanDescButton = new System.Windows.Forms.Button();
            this.planCostbelowButton = new System.Windows.Forms.Button();
            this.planCostAboveButton = new System.Windows.Forms.Button();
            this.checkedFeeWaivButton = new System.Windows.Forms.Button();
            this.planTotalButton = new System.Windows.Forms.Button();
            this.planAverageButton = new System.Windows.Forms.Button();
            this.tblPlanTableAdapter = new Rowe_Brandon_Test_3.JobDataSetTableAdapters.tblPlanTableAdapter();
            this.tableAdapterManager = new Rowe_Brandon_Test_3.JobDataSetTableAdapters.TableAdapterManager();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tblPlanBindingNavigator)).BeginInit();
            this.tblPlanBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPlanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPlanDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tblPlanBindingNavigator
            // 
            this.tblPlanBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblPlanBindingNavigator.BindingSource = this.tblPlanBindingSource;
            this.tblPlanBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblPlanBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblPlanBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tblPlanBindingNavigatorSaveItem});
            this.tblPlanBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblPlanBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblPlanBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblPlanBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblPlanBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblPlanBindingNavigator.Name = "tblPlanBindingNavigator";
            this.tblPlanBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblPlanBindingNavigator.Size = new System.Drawing.Size(844, 25);
            this.tblPlanBindingNavigator.TabIndex = 0;
            this.tblPlanBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // tblPlanBindingSource
            // 
            this.tblPlanBindingSource.DataMember = "tblPlan";
            this.tblPlanBindingSource.DataSource = this.jobDataSet;
            // 
            // jobDataSet
            // 
            this.jobDataSet.DataSetName = "JobDataSet";
            this.jobDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tblPlanBindingNavigatorSaveItem
            // 
            this.tblPlanBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblPlanBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblPlanBindingNavigatorSaveItem.Image")));
            this.tblPlanBindingNavigatorSaveItem.Name = "tblPlanBindingNavigatorSaveItem";
            this.tblPlanBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblPlanBindingNavigatorSaveItem.Text = "Save Data";
            this.tblPlanBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblPlanBindingNavigatorSaveItem_Click);
            // 
            // tblPlanDataGridView
            // 
            this.tblPlanDataGridView.AutoGenerateColumns = false;
            this.tblPlanDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tblPlanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPlanDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1});
            this.tblPlanDataGridView.DataSource = this.tblPlanBindingSource;
            this.tblPlanDataGridView.Location = new System.Drawing.Point(14, 30);
            this.tblPlanDataGridView.Name = "tblPlanDataGridView";
            this.tblPlanDataGridView.Size = new System.Drawing.Size(524, 346);
            this.tblPlanDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PlanID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PlanID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PlanDescription";
            this.dataGridViewTextBoxColumn2.HeaderText = "PlanDescription";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PlanCost";
            this.dataGridViewTextBoxColumn3.HeaderText = "PlanCost";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "FeeWaived";
            this.dataGridViewCheckBoxColumn1.HeaderText = "FeeWaived";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // byRecordButton
            // 
            this.byRecordButton.Location = new System.Drawing.Point(96, 392);
            this.byRecordButton.Name = "byRecordButton";
            this.byRecordButton.Size = new System.Drawing.Size(87, 25);
            this.byRecordButton.TabIndex = 2;
            this.byRecordButton.Text = "&By Record";
            this.toolTip1.SetToolTip(this.byRecordButton, "Display Records Individually");
            this.byRecordButton.UseVisualStyleBackColor = true;
            this.byRecordButton.Click += new System.EventHandler(this.byRecordButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(329, 392);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(87, 25);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "&Exit";
            this.toolTip1.SetToolTip(this.exitButton, "Please Leave");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // sortPlanAscButton
            // 
            this.sortPlanAscButton.Location = new System.Drawing.Point(602, 30);
            this.sortPlanAscButton.Name = "sortPlanAscButton";
            this.sortPlanAscButton.Size = new System.Drawing.Size(204, 25);
            this.sortPlanAscButton.TabIndex = 4;
            this.sortPlanAscButton.Text = "Sort Plan Cost in Asc";
            this.toolTip1.SetToolTip(this.sortPlanAscButton, "Ascending?");
            this.sortPlanAscButton.UseVisualStyleBackColor = true;
            this.sortPlanAscButton.Click += new System.EventHandler(this.sortPlanAscButton_Click);
            // 
            // sortPlanDescButton
            // 
            this.sortPlanDescButton.Location = new System.Drawing.Point(602, 78);
            this.sortPlanDescButton.Name = "sortPlanDescButton";
            this.sortPlanDescButton.Size = new System.Drawing.Size(204, 25);
            this.sortPlanDescButton.TabIndex = 5;
            this.sortPlanDescButton.Text = "Sort Plan Cost in Desc";
            this.toolTip1.SetToolTip(this.sortPlanDescButton, "Descending?");
            this.sortPlanDescButton.UseVisualStyleBackColor = true;
            this.sortPlanDescButton.Click += new System.EventHandler(this.sortPlanDescButton_Click);
            // 
            // planCostbelowButton
            // 
            this.planCostbelowButton.Location = new System.Drawing.Point(602, 136);
            this.planCostbelowButton.Name = "planCostbelowButton";
            this.planCostbelowButton.Size = new System.Drawing.Size(204, 25);
            this.planCostbelowButton.TabIndex = 6;
            this.planCostbelowButton.Text = "Plan Cost below $1000.00";
            this.toolTip1.SetToolTip(this.planCostbelowButton, "Cheap?");
            this.planCostbelowButton.UseVisualStyleBackColor = true;
            this.planCostbelowButton.Click += new System.EventHandler(this.planCostbelowButton_Click);
            // 
            // planCostAboveButton
            // 
            this.planCostAboveButton.Location = new System.Drawing.Point(602, 190);
            this.planCostAboveButton.Name = "planCostAboveButton";
            this.planCostAboveButton.Size = new System.Drawing.Size(204, 25);
            this.planCostAboveButton.TabIndex = 7;
            this.planCostAboveButton.Text = "Plan Cost above $4000.00";
            this.toolTip1.SetToolTip(this.planCostAboveButton, "Expensive?");
            this.planCostAboveButton.UseVisualStyleBackColor = true;
            this.planCostAboveButton.Click += new System.EventHandler(this.planCostAboveButton_Click);
            // 
            // checkedFeeWaivButton
            // 
            this.checkedFeeWaivButton.Location = new System.Drawing.Point(602, 244);
            this.checkedFeeWaivButton.Name = "checkedFeeWaivButton";
            this.checkedFeeWaivButton.Size = new System.Drawing.Size(204, 25);
            this.checkedFeeWaivButton.TabIndex = 8;
            this.checkedFeeWaivButton.Text = "Checked Fee Waived";
            this.toolTip1.SetToolTip(this.checkedFeeWaivButton, "Hopefully!");
            this.checkedFeeWaivButton.UseVisualStyleBackColor = true;
            this.checkedFeeWaivButton.Click += new System.EventHandler(this.checkedFeeWaivButton_Click);
            // 
            // planTotalButton
            // 
            this.planTotalButton.Location = new System.Drawing.Point(602, 299);
            this.planTotalButton.Name = "planTotalButton";
            this.planTotalButton.Size = new System.Drawing.Size(204, 25);
            this.planTotalButton.TabIndex = 9;
            this.planTotalButton.Text = "Plan Cost Total";
            this.toolTip1.SetToolTip(this.planTotalButton, "Total of all plan costs.");
            this.planTotalButton.UseVisualStyleBackColor = true;
            this.planTotalButton.Click += new System.EventHandler(this.planTotalButton_Click);
            // 
            // planAverageButton
            // 
            this.planAverageButton.Location = new System.Drawing.Point(602, 351);
            this.planAverageButton.Name = "planAverageButton";
            this.planAverageButton.Size = new System.Drawing.Size(204, 25);
            this.planAverageButton.TabIndex = 10;
            this.planAverageButton.Text = "Plan Cost Average";
            this.toolTip1.SetToolTip(this.planAverageButton, "Average of Plan Costs.");
            this.planAverageButton.UseVisualStyleBackColor = true;
            this.planAverageButton.Click += new System.EventHandler(this.planAverageButton_Click);
            // 
            // tblPlanTableAdapter
            // 
            this.tblPlanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblPlanTableAdapter = this.tblPlanTableAdapter;
            this.tableAdapterManager.UpdateOrder = Rowe_Brandon_Test_3.JobDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(844, 438);
            this.Controls.Add(this.planAverageButton);
            this.Controls.Add(this.planTotalButton);
            this.Controls.Add(this.checkedFeeWaivButton);
            this.Controls.Add(this.planCostAboveButton);
            this.Controls.Add(this.planCostbelowButton);
            this.Controls.Add(this.sortPlanDescButton);
            this.Controls.Add(this.sortPlanAscButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.byRecordButton);
            this.Controls.Add(this.tblPlanDataGridView);
            this.Controls.Add(this.tblPlanBindingNavigator);
            this.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brandon Rowe Test-3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblPlanBindingNavigator)).EndInit();
            this.tblPlanBindingNavigator.ResumeLayout(false);
            this.tblPlanBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPlanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPlanDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JobDataSet jobDataSet;
        private System.Windows.Forms.BindingSource tblPlanBindingSource;
        private JobDataSetTableAdapters.tblPlanTableAdapter tblPlanTableAdapter;
        private JobDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblPlanBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tblPlanBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tblPlanDataGridView;
        private System.Windows.Forms.Button byRecordButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button sortPlanAscButton;
        private System.Windows.Forms.Button sortPlanDescButton;
        private System.Windows.Forms.Button planCostbelowButton;
        private System.Windows.Forms.Button planCostAboveButton;
        private System.Windows.Forms.Button checkedFeeWaivButton;
        private System.Windows.Forms.Button planTotalButton;
        private System.Windows.Forms.Button planAverageButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

