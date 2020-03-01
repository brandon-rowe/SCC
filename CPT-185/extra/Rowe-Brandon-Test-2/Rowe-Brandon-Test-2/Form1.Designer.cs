namespace Rowe_Brandon_Test_2
{
    partial class CPT_185_Test_2
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
            this.processButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.lblNumberRecords = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblLargest = new System.Windows.Forms.Label();
            this.lblSmallest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(41, 53);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(126, 23);
            this.processButton.TabIndex = 0;
            this.processButton.Text = "&Process the file ->";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(41, 133);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // outputLabel
            // 
            this.outputLabel.Location = new System.Drawing.Point(222, 50);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(100, 23);
            this.outputLabel.TabIndex = 2;
            // 
            // lblNumberRecords
            // 
            this.lblNumberRecords.Location = new System.Drawing.Point(222, 87);
            this.lblNumberRecords.Name = "lblNumberRecords";
            this.lblNumberRecords.Size = new System.Drawing.Size(100, 23);
            this.lblNumberRecords.TabIndex = 4;
            this.lblNumberRecords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAverage
            // 
            this.lblAverage.Location = new System.Drawing.Point(222, 130);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(100, 23);
            this.lblAverage.TabIndex = 5;
            this.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLargest
            // 
            this.lblLargest.Location = new System.Drawing.Point(222, 174);
            this.lblLargest.Name = "lblLargest";
            this.lblLargest.Size = new System.Drawing.Size(100, 23);
            this.lblLargest.TabIndex = 6;
            this.lblLargest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSmallest
            // 
            this.lblSmallest.Location = new System.Drawing.Point(222, 216);
            this.lblSmallest.Name = "lblSmallest";
            this.lblSmallest.Size = new System.Drawing.Size(100, 23);
            this.lblSmallest.TabIndex = 7;
            this.lblSmallest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CPT_185_Test_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(523, 281);
            this.Controls.Add(this.lblSmallest);
            this.Controls.Add(this.lblLargest);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblNumberRecords);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.processButton);
            this.Name = "CPT_185_Test_2";
            this.Text = "Brandon Rowe CPT-185-Test-2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label lblNumberRecords;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblLargest;
        private System.Windows.Forms.Label lblSmallest;
    }
}

