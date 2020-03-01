namespace Card_Identifier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.instructLabel = new System.Windows.Forms.Label();
            this.answerLabel = new System.Windows.Forms.Label();
            this.aceSpadesPictureBox = new System.Windows.Forms.PictureBox();
            this.jackHeartsPictureBox = new System.Windows.Forms.PictureBox();
            this.sevenClubsPictureBox = new System.Windows.Forms.PictureBox();
            this.kingDiamPictureBox = new System.Windows.Forms.PictureBox();
            this.QueenClubsPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.aceSpadesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jackHeartsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sevenClubsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kingDiamPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueenClubsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // instructLabel
            // 
            this.instructLabel.AutoSize = true;
            this.instructLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructLabel.Location = new System.Drawing.Point(192, 32);
            this.instructLabel.Name = "instructLabel";
            this.instructLabel.Size = new System.Drawing.Size(240, 20);
            this.instructLabel.TabIndex = 0;
            this.instructLabel.Text = "Click a Card to See Its Name";
            // 
            // answerLabel
            // 
            this.answerLabel.BackColor = System.Drawing.Color.White;
            this.answerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answerLabel.Location = new System.Drawing.Point(93, 240);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(431, 34);
            this.answerLabel.TabIndex = 1;
            this.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aceSpadesPictureBox
            // 
            this.aceSpadesPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("aceSpadesPictureBox.Image")));
            this.aceSpadesPictureBox.Location = new System.Drawing.Point(12, 80);
            this.aceSpadesPictureBox.Name = "aceSpadesPictureBox";
            this.aceSpadesPictureBox.Size = new System.Drawing.Size(100, 138);
            this.aceSpadesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aceSpadesPictureBox.TabIndex = 2;
            this.aceSpadesPictureBox.TabStop = false;
            this.aceSpadesPictureBox.Click += new System.EventHandler(this.aceSpadesPictureBox_Click);
            // 
            // jackHeartsPictureBox
            // 
            this.jackHeartsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("jackHeartsPictureBox.Image")));
            this.jackHeartsPictureBox.Location = new System.Drawing.Point(156, 80);
            this.jackHeartsPictureBox.Name = "jackHeartsPictureBox";
            this.jackHeartsPictureBox.Size = new System.Drawing.Size(100, 138);
            this.jackHeartsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.jackHeartsPictureBox.TabIndex = 3;
            this.jackHeartsPictureBox.TabStop = false;
            this.jackHeartsPictureBox.Click += new System.EventHandler(this.jackHeartsPictureBox_Click);
            // 
            // sevenClubsPictureBox
            // 
            this.sevenClubsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("sevenClubsPictureBox.Image")));
            this.sevenClubsPictureBox.Location = new System.Drawing.Point(285, 80);
            this.sevenClubsPictureBox.Name = "sevenClubsPictureBox";
            this.sevenClubsPictureBox.Size = new System.Drawing.Size(100, 138);
            this.sevenClubsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sevenClubsPictureBox.TabIndex = 4;
            this.sevenClubsPictureBox.TabStop = false;
            this.sevenClubsPictureBox.Click += new System.EventHandler(this.sevenClubsPictureBox_Click);
            // 
            // kingDiamPictureBox
            // 
            this.kingDiamPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("kingDiamPictureBox.Image")));
            this.kingDiamPictureBox.Location = new System.Drawing.Point(412, 80);
            this.kingDiamPictureBox.Name = "kingDiamPictureBox";
            this.kingDiamPictureBox.Size = new System.Drawing.Size(100, 138);
            this.kingDiamPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kingDiamPictureBox.TabIndex = 5;
            this.kingDiamPictureBox.TabStop = false;
            this.kingDiamPictureBox.Click += new System.EventHandler(this.kingDiamPictureBox_Click);
            // 
            // QueenClubsPictureBox
            // 
            this.QueenClubsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("QueenClubsPictureBox.Image")));
            this.QueenClubsPictureBox.Location = new System.Drawing.Point(538, 80);
            this.QueenClubsPictureBox.Name = "QueenClubsPictureBox";
            this.QueenClubsPictureBox.Size = new System.Drawing.Size(100, 138);
            this.QueenClubsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.QueenClubsPictureBox.TabIndex = 6;
            this.QueenClubsPictureBox.TabStop = false;
            this.QueenClubsPictureBox.Click += new System.EventHandler(this.QueenClubsPictureBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 320);
            this.Controls.Add(this.QueenClubsPictureBox);
            this.Controls.Add(this.kingDiamPictureBox);
            this.Controls.Add(this.sevenClubsPictureBox);
            this.Controls.Add(this.jackHeartsPictureBox);
            this.Controls.Add(this.aceSpadesPictureBox);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.instructLabel);
            this.Name = "Form1";
            this.Text = "Card Identifier";
            ((System.ComponentModel.ISupportInitialize)(this.aceSpadesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jackHeartsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sevenClubsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kingDiamPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueenClubsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructLabel;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.PictureBox aceSpadesPictureBox;
        private System.Windows.Forms.PictureBox jackHeartsPictureBox;
        private System.Windows.Forms.PictureBox sevenClubsPictureBox;
        private System.Windows.Forms.PictureBox kingDiamPictureBox;
        private System.Windows.Forms.PictureBox QueenClubsPictureBox;
    }
}

