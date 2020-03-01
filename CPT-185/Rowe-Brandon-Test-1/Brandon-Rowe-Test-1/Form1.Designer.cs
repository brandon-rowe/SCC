namespace Brandon_Rowe_Test_1
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
            this.startButton = new System.Windows.Forms.Button();
            this.instructFirstNameLabel = new System.Windows.Forms.Label();
            this.instructLastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.outputNameLabel = new System.Windows.Forms.Label();
            this.accountActivitiesLabel = new System.Windows.Forms.Label();
            this.accountActivityGroupBox = new System.Windows.Forms.GroupBox();
            this.instructTotalLabel = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.iraTextBox = new System.Windows.Forms.TextBox();
            this.savingAccountTextBox = new System.Windows.Forms.TextBox();
            this.checkingAccountTextBox = new System.Windows.Forms.TextBox();
            this.addValueTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.iraButton = new System.Windows.Forms.Button();
            this.savingAccountButton = new System.Windows.Forms.Button();
            this.checkingAccountButton = new System.Windows.Forms.Button();
            this.instructDepositWithdrawLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.accountActivityGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(33, 19);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(112, 59);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "&Start";
            this.toolTip1.SetToolTip(this.startButton, "Starts Banking Software");
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // instructFirstNameLabel
            // 
            this.instructFirstNameLabel.AutoSize = true;
            this.instructFirstNameLabel.Location = new System.Drawing.Point(200, 19);
            this.instructFirstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.instructFirstNameLabel.Name = "instructFirstNameLabel";
            this.instructFirstNameLabel.Size = new System.Drawing.Size(87, 16);
            this.instructFirstNameLabel.TabIndex = 1;
            this.instructFirstNameLabel.Text = "First Name:";
            // 
            // instructLastNameLabel
            // 
            this.instructLastNameLabel.AutoSize = true;
            this.instructLastNameLabel.Location = new System.Drawing.Point(201, 62);
            this.instructLastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.instructLastNameLabel.Name = "instructLastNameLabel";
            this.instructLastNameLabel.Size = new System.Drawing.Size(86, 16);
            this.instructLastNameLabel.TabIndex = 2;
            this.instructLastNameLabel.Text = "Last Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(312, 13);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(148, 22);
            this.firstNameTextBox.TabIndex = 3;
            this.firstNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(312, 56);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(148, 22);
            this.lastNameTextBox.TabIndex = 4;
            this.lastNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // outputNameLabel
            // 
            this.outputNameLabel.AutoSize = true;
            this.outputNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputNameLabel.Location = new System.Drawing.Point(617, 19);
            this.outputNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputNameLabel.Name = "outputNameLabel";
            this.outputNameLabel.Size = new System.Drawing.Size(0, 16);
            this.outputNameLabel.TabIndex = 5;
            this.outputNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.outputNameLabel.Visible = false;
            // 
            // accountActivitiesLabel
            // 
            this.accountActivitiesLabel.AutoSize = true;
            this.accountActivitiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountActivitiesLabel.Location = new System.Drawing.Point(617, 62);
            this.accountActivitiesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountActivitiesLabel.Name = "accountActivitiesLabel";
            this.accountActivitiesLabel.Size = new System.Drawing.Size(134, 16);
            this.accountActivitiesLabel.TabIndex = 6;
            this.accountActivitiesLabel.Text = "Accounts Acivities";
            this.accountActivitiesLabel.Visible = false;
            // 
            // accountActivityGroupBox
            // 
            this.accountActivityGroupBox.Controls.Add(this.instructTotalLabel);
            this.accountActivityGroupBox.Controls.Add(this.totalTextBox);
            this.accountActivityGroupBox.Controls.Add(this.iraTextBox);
            this.accountActivityGroupBox.Controls.Add(this.savingAccountTextBox);
            this.accountActivityGroupBox.Controls.Add(this.checkingAccountTextBox);
            this.accountActivityGroupBox.Controls.Add(this.addValueTextBox);
            this.accountActivityGroupBox.Controls.Add(this.exitButton);
            this.accountActivityGroupBox.Controls.Add(this.clearButton);
            this.accountActivityGroupBox.Controls.Add(this.iraButton);
            this.accountActivityGroupBox.Controls.Add(this.savingAccountButton);
            this.accountActivityGroupBox.Controls.Add(this.checkingAccountButton);
            this.accountActivityGroupBox.Controls.Add(this.instructDepositWithdrawLabel);
            this.accountActivityGroupBox.Location = new System.Drawing.Point(33, 105);
            this.accountActivityGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.accountActivityGroupBox.Name = "accountActivityGroupBox";
            this.accountActivityGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.accountActivityGroupBox.Size = new System.Drawing.Size(799, 228);
            this.accountActivityGroupBox.TabIndex = 7;
            this.accountActivityGroupBox.TabStop = false;
            this.accountActivityGroupBox.Text = "Account Activities";
            this.accountActivityGroupBox.Visible = false;
            // 
            // instructTotalLabel
            // 
            this.instructTotalLabel.AutoSize = true;
            this.instructTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructTotalLabel.Location = new System.Drawing.Point(540, 182);
            this.instructTotalLabel.Name = "instructTotalLabel";
            this.instructTotalLabel.Size = new System.Drawing.Size(44, 16);
            this.instructTotalLabel.TabIndex = 11;
            this.instructTotalLabel.Text = "Total";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(611, 176);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(168, 22);
            this.totalTextBox.TabIndex = 10;
            this.totalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // iraTextBox
            // 
            this.iraTextBox.Location = new System.Drawing.Point(611, 130);
            this.iraTextBox.Name = "iraTextBox";
            this.iraTextBox.Size = new System.Drawing.Size(168, 22);
            this.iraTextBox.TabIndex = 9;
            this.iraTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // savingAccountTextBox
            // 
            this.savingAccountTextBox.Location = new System.Drawing.Point(611, 83);
            this.savingAccountTextBox.Name = "savingAccountTextBox";
            this.savingAccountTextBox.Size = new System.Drawing.Size(168, 22);
            this.savingAccountTextBox.TabIndex = 8;
            this.savingAccountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checkingAccountTextBox
            // 
            this.checkingAccountTextBox.Location = new System.Drawing.Point(611, 35);
            this.checkingAccountTextBox.Name = "checkingAccountTextBox";
            this.checkingAccountTextBox.Size = new System.Drawing.Size(168, 22);
            this.checkingAccountTextBox.TabIndex = 7;
            this.checkingAccountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // addValueTextBox
            // 
            this.addValueTextBox.Location = new System.Drawing.Point(181, 60);
            this.addValueTextBox.Name = "addValueTextBox";
            this.addValueTextBox.Size = new System.Drawing.Size(100, 22);
            this.addValueTextBox.TabIndex = 6;
            this.addValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(171, 175);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "E&xit";
            this.toolTip1.SetToolTip(this.exitButton, "Closes the application.");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.Location = new System.Drawing.Point(37, 175);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "C&lear";
            this.toolTip1.SetToolTip(this.clearButton, "Clears all fields");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // iraButton
            // 
            this.iraButton.Location = new System.Drawing.Point(330, 129);
            this.iraButton.Name = "iraButton";
            this.iraButton.Size = new System.Drawing.Size(254, 23);
            this.iraButton.TabIndex = 3;
            this.iraButton.Text = "Add to IRA Account";
            this.iraButton.UseVisualStyleBackColor = true;
            this.iraButton.Click += new System.EventHandler(this.iraButton_Click);
            // 
            // savingAccountButton
            // 
            this.savingAccountButton.Location = new System.Drawing.Point(330, 82);
            this.savingAccountButton.Name = "savingAccountButton";
            this.savingAccountButton.Size = new System.Drawing.Size(254, 23);
            this.savingAccountButton.TabIndex = 2;
            this.savingAccountButton.Text = "Add too Saving Account";
            this.savingAccountButton.UseVisualStyleBackColor = true;
            this.savingAccountButton.Click += new System.EventHandler(this.savingAccountButton_Click);
            // 
            // checkingAccountButton
            // 
            this.checkingAccountButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.checkingAccountButton.Location = new System.Drawing.Point(330, 34);
            this.checkingAccountButton.Name = "checkingAccountButton";
            this.checkingAccountButton.Size = new System.Drawing.Size(254, 23);
            this.checkingAccountButton.TabIndex = 1;
            this.checkingAccountButton.Text = "Add to Checking Account";
            this.checkingAccountButton.UseVisualStyleBackColor = true;
            this.checkingAccountButton.Click += new System.EventHandler(this.checkingAccountButton_Click);
            // 
            // instructDepositWithdrawLabel
            // 
            this.instructDepositWithdrawLabel.AutoSize = true;
            this.instructDepositWithdrawLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructDepositWithdrawLabel.Location = new System.Drawing.Point(7, 66);
            this.instructDepositWithdrawLabel.Name = "instructDepositWithdrawLabel";
            this.instructDepositWithdrawLabel.Size = new System.Drawing.Size(130, 16);
            this.instructDepositWithdrawLabel.TabIndex = 0;
            this.instructDepositWithdrawLabel.Text = "Deposit/Withdraw";
            // 
            // Form1
            // 
            this.AcceptButton = this.startButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(858, 347);
            this.Controls.Add(this.accountActivityGroupBox);
            this.Controls.Add(this.accountActivitiesLabel);
            this.Controls.Add(this.outputNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.instructLastNameLabel);
            this.Controls.Add(this.instructFirstNameLabel);
            this.Controls.Add(this.startButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test-1 Brandon Rowe Bank";
            this.accountActivityGroupBox.ResumeLayout(false);
            this.accountActivityGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label instructFirstNameLabel;
        private System.Windows.Forms.Label instructLastNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label outputNameLabel;
        private System.Windows.Forms.Label accountActivitiesLabel;
        private System.Windows.Forms.GroupBox accountActivityGroupBox;
        private System.Windows.Forms.Label instructTotalLabel;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.TextBox iraTextBox;
        private System.Windows.Forms.TextBox savingAccountTextBox;
        private System.Windows.Forms.TextBox checkingAccountTextBox;
        private System.Windows.Forms.TextBox addValueTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button iraButton;
        private System.Windows.Forms.Button savingAccountButton;
        private System.Windows.Forms.Button checkingAccountButton;
        private System.Windows.Forms.Label instructDepositWithdrawLabel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

