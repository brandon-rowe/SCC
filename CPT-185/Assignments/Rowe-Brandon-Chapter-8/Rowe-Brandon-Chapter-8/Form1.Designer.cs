namespace Lecture_8
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlphNum = new System.Windows.Forms.TextBox();
            this.lblTranslate = new System.Windows.Forms.Label();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a 10-character telephone number in Alphabet (xxx-xxx-xxxx):";
            // 
            // txtAlphNum
            // 
            this.txtAlphNum.Location = new System.Drawing.Point(168, 56);
            this.txtAlphNum.Name = "txtAlphNum";
            this.txtAlphNum.Size = new System.Drawing.Size(100, 20);
            this.txtAlphNum.TabIndex = 1;
            // 
            // lblTranslate
            // 
            this.lblTranslate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTranslate.Location = new System.Drawing.Point(168, 92);
            this.lblTranslate.Name = "lblTranslate";
            this.lblTranslate.Size = new System.Drawing.Size(100, 23);
            this.lblTranslate.TabIndex = 2;
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(87, 92);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(75, 23);
            this.btnTranslate.TabIndex = 3;
            this.btnTranslate.Text = "&Translate";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(87, 132);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "&Clear";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(332, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "E&xit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 208);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.lblTranslate);
            this.Controls.Add(this.txtAlphNum);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Lecture on chapter 8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAlphNum;
        private System.Windows.Forms.Label lblTranslate;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button3;
    }
}

