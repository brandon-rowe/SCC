namespace Rowe_Brandon_Test_2
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
            this.processButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(51, 30);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(166, 33);
            this.processButton.TabIndex = 0;
            this.processButton.Text = "&Process the file ->";
            this.toolTip1.SetToolTip(this.processButton, "Process .txt file");
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(51, 150);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "E&xit";
            this.toolTip1.SetToolTip(this.exitButton, "Close the application");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Location = new System.Drawing.Point(250, 30);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(357, 143);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AcceptButton = this.processButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(649, 286);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.processButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brandon Rowe CPT-185 Test-2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

