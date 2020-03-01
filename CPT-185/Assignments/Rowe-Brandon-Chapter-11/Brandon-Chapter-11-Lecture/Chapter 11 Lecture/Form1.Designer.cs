namespace Chapter_11_Lecture
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
            this.btnExit = new System.Windows.Forms.Button();
            this.txtClear = new System.Windows.Forms.Button();
            this.btnHours = new System.Windows.Forms.Button();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblTrack = new System.Windows.Forms.Label();
            this.radSE = new System.Windows.Forms.RadioButton();
            this.radInfo = new System.Windows.Forms.RadioButton();
            this.txtIDnumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(246, 290);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 37);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtClear
            // 
            this.txtClear.Location = new System.Drawing.Point(173, 290);
            this.txtClear.Name = "txtClear";
            this.txtClear.Size = new System.Drawing.Size(51, 37);
            this.txtClear.TabIndex = 26;
            this.txtClear.Text = "C&lear";
            this.txtClear.UseVisualStyleBackColor = true;
            this.txtClear.Click += new System.EventHandler(this.txtClear_Click);
            // 
            // btnHours
            // 
            this.btnHours.Location = new System.Drawing.Point(30, 290);
            this.btnHours.Name = "btnHours";
            this.btnHours.Size = new System.Drawing.Size(75, 37);
            this.btnHours.TabIndex = 25;
            this.btnHours.Text = "Required &Hours";
            this.btnHours.UseVisualStyleBackColor = true;
            this.btnHours.Click += new System.EventHandler(this.btnHours_Click);
            // 
            // lblHours
            // 
            this.lblHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHours.Location = new System.Drawing.Point(173, 217);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(100, 23);
            this.lblHours.TabIndex = 24;
            // 
            // lblTrack
            // 
            this.lblTrack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTrack.Location = new System.Drawing.Point(173, 193);
            this.lblTrack.Name = "lblTrack";
            this.lblTrack.Size = new System.Drawing.Size(100, 23);
            this.lblTrack.TabIndex = 23;
            // 
            // radSE
            // 
            this.radSE.AutoSize = true;
            this.radSE.Location = new System.Drawing.Point(176, 142);
            this.radSE.Name = "radSE";
            this.radSE.Size = new System.Drawing.Size(126, 17);
            this.radSE.TabIndex = 22;
            this.radSE.TabStop = true;
            this.radSE.Text = "Software Engineering";
            this.radSE.UseVisualStyleBackColor = true;
            // 
            // radInfo
            // 
            this.radInfo.AutoSize = true;
            this.radInfo.Location = new System.Drawing.Point(176, 119);
            this.radInfo.Name = "radInfo";
            this.radInfo.Size = new System.Drawing.Size(119, 17);
            this.radInfo.TabIndex = 21;
            this.radInfo.TabStop = true;
            this.radInfo.Text = "Information Systems";
            this.radInfo.UseVisualStyleBackColor = true;
            // 
            // txtIDnumber
            // 
            this.txtIDnumber.Location = new System.Drawing.Point(176, 60);
            this.txtIDnumber.Name = "txtIDnumber";
            this.txtIDnumber.Size = new System.Drawing.Size(100, 20);
            this.txtIDnumber.TabIndex = 20;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(176, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 19;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(21, 217);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(84, 13);
            this.Label5.TabIndex = 18;
            this.Label5.Text = "Required Hours:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(67, 193);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(38, 13);
            this.Label4.TabIndex = 17;
            this.Label4.Text = "Track:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(17, 127);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(88, 13);
            this.Label3.TabIndex = 16;
            this.Label3.Text = "Academic Track:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(44, 67);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(61, 13);
            this.Label2.TabIndex = 15;
            this.Label2.Text = "ID Number:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(67, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(38, 13);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 350);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtClear);
            this.Controls.Add(this.btnHours);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblTrack);
            this.Controls.Add(this.radSE);
            this.Controls.Add(this.radInfo);
            this.Controls.Add(this.txtIDnumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Chapter 10 Lecture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Button txtClear;
        internal System.Windows.Forms.Button btnHours;
        internal System.Windows.Forms.Label lblHours;
        internal System.Windows.Forms.Label lblTrack;
        internal System.Windows.Forms.RadioButton radSE;
        internal System.Windows.Forms.RadioButton radInfo;
        internal System.Windows.Forms.TextBox txtIDnumber;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;

    }
}

