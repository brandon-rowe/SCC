namespace Rowe_Brandon_Chapter_5
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
            this.startingNumberTextBox = new System.Windows.Forms.TextBox();
            this.averageDailyIncreaseTextBox = new System.Windows.Forms.TextBox();
            this.numberDaysTextBox = new System.Windows.Forms.TextBox();
            this.appPopulationListBox = new System.Windows.Forms.ListBox();
            this.instructStartingNumberLabel = new System.Windows.Forms.Label();
            this.instructAverageDailyLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startingNumberTextBox
            // 
            this.startingNumberTextBox.Location = new System.Drawing.Point(305, 12);
            this.startingNumberTextBox.Name = "startingNumberTextBox";
            this.startingNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.startingNumberTextBox.TabIndex = 0;
            // 
            // averageDailyIncreaseTextBox
            // 
            this.averageDailyIncreaseTextBox.Location = new System.Drawing.Point(305, 58);
            this.averageDailyIncreaseTextBox.Name = "averageDailyIncreaseTextBox";
            this.averageDailyIncreaseTextBox.Size = new System.Drawing.Size(100, 20);
            this.averageDailyIncreaseTextBox.TabIndex = 1;
            // 
            // numberDaysTextBox
            // 
            this.numberDaysTextBox.Location = new System.Drawing.Point(305, 101);
            this.numberDaysTextBox.Name = "numberDaysTextBox";
            this.numberDaysTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberDaysTextBox.TabIndex = 2;
            // 
            // appPopulationListBox
            // 
            this.appPopulationListBox.FormattingEnabled = true;
            this.appPopulationListBox.Location = new System.Drawing.Point(32, 146);
            this.appPopulationListBox.Name = "appPopulationListBox";
            this.appPopulationListBox.Size = new System.Drawing.Size(373, 199);
            this.appPopulationListBox.TabIndex = 3;
            // 
            // instructStartingNumberLabel
            // 
            this.instructStartingNumberLabel.AutoSize = true;
            this.instructStartingNumberLabel.Location = new System.Drawing.Point(29, 19);
            this.instructStartingNumberLabel.Name = "instructStartingNumberLabel";
            this.instructStartingNumberLabel.Size = new System.Drawing.Size(224, 13);
            this.instructStartingNumberLabel.TabIndex = 4;
            this.instructStartingNumberLabel.Text = "Please enter the starting number of organisms:";
            // 
            // instructAverageDailyLabel
            // 
            this.instructAverageDailyLabel.AutoSize = true;
            this.instructAverageDailyLabel.Location = new System.Drawing.Point(29, 65);
            this.instructAverageDailyLabel.Name = "instructAverageDailyLabel";
            this.instructAverageDailyLabel.Size = new System.Drawing.Size(264, 13);
            this.instructAverageDailyLabel.TabIndex = 5;
            this.instructAverageDailyLabel.Text = "Please enter the average daily increase in percentage:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Please enter the number of days to calculate growth:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(32, 375);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 38);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate Population";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(178, 375);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 38);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(330, 375);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 38);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 431);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.instructAverageDailyLabel);
            this.Controls.Add(this.instructStartingNumberLabel);
            this.Controls.Add(this.appPopulationListBox);
            this.Controls.Add(this.numberDaysTextBox);
            this.Controls.Add(this.averageDailyIncreaseTextBox);
            this.Controls.Add(this.startingNumberTextBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rowe-Brandon-Chapter-5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox startingNumberTextBox;
        private System.Windows.Forms.TextBox averageDailyIncreaseTextBox;
        private System.Windows.Forms.TextBox numberDaysTextBox;
        private System.Windows.Forms.ListBox appPopulationListBox;
        private System.Windows.Forms.Label instructStartingNumberLabel;
        private System.Windows.Forms.Label instructAverageDailyLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

