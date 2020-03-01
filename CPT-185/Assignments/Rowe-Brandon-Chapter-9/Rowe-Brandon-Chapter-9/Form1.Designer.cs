namespace Lecture_Chapter_9
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
            this.foodGroupBox = new System.Windows.Forms.GroupBox();
            this.displayButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.radBanana = new System.Windows.Forms.RadioButton();
            this.radioPopcorn = new System.Windows.Forms.RadioButton();
            this.radioBlueberryMuffin = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foodGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // foodGroupBox
            // 
            this.foodGroupBox.Controls.Add(this.radioBlueberryMuffin);
            this.foodGroupBox.Controls.Add(this.radBanana);
            this.foodGroupBox.Controls.Add(this.radioPopcorn);
            this.foodGroupBox.Location = new System.Drawing.Point(29, 38);
            this.foodGroupBox.Name = "foodGroupBox";
            this.foodGroupBox.Size = new System.Drawing.Size(200, 100);
            this.foodGroupBox.TabIndex = 0;
            this.foodGroupBox.TabStop = false;
            this.foodGroupBox.Text = "Select aFood";
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(12, 155);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(127, 23);
            this.displayButton.TabIndex = 0;
            this.displayButton.Text = "&Display Food Facts";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(169, 155);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // radBanana
            // 
            this.radBanana.AutoSize = true;
            this.radBanana.Location = new System.Drawing.Point(25, 18);
            this.radBanana.Name = "radBanana";
            this.radBanana.Size = new System.Drawing.Size(71, 17);
            this.radBanana.TabIndex = 2;
            this.radBanana.TabStop = true;
            this.radBanana.Text = "1 Banana";
            this.radBanana.UseVisualStyleBackColor = true;
            // 
            // radioPopcorn
            // 
            this.radioPopcorn.AutoSize = true;
            this.radioPopcorn.Location = new System.Drawing.Point(25, 41);
            this.radioPopcorn.Name = "radioPopcorn";
            this.radioPopcorn.Size = new System.Drawing.Size(159, 17);
            this.radioPopcorn.TabIndex = 3;
            this.radioPopcorn.TabStop = true;
            this.radioPopcorn.Text = "1 cup of air-popped popcorn";
            this.radioPopcorn.UseVisualStyleBackColor = true;
            // 
            // radioBlueberryMuffin
            // 
            this.radioBlueberryMuffin.AutoSize = true;
            this.radioBlueberryMuffin.Location = new System.Drawing.Point(25, 64);
            this.radioBlueberryMuffin.Name = "radioBlueberryMuffin";
            this.radioBlueberryMuffin.Size = new System.Drawing.Size(134, 17);
            this.radioBlueberryMuffin.TabIndex = 4;
            this.radioBlueberryMuffin.TabStop = true;
            this.radioBlueberryMuffin.Text = "1 large blueberry muffin";
            this.radioBlueberryMuffin.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(278, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(278, 199);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.foodGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Lecture-Chapter-9";
            this.foodGroupBox.ResumeLayout(false);
            this.foodGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox foodGroupBox;
        private System.Windows.Forms.RadioButton radioBlueberryMuffin;
        private System.Windows.Forms.RadioButton radBanana;
        private System.Windows.Forms.RadioButton radioPopcorn;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

