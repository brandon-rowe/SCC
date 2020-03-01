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
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tblPlanBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tblPlanDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortAscButton = new System.Windows.Forms.Button();
            this.sortDesButton = new System.Windows.Forms.Button();
            this.planCostBelowButton = new System.Windows.Forms.Button();
            this.planCostAboveButton = new System.Windows.Forms.Button();
            this.checkWaivedButton = new System.Windows.Forms.Button();
            this.totalButton = new System.Windows.Forms.Button();
            this.averageButton = new System.Windows.Forms.Button();
            this.recordButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblPlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobDataSet = new Rowe_Brandon_Test_3.JobDataSet();
            this.tblPlanTableAdapter = new Rowe_Brandon_Test_3.JobDataSetTableAdapters.tblPlanTableAdapter();
            this.tableAdapterManager = new Rowe_Brandon_Test_3.JobDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.tblPlanBindingNavigator)).BeginInit();
            this.tblPlanBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPlanDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPlanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobDataSet)).BeginInit();
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
            this.tblPlanBindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.tblPlanBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblPlanBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblPlanBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblPlanBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblPlanBindingNavigator.Name = "tblPlanBindingNavigator";
            this.tblPlanBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblPlanBindingNavigator.Size = new System.Drawing.Size(812, 25);
            this.tblPlanBindingNavigator.TabIndex = 0;
            this.tblPlanBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            this.tblPlanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPlanDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1});
            this.tblPlanDataGridView.DataSource = this.tblPlanBindingSource;
            this.tblPlanDataGridView.Location = new System.Drawing.Point(0, 52);
            this.tblPlanDataGridView.Name = "tblPlanDataGridView";
            this.tblPlanDataGridView.Size = new System.Drawing.Size(458, 254);
            this.tblPlanDataGridView.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(812, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.ToolTipText = "View the about page";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // sortAscButton
            // 
            this.sortAscButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortAscButton.Location = new System.Drawing.Point(526, 52);
            this.sortAscButton.Name = "sortAscButton";
            this.sortAscButton.Size = new System.Drawing.Size(235, 29);
            this.sortAscButton.TabIndex = 3;
            this.sortAscButton.Text = "Sort Plan Cost in Asc";
            this.toolTip1.SetToolTip(this.sortAscButton, "Sorts the data from least to greatest by Cost");
            this.sortAscButton.UseVisualStyleBackColor = true;
            this.sortAscButton.Click += new System.EventHandler(this.sortAscButton_Click);
            // 
            // sortDesButton
            // 
            this.sortDesButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortDesButton.Location = new System.Drawing.Point(526, 87);
            this.sortDesButton.Name = "sortDesButton";
            this.sortDesButton.Size = new System.Drawing.Size(235, 29);
            this.sortDesButton.TabIndex = 4;
            this.sortDesButton.Text = "Sort Plan Cost in Desc";
            this.toolTip1.SetToolTip(this.sortDesButton, "Sorts the data from greatest to least by Cost");
            this.sortDesButton.UseVisualStyleBackColor = true;
            this.sortDesButton.Click += new System.EventHandler(this.sortDesButton_Click);
            // 
            // planCostBelowButton
            // 
            this.planCostBelowButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planCostBelowButton.Location = new System.Drawing.Point(526, 122);
            this.planCostBelowButton.Name = "planCostBelowButton";
            this.planCostBelowButton.Size = new System.Drawing.Size(235, 29);
            this.planCostBelowButton.TabIndex = 5;
            this.planCostBelowButton.Text = "Plan Cost below $1000.00";
            this.toolTip1.SetToolTip(this.planCostBelowButton, "Shows Plans below $1000");
            this.planCostBelowButton.UseVisualStyleBackColor = true;
            this.planCostBelowButton.Click += new System.EventHandler(this.planCostBelowButton_Click);
            // 
            // planCostAboveButton
            // 
            this.planCostAboveButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planCostAboveButton.Location = new System.Drawing.Point(526, 157);
            this.planCostAboveButton.Name = "planCostAboveButton";
            this.planCostAboveButton.Size = new System.Drawing.Size(235, 29);
            this.planCostAboveButton.TabIndex = 6;
            this.planCostAboveButton.Text = "Plan Cost Above $4000.00";
            this.toolTip1.SetToolTip(this.planCostAboveButton, "Shows plans above $4000");
            this.planCostAboveButton.UseVisualStyleBackColor = true;
            this.planCostAboveButton.Click += new System.EventHandler(this.planCostAboveButton_Click);
            // 
            // checkWaivedButton
            // 
            this.checkWaivedButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkWaivedButton.Location = new System.Drawing.Point(526, 192);
            this.checkWaivedButton.Name = "checkWaivedButton";
            this.checkWaivedButton.Size = new System.Drawing.Size(235, 29);
            this.checkWaivedButton.TabIndex = 7;
            this.checkWaivedButton.Text = "Checked FeeWaived";
            this.toolTip1.SetToolTip(this.checkWaivedButton, "Shows only records with waived fees");
            this.checkWaivedButton.UseVisualStyleBackColor = true;
            this.checkWaivedButton.Click += new System.EventHandler(this.checkWaivedButton_Click);
            // 
            // totalButton
            // 
            this.totalButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalButton.Location = new System.Drawing.Point(526, 227);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(235, 29);
            this.totalButton.TabIndex = 8;
            this.totalButton.Text = "Plan Cost Total";
            this.toolTip1.SetToolTip(this.totalButton, "Show the Total cost in messagebox");
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // averageButton
            // 
            this.averageButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.averageButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageButton.Location = new System.Drawing.Point(526, 262);
            this.averageButton.Name = "averageButton";
            this.averageButton.Size = new System.Drawing.Size(235, 29);
            this.averageButton.TabIndex = 9;
            this.averageButton.Text = "Plan Cost Average";
            this.toolTip1.SetToolTip(this.averageButton, "Show the Average cost in messagebox");
            this.averageButton.UseVisualStyleBackColor = true;
            this.averageButton.Click += new System.EventHandler(this.averageButton_Click);
            // 
            // recordButton
            // 
            this.recordButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordButton.Location = new System.Drawing.Point(526, 297);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(86, 39);
            this.recordButton.TabIndex = 10;
            this.recordButton.Text = "&By Record";
            this.toolTip1.SetToolTip(this.recordButton, "Open form to view individual record");
            this.recordButton.UseVisualStyleBackColor = true;
            this.recordButton.Click += new System.EventHandler(this.recordButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(675, 297);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(86, 39);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "&Exit";
            this.toolTip1.SetToolTip(this.exitButton, "Close this program");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
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
            // Form1
            // 
            this.AcceptButton = this.recordButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(812, 348);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.recordButton);
            this.Controls.Add(this.averageButton);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.checkWaivedButton);
            this.Controls.Add(this.planCostAboveButton);
            this.Controls.Add(this.planCostBelowButton);
            this.Controls.Add(this.sortDesButton);
            this.Controls.Add(this.sortAscButton);
            this.Controls.Add(this.tblPlanDataGridView);
            this.Controls.Add(this.tblPlanBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brandon Rowe Test-3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblPlanBindingNavigator)).EndInit();
            this.tblPlanBindingNavigator.ResumeLayout(false);
            this.tblPlanBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPlanDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPlanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobDataSet)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button sortAscButton;
        private System.Windows.Forms.Button sortDesButton;
        private System.Windows.Forms.Button planCostBelowButton;
        private System.Windows.Forms.Button planCostAboveButton;
        private System.Windows.Forms.Button checkWaivedButton;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Button averageButton;
        private System.Windows.Forms.Button recordButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

