namespace Lecture_Chapter_9
{
    partial class nutritionForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFood = new System.Windows.Forms.Label();
            this.lblCalorie = new System.Windows.Forms.Label();
            this.lblFatGrams = new System.Windows.Forms.Label();
            this.lblCarbGrams = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Calories:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fat Grams:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Carb Grams:";
            // 
            // lblFood
            // 
            this.lblFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFood.Location = new System.Drawing.Point(206, 24);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(100, 23);
            this.lblFood.TabIndex = 4;
            // 
            // lblCalorie
            // 
            this.lblCalorie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCalorie.Location = new System.Drawing.Point(206, 72);
            this.lblCalorie.Name = "lblCalorie";
            this.lblCalorie.Size = new System.Drawing.Size(100, 23);
            this.lblCalorie.TabIndex = 5;
            // 
            // lblFatGrams
            // 
            this.lblFatGrams.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFatGrams.Location = new System.Drawing.Point(206, 112);
            this.lblFatGrams.Name = "lblFatGrams";
            this.lblFatGrams.Size = new System.Drawing.Size(100, 23);
            this.lblFatGrams.TabIndex = 6;
            // 
            // lblCarbGrams
            // 
            this.lblCarbGrams.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCarbGrams.Location = new System.Drawing.Point(206, 165);
            this.lblCarbGrams.Name = "lblCarbGrams";
            this.lblCarbGrams.Size = new System.Drawing.Size(100, 23);
            this.lblCarbGrams.TabIndex = 7;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(117, 230);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // nutritionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(358, 318);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.lblCarbGrams);
            this.Controls.Add(this.lblFatGrams);
            this.Controls.Add(this.lblCalorie);
            this.Controls.Add(this.lblFood);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "nutritionForm";
            this.Text = "Nutrition Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button closeButton;
        public System.Windows.Forms.Label lblFood;
        public System.Windows.Forms.Label lblCalorie;
        public System.Windows.Forms.Label lblFatGrams;
        public System.Windows.Forms.Label lblCarbGrams;
    }
}