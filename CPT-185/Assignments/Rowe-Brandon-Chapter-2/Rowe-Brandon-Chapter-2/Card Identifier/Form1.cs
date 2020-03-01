using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Identifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aceSpadesPictureBox_Click(object sender, EventArgs e)
        {
            answerLabel.Text = "Ace of Spades";
        }

        private void jackHeartsPictureBox_Click(object sender, EventArgs e)
        {
            answerLabel.Text = "Jack of Hearts";
        }

        private void sevenClubsPictureBox_Click(object sender, EventArgs e)
        {
            answerLabel.Text = "Seven of Clubs";
        }

        private void kingDiamPictureBox_Click(object sender, EventArgs e)
        {
            answerLabel.Text = "King of Diamonds"; 
        }

        private void QueenClubsPictureBox_Click(object sender, EventArgs e)
        {
            answerLabel.Text = "Queen of Clubs";
        }
    }
}
