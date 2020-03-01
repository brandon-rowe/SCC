namespace Rowe_Brandon_Chapter_11
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
            this.tblContractBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tblContractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productionDataSet = new Rowe_Brandon_Chapter_11.ProductionDataSet();
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
            this.tblContractBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tblContractDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SortAscButton = new System.Windows.Forms.Button();
            this.SortDesButton = new System.Windows.Forms.Button();
            this.numberRowsButton = new System.Windows.Forms.Button();
            this.avgCostButton = new System.Windows.Forms.Button();
            this.highestCostButton = new System.Windows.Forms.Button();
            this.lowestCostButton = new System.Windows.Forms.Button();
            this.totalCostButton = new System.Windows.Forms.Button();
            this.tblContractTableAdapter = new Rowe_Brandon_Chapter_11.ProductionDataSetTableAdapters.tblContractTableAdapter();
            this.tableAdapterManager = new Rowe_Brandon_Chapter_11.ProductionDataSetTableAdapters.TableAdapterManager();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitButton = new System.Windows.Forms.Button();
            this.rowsLabel = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.highestLabel = new System.Windows.Forms.Label();
            this.lowestLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblContractBindingNavigator)).BeginInit();
            this.tblContractBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblContractBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblContractDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblContractBindingNavigator
            // 
            this.tblContractBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblContractBindingNavigator.BindingSource = this.tblContractBindingSource;
            this.tblContractBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblContractBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblContractBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblContractBindingNavigatorSaveItem});
            this.tblContractBindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.tblContractBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblContractBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblContractBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblContractBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblContractBindingNavigator.Name = "tblContractBindingNavigator";
            this.tblContractBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblContractBindingNavigator.Size = new System.Drawing.Size(1251, 25);
            this.tblContractBindingNavigator.TabIndex = 0;
            this.tblContractBindingNavigator.Text = "bindingNavigator1";
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
            // tblContractBindingSource
            // 
            this.tblContractBindingSource.DataMember = "tblContract";
            this.tblContractBindingSource.DataSource = this.productionDataSet;
            // 
            // productionDataSet
            // 
            this.productionDataSet.DataSetName = "ProductionDataSet";
            this.productionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tblContractBindingNavigatorSaveItem
            // 
            this.tblContractBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblContractBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblContractBindingNavigatorSaveItem.Image")));
            this.tblContractBindingNavigatorSaveItem.Name = "tblContractBindingNavigatorSaveItem";
            this.tblContractBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblContractBindingNavigatorSaveItem.Text = "Save Data";
            this.tblContractBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblContractBindingNavigatorSaveItem_Click);
            // 
            // tblContractDataGridView
            // 
            this.tblContractDataGridView.AutoGenerateColumns = false;
            this.tblContractDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblContractDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewCheckBoxColumn1});
            this.tblContractDataGridView.DataSource = this.tblContractBindingSource;
            this.tblContractDataGridView.Location = new System.Drawing.Point(0, 28);
            this.tblContractDataGridView.Name = "tblContractDataGridView";
            this.tblContractDataGridView.Size = new System.Drawing.Size(945, 449);
            this.tblContractDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ContractID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ContractID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "StudentID";
            this.dataGridViewTextBoxColumn2.HeaderText = "StudentID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TutorID";
            this.dataGridViewTextBoxColumn3.HeaderText = "TutorID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ContractDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "ContractDate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SessionType";
            this.dataGridViewTextBoxColumn5.HeaderText = "SessionType";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Length";
            this.dataGridViewTextBoxColumn6.HeaderText = "Length";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "NumSessions";
            this.dataGridViewTextBoxColumn7.HeaderText = "NumSessions";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Cost";
            this.dataGridViewTextBoxColumn8.HeaderText = "Cost";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Assessment";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Assessment";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // SortAscButton
            // 
            this.SortAscButton.Location = new System.Drawing.Point(28, 510);
            this.SortAscButton.Name = "SortAscButton";
            this.SortAscButton.Size = new System.Drawing.Size(86, 52);
            this.SortAscButton.TabIndex = 2;
            this.SortAscButton.Text = "Sort In Asc by Session Type";
            this.SortAscButton.UseVisualStyleBackColor = true;
            this.SortAscButton.Click += new System.EventHandler(this.SortAscButton_Click);
            // 
            // SortDesButton
            // 
            this.SortDesButton.Location = new System.Drawing.Point(28, 580);
            this.SortDesButton.Name = "SortDesButton";
            this.SortDesButton.Size = new System.Drawing.Size(86, 52);
            this.SortDesButton.TabIndex = 3;
            this.SortDesButton.Text = "Sort In Des by Session Type";
            this.SortDesButton.UseVisualStyleBackColor = true;
            this.SortDesButton.Click += new System.EventHandler(this.SortDesButton_Click);
            // 
            // numberRowsButton
            // 
            this.numberRowsButton.Location = new System.Drawing.Point(196, 510);
            this.numberRowsButton.Name = "numberRowsButton";
            this.numberRowsButton.Size = new System.Drawing.Size(86, 52);
            this.numberRowsButton.TabIndex = 4;
            this.numberRowsButton.Text = "Display Number of Rows";
            this.numberRowsButton.UseVisualStyleBackColor = true;
            this.numberRowsButton.Click += new System.EventHandler(this.numberRowsButton_Click);
            // 
            // avgCostButton
            // 
            this.avgCostButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.avgCostButton.Location = new System.Drawing.Point(196, 580);
            this.avgCostButton.Name = "avgCostButton";
            this.avgCostButton.Size = new System.Drawing.Size(86, 52);
            this.avgCostButton.TabIndex = 5;
            this.avgCostButton.Text = "Average Cost";
            this.avgCostButton.UseVisualStyleBackColor = true;
            this.avgCostButton.Click += new System.EventHandler(this.avgCostButton_Click);
            // 
            // highestCostButton
            // 
            this.highestCostButton.Location = new System.Drawing.Point(383, 510);
            this.highestCostButton.Name = "highestCostButton";
            this.highestCostButton.Size = new System.Drawing.Size(86, 52);
            this.highestCostButton.TabIndex = 6;
            this.highestCostButton.Text = "Highest Cost";
            this.highestCostButton.UseVisualStyleBackColor = true;
            this.highestCostButton.Click += new System.EventHandler(this.highestCostButton_Click);
            // 
            // lowestCostButton
            // 
            this.lowestCostButton.Location = new System.Drawing.Point(383, 580);
            this.lowestCostButton.Name = "lowestCostButton";
            this.lowestCostButton.Size = new System.Drawing.Size(86, 52);
            this.lowestCostButton.TabIndex = 7;
            this.lowestCostButton.Text = "Lowest Cost";
            this.lowestCostButton.UseVisualStyleBackColor = true;
            this.lowestCostButton.Click += new System.EventHandler(this.lowestCostButton_Click);
            // 
            // totalCostButton
            // 
            this.totalCostButton.Location = new System.Drawing.Point(579, 510);
            this.totalCostButton.Name = "totalCostButton";
            this.totalCostButton.Size = new System.Drawing.Size(86, 52);
            this.totalCostButton.TabIndex = 8;
            this.totalCostButton.Text = "Total Cost";
            this.totalCostButton.UseVisualStyleBackColor = true;
            this.totalCostButton.Click += new System.EventHandler(this.totalCostButton_Click);
            // 
            // tblContractTableAdapter
            // 
            this.tblContractTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblContractTableAdapter = this.tblContractTableAdapter;
            this.tableAdapterManager.UpdateOrder = Rowe_Brandon_Chapter_11.ProductionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1251, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(770, 510);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(86, 52);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // rowsLabel
            // 
            this.rowsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rowsLabel.Location = new System.Drawing.Point(1086, 220);
            this.rowsLabel.Name = "rowsLabel";
            this.rowsLabel.Size = new System.Drawing.Size(151, 23);
            this.rowsLabel.TabIndex = 11;
            this.rowsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // averageLabel
            // 
            this.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageLabel.Location = new System.Drawing.Point(1086, 271);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(151, 23);
            this.averageLabel.TabIndex = 12;
            this.averageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // highestLabel
            // 
            this.highestLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.highestLabel.Location = new System.Drawing.Point(1086, 326);
            this.highestLabel.Name = "highestLabel";
            this.highestLabel.Size = new System.Drawing.Size(151, 23);
            this.highestLabel.TabIndex = 13;
            this.highestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lowestLabel
            // 
            this.lowestLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lowestLabel.Location = new System.Drawing.Point(1086, 387);
            this.lowestLabel.Name = "lowestLabel";
            this.lowestLabel.Size = new System.Drawing.Size(151, 23);
            this.lowestLabel.TabIndex = 14;
            this.lowestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Location = new System.Drawing.Point(1086, 449);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(151, 23);
            this.totalLabel.TabIndex = 15;
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(970, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Number of Rows:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(970, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Average Cost:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(970, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Highest Cost:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(970, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Lowest Cost:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(970, 459);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Total Cost:";
            // 
            // clearButton
            // 
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.Location = new System.Drawing.Point(579, 580);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(86, 52);
            this.clearButton.TabIndex = 21;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.SortAscButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(1251, 650);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.lowestLabel);
            this.Controls.Add(this.highestLabel);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.rowsLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.totalCostButton);
            this.Controls.Add(this.lowestCostButton);
            this.Controls.Add(this.highestCostButton);
            this.Controls.Add(this.avgCostButton);
            this.Controls.Add(this.numberRowsButton);
            this.Controls.Add(this.SortDesButton);
            this.Controls.Add(this.SortAscButton);
            this.Controls.Add(this.tblContractDataGridView);
            this.Controls.Add(this.tblContractBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Rowe-Brandon-Chapter-11";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblContractBindingNavigator)).EndInit();
            this.tblContractBindingNavigator.ResumeLayout(false);
            this.tblContractBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblContractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblContractDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProductionDataSet productionDataSet;
        private System.Windows.Forms.BindingSource tblContractBindingSource;
        private ProductionDataSetTableAdapters.tblContractTableAdapter tblContractTableAdapter;
        private ProductionDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblContractBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tblContractBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tblContractDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button SortAscButton;
        private System.Windows.Forms.Button SortDesButton;
        private System.Windows.Forms.Button numberRowsButton;
        private System.Windows.Forms.Button avgCostButton;
        private System.Windows.Forms.Button highestCostButton;
        private System.Windows.Forms.Button lowestCostButton;
        private System.Windows.Forms.Button totalCostButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label rowsLabel;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label highestLabel;
        private System.Windows.Forms.Label lowestLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button clearButton;
    }
}

