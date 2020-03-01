namespace TimelessDesignGPACalculator
{
    partial class frmIntro
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn202 = new System.Windows.Forms.Button();
            this.btn206 = new System.Windows.Forms.Button();
            this.lblClassDescription = new System.Windows.Forms.Label();
            this.btn168 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Your Class";
            // 
            // btn202
            // 
            this.btn202.Location = new System.Drawing.Point(34, 57);
            this.btn202.Name = "btn202";
            this.btn202.Size = new System.Drawing.Size(75, 23);
            this.btn202.TabIndex = 1;
            this.btn202.Text = "CPT-202";
            this.btn202.UseVisualStyleBackColor = true;
            this.btn202.Click += new System.EventHandler(this.btn202_Click);
            this.btn202.MouseEnter += new System.EventHandler(this.btn202_MouseEnter);
            this.btn202.MouseLeave += new System.EventHandler(this.btn202_MouseLeave);
            // 
            // btn206
            // 
            this.btn206.Location = new System.Drawing.Point(34, 86);
            this.btn206.Name = "btn206";
            this.btn206.Size = new System.Drawing.Size(75, 23);
            this.btn206.TabIndex = 2;
            this.btn206.Text = "CPT-206";
            this.btn206.UseVisualStyleBackColor = true;
            this.btn206.MouseEnter += new System.EventHandler(this.btn206_MouseEnter);
            this.btn206.MouseLeave += new System.EventHandler(this.btn206_MouseLeave);
            // 
            // lblClassDescription
            // 
            this.lblClassDescription.AutoSize = true;
            this.lblClassDescription.Location = new System.Drawing.Point(300, 57);
            this.lblClassDescription.Name = "lblClassDescription";
            this.lblClassDescription.Size = new System.Drawing.Size(35, 13);
            this.lblClassDescription.TabIndex = 3;
            this.lblClassDescription.Text = "label2";
            this.lblClassDescription.Visible = false;
            // 
            // btn168
            // 
            this.btn168.Location = new System.Drawing.Point(34, 116);
            this.btn168.Name = "btn168";
            this.btn168.Size = new System.Drawing.Size(75, 23);
            this.btn168.TabIndex = 4;
            this.btn168.Text = "CPT-168";
            this.btn168.UseVisualStyleBackColor = true;
            this.btn168.MouseEnter += new System.EventHandler(this.btn168_MouseEnter);
            this.btn168.MouseLeave += new System.EventHandler(this.btn168_MouseLeave);
            // 
            // frmIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 456);
            this.Controls.Add(this.btn168);
            this.Controls.Add(this.lblClassDescription);
            this.Controls.Add(this.btn206);
            this.Controls.Add(this.btn202);
            this.Controls.Add(this.label1);
            this.Name = "frmIntro";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn202;
        private System.Windows.Forms.Button btn206;
        private System.Windows.Forms.Label lblClassDescription;
        private System.Windows.Forms.Button btn168;
    }
}

