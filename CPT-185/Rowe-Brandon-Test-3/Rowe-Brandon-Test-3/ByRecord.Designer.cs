namespace Rowe_Brandon_Test_3
{
    partial class ByRecord
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
            System.Windows.Forms.Label planIDLabel;
            System.Windows.Forms.Label planDescriptionLabel;
            System.Windows.Forms.Label planCostLabel;
            System.Windows.Forms.Label feeWaivedLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ByRecord));
            this.jobDataSet = new Rowe_Brandon_Test_3.JobDataSet();
            this.tblPlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPlanTableAdapter = new Rowe_Brandon_Test_3.JobDataSetTableAdapters.tblPlanTableAdapter();
            this.tableAdapterManager = new Rowe_Brandon_Test_3.JobDataSetTableAdapters.TableAdapterManager();
            this.tblPlanBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.planIDTextBox = new System.Windows.Forms.TextBox();
            this.planDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.planCostTextBox = new System.Windows.Forms.TextBox();
            this.feeWaivedCheckBox = new System.Windows.Forms.CheckBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            planIDLabel = new System.Windows.Forms.Label();
            planDescriptionLabel = new System.Windows.Forms.Label();
            planCostLabel = new System.Windows.Forms.Label();
            feeWaivedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jobDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPlanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPlanBindingNavigator)).BeginInit();
            this.tblPlanBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // planIDLabel
            // 
            planIDLabel.AutoSize = true;
            planIDLabel.Location = new System.Drawing.Point(26, 50);
            planIDLabel.Name = "planIDLabel";
            planIDLabel.Size = new System.Drawing.Size(53, 15);
            planIDLabel.TabIndex = 1;
            planIDLabel.Text = "Plan ID:";
            // 
            // planDescriptionLabel
            // 
            planDescriptionLabel.AutoSize = true;
            planDescriptionLabel.Location = new System.Drawing.Point(26, 80);
            planDescriptionLabel.Name = "planDescriptionLabel";
            planDescriptionLabel.Size = new System.Drawing.Size(99, 15);
            planDescriptionLabel.TabIndex = 3;
            planDescriptionLabel.Text = "Plan Description:";
            // 
            // planCostLabel
            // 
            planCostLabel.AutoSize = true;
            planCostLabel.Location = new System.Drawing.Point(26, 110);
            planCostLabel.Name = "planCostLabel";
            planCostLabel.Size = new System.Drawing.Size(61, 15);
            planCostLabel.TabIndex = 5;
            planCostLabel.Text = "Plan Cost:";
            // 
            // feeWaivedLabel
            // 
            feeWaivedLabel.AutoSize = true;
            feeWaivedLabel.Location = new System.Drawing.Point(26, 142);
            feeWaivedLabel.Name = "feeWaivedLabel";
            feeWaivedLabel.Size = new System.Drawing.Size(72, 15);
            feeWaivedLabel.TabIndex = 7;
            feeWaivedLabel.Text = "Fee Waived:";
            // 
            // jobDataSet
            // 
            this.jobDataSet.DataSetName = "JobDataSet";
            this.jobDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPlanBindingSource
            // 
            this.tblPlanBindingSource.DataMember = "tblPlan";
            this.tblPlanBindingSource.DataSource = this.jobDataSet;
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
            this.tblPlanBindingNavigator.Size = new System.Drawing.Size(343, 25);
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
            // planIDTextBox
            // 
            this.planIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPlanBindingSource, "PlanID", true));
            this.planIDTextBox.Location = new System.Drawing.Point(134, 46);
            this.planIDTextBox.Name = "planIDTextBox";
            this.planIDTextBox.Size = new System.Drawing.Size(121, 21);
            this.planIDTextBox.TabIndex = 2;
            // 
            // planDescriptionTextBox
            // 
            this.planDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPlanBindingSource, "PlanDescription", true));
            this.planDescriptionTextBox.Location = new System.Drawing.Point(134, 76);
            this.planDescriptionTextBox.Name = "planDescriptionTextBox";
            this.planDescriptionTextBox.Size = new System.Drawing.Size(121, 21);
            this.planDescriptionTextBox.TabIndex = 4;
            // 
            // planCostTextBox
            // 
            this.planCostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPlanBindingSource, "PlanCost", true));
            this.planCostTextBox.Location = new System.Drawing.Point(134, 106);
            this.planCostTextBox.Name = "planCostTextBox";
            this.planCostTextBox.Size = new System.Drawing.Size(121, 21);
            this.planCostTextBox.TabIndex = 6;
            // 
            // feeWaivedCheckBox
            // 
            this.feeWaivedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblPlanBindingSource, "FeeWaived", true));
            this.feeWaivedCheckBox.Location = new System.Drawing.Point(134, 136);
            this.feeWaivedCheckBox.Name = "feeWaivedCheckBox";
            this.feeWaivedCheckBox.Size = new System.Drawing.Size(121, 28);
            this.feeWaivedCheckBox.TabIndex = 8;
            this.feeWaivedCheckBox.Text = "checkBox1";
            this.feeWaivedCheckBox.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(105, 207);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(87, 27);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "&Close";
            this.toolTip1.SetToolTip(this.closeButton, "Close this form and return to main form");
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // ByRecord
            // 
            this.AcceptButton = this.closeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(343, 286);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(planIDLabel);
            this.Controls.Add(this.planIDTextBox);
            this.Controls.Add(planDescriptionLabel);
            this.Controls.Add(this.planDescriptionTextBox);
            this.Controls.Add(planCostLabel);
            this.Controls.Add(this.planCostTextBox);
            this.Controls.Add(feeWaivedLabel);
            this.Controls.Add(this.feeWaivedCheckBox);
            this.Controls.Add(this.tblPlanBindingNavigator);
            this.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ByRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BY Record";
            this.Load += new System.EventHandler(this.ByRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPlanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPlanBindingNavigator)).EndInit();
            this.tblPlanBindingNavigator.ResumeLayout(false);
            this.tblPlanBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.TextBox planIDTextBox;
        private System.Windows.Forms.TextBox planDescriptionTextBox;
        private System.Windows.Forms.TextBox planCostTextBox;
        private System.Windows.Forms.CheckBox feeWaivedCheckBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}