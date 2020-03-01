namespace Rowe_Brandon_Test_1
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.autoListBox = new System.Windows.Forms.ListBox();
            this.TransmissionListBox = new System.Windows.Forms.ListBox();
            this.AutoLabel = new System.Windows.Forms.Label();
            this.TransmissionLabel = new System.Windows.Forms.Label();
            this.taxRateLabel = new System.Windows.Forms.Label();
            this.selectAuto = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.transLabel = new System.Windows.Forms.Label();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.transLabTextBox = new System.Windows.Forms.TextBox();
            this.subTotalTextBox = new System.Windows.Forms.TextBox();
            this.taxLabelTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.taxRateTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(49, 232);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(163, 232);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(284, 232);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // autoListBox
            // 
            this.autoListBox.FormattingEnabled = true;
            this.autoListBox.Items.AddRange(new object[] {
            "Lamborghini",
            "Ferrari",
            "Corvette"});
            this.autoListBox.Location = new System.Drawing.Point(55, 32);
            this.autoListBox.Name = "autoListBox";
            this.autoListBox.Size = new System.Drawing.Size(69, 43);
            this.autoListBox.TabIndex = 3;
            this.autoListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // TransmissionListBox
            // 
            this.TransmissionListBox.FormattingEnabled = true;
            this.TransmissionListBox.Items.AddRange(new object[] {
            "Manual",
            "Automatic"});
            this.TransmissionListBox.Location = new System.Drawing.Point(55, 104);
            this.TransmissionListBox.Name = "TransmissionListBox";
            this.TransmissionListBox.Size = new System.Drawing.Size(69, 30);
            this.TransmissionListBox.TabIndex = 4;
            this.TransmissionListBox.SelectedIndexChanged += new System.EventHandler(this.TransmissionListBox_SelectedIndexChanged);
            // 
            // AutoLabel
            // 
            this.AutoLabel.AutoSize = true;
            this.AutoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoLabel.Location = new System.Drawing.Point(52, 16);
            this.AutoLabel.Name = "AutoLabel";
            this.AutoLabel.Size = new System.Drawing.Size(33, 13);
            this.AutoLabel.TabIndex = 5;
            this.AutoLabel.Text = "Auto";
            // 
            // TransmissionLabel
            // 
            this.TransmissionLabel.AutoSize = true;
            this.TransmissionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransmissionLabel.Location = new System.Drawing.Point(50, 88);
            this.TransmissionLabel.Name = "TransmissionLabel";
            this.TransmissionLabel.Size = new System.Drawing.Size(80, 13);
            this.TransmissionLabel.TabIndex = 6;
            this.TransmissionLabel.Text = "Transmission";
            // 
            // taxRateLabel
            // 
            this.taxRateLabel.AutoSize = true;
            this.taxRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxRateLabel.Location = new System.Drawing.Point(52, 147);
            this.taxRateLabel.Name = "taxRateLabel";
            this.taxRateLabel.Size = new System.Drawing.Size(67, 13);
            this.taxRateLabel.TabIndex = 7;
            this.taxRateLabel.Text = "Tax Rate: ";
            // 
            // selectAuto
            // 
            this.selectAuto.AutoSize = true;
            this.selectAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectAuto.Location = new System.Drawing.Point(285, 32);
            this.selectAuto.Name = "selectAuto";
            this.selectAuto.Size = new System.Drawing.Size(87, 13);
            this.selectAuto.TabIndex = 8;
            this.selectAuto.Text = "Selected Auto";
            this.selectAuto.Click += new System.EventHandler(this.selectAuto_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(194, 62);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(44, 13);
            this.priceLabel.TabIndex = 9;
            this.priceLabel.Text = "Price: ";
            // 
            // transLabel
            // 
            this.transLabel.AutoSize = true;
            this.transLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transLabel.Location = new System.Drawing.Point(168, 88);
            this.transLabel.Name = "transLabel";
            this.transLabel.Size = new System.Drawing.Size(74, 13);
            this.transLabel.TabIndex = 10;
            this.transLabel.Text = "Trans Label";
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalLabel.Location = new System.Drawing.Point(180, 121);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(62, 13);
            this.subTotalLabel.TabIndex = 11;
            this.subTotalLabel.Text = "Subtotal: ";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(175, 151);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(63, 13);
            this.taxLabel.TabIndex = 12;
            this.taxLabel.Text = "Tax Label";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(194, 194);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(44, 13);
            this.totalLabel.TabIndex = 13;
            this.totalLabel.Text = "Total: ";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(259, 55);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 14;
            this.priceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // transLabTextBox
            // 
            this.transLabTextBox.Location = new System.Drawing.Point(259, 81);
            this.transLabTextBox.Name = "transLabTextBox";
            this.transLabTextBox.Size = new System.Drawing.Size(100, 20);
            this.transLabTextBox.TabIndex = 15;
            this.transLabTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // subTotalTextBox
            // 
            this.subTotalTextBox.Location = new System.Drawing.Point(259, 114);
            this.subTotalTextBox.Name = "subTotalTextBox";
            this.subTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.subTotalTextBox.TabIndex = 16;
            this.subTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // taxLabelTextBox
            // 
            this.taxLabelTextBox.Location = new System.Drawing.Point(259, 144);
            this.taxLabelTextBox.Name = "taxLabelTextBox";
            this.taxLabelTextBox.Size = new System.Drawing.Size(100, 20);
            this.taxLabelTextBox.TabIndex = 17;
            this.taxLabelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(259, 187);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalTextBox.TabIndex = 18;
            this.totalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // taxRateTextBox
            // 
            this.taxRateTextBox.Location = new System.Drawing.Point(125, 144);
            this.taxRateTextBox.Name = "taxRateTextBox";
            this.taxRateTextBox.Size = new System.Drawing.Size(36, 20);
            this.taxRateTextBox.TabIndex = 19;
            this.taxRateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(410, 319);
            this.Controls.Add(this.taxRateTextBox);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.taxLabelTextBox);
            this.Controls.Add(this.subTotalTextBox);
            this.Controls.Add(this.transLabTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.transLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.selectAuto);
            this.Controls.Add(this.taxRateLabel);
            this.Controls.Add(this.TransmissionLabel);
            this.Controls.Add(this.AutoLabel);
            this.Controls.Add(this.TransmissionListBox);
            this.Controls.Add(this.autoListBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Name = "Form1";
            this.Text = "Brandon Rowe Test-1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox autoListBox;
        private System.Windows.Forms.ListBox TransmissionListBox;
        private System.Windows.Forms.Label AutoLabel;
        private System.Windows.Forms.Label TransmissionLabel;
        private System.Windows.Forms.Label taxRateLabel;
        private System.Windows.Forms.Label selectAuto;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label transLabel;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox transLabTextBox;
        private System.Windows.Forms.TextBox subTotalTextBox;
        private System.Windows.Forms.TextBox taxLabelTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.TextBox taxRateTextBox;
    }
}

