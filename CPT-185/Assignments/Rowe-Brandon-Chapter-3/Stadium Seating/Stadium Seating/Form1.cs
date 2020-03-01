using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stadium_Seating
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void answerClabel_Click(object sender, EventArgs e)
        {

        }

        private void calcRevButton_Click(object sender, EventArgs e)
        {
            double classA;
            double classB;
            double classC;            

            classA = double.Parse(classAtextBox.Text);
            classB = double.Parse(classBtextBox.Text);
            classC = double.Parse(classCtextBox.Text);

            double classArev = classA * 15;
            double classBrev = classB * 12;
            double classCrev = classC * 9;
            double total = (classArev + classBrev + classCrev);

            answerAlabel.Text = classArev.ToString("c");
            answerBlabel.Text = classBrev.ToString("c");
            answerClabel.Text = classCrev.ToString("c");
            totalAnswerLabel.Text = total.ToString("c");
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            answerAlabel.Text = " ";
            answerBlabel.Text = " ";
            answerClabel.Text = " ";
            totalAnswerLabel.Text = " ";
            classAtextBox.Text = " ";
            classBtextBox.Text = " ";
            classCtextBox.Text = " ";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
