namespace Brandon_Rowe_Chapter_10
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtShift = new System.Windows.Forms.TextBox();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPay = new System.Windows.Forms.Label();
            this.lblShift = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCreateObject = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Shift: (Enter 1 or 2)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hourly Pay Rate:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(190, 54);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 7;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(190, 87);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 8;
            // 
            // txtShift
            // 
            this.txtShift.Location = new System.Drawing.Point(190, 126);
            this.txtShift.Name = "txtShift";
            this.txtShift.Size = new System.Drawing.Size(100, 20);
            this.txtShift.TabIndex = 9;
            // 
            // txtPay
            // 
            this.txtPay.Location = new System.Drawing.Point(190, 161);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(100, 20);
            this.txtPay.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtShift);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNumber);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(28, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 245);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Employee Data";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPay);
            this.groupBox2.Controls.Add(this.lblShift);
            this.groupBox2.Controls.Add(this.lblNumber);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(28, 302);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 245);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employee Data";
            // 
            // lblPay
            // 
            this.lblPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPay.Location = new System.Drawing.Point(190, 158);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(100, 23);
            this.lblPay.TabIndex = 7;
            // 
            // lblShift
            // 
            this.lblShift.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShift.Location = new System.Drawing.Point(190, 123);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(100, 23);
            this.lblShift.TabIndex = 6;
            // 
            // lblNumber
            // 
            this.lblNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumber.Location = new System.Drawing.Point(190, 84);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(100, 23);
            this.lblNumber.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblName.Location = new System.Drawing.Point(190, 51);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Employee Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Employee Number:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Shift: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Hourly Pay Rate:";
            // 
            // btnCreateObject
            // 
            this.btnCreateObject.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCreateObject.Location = new System.Drawing.Point(34, 576);
            this.btnCreateObject.Name = "btnCreateObject";
            this.btnCreateObject.Size = new System.Drawing.Size(75, 38);
            this.btnCreateObject.TabIndex = 11;
            this.btnCreateObject.Text = "&Create Object";
            this.btnCreateObject.UseVisualStyleBackColor = true;
            this.btnCreateObject.Click += new System.EventHandler(this.btnCreateObject_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(291, 576);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 38);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(162, 576);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 38);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Cle&ar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCreateObject;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(404, 642);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCreateObject);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brandon-Rowe-Chapter-10";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtNumber;
        public System.Windows.Forms.TextBox txtShift;
        public System.Windows.Forms.TextBox txtPay;
        public System.Windows.Forms.Label lblPay;
        public System.Windows.Forms.Label lblShift;
        public System.Windows.Forms.Label lblNumber;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Button btnCreateObject;
        public System.Windows.Forms.Button btnClear;
    }
}

