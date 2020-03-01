using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            string alphaStr = txtAlphNum.Text;
            const int SIZE = 12;
            Boolean valid = true;
            string numStr = "";

            if (alphaStr.Length != SIZE)
                valid = false;

            for (int i = 0; i < alphaStr.Length; i++)
            {
                if (alphaStr.Length != SIZE || alphaStr[3] != '-' || alphaStr[7] != '-')
                {
                    valid = false;
                    break;
                }
                else
                    switch (char.ToUpper(alphaStr[i]))
                    {
                        case 'A':
                        case 'B':
                        case 'C': numStr += '2'; break;
                        case 'D':
                        case 'E':
                        case 'F': numStr += '3'; break;
                        case 'G':
                        case 'H':
                        case 'I': numStr += '4'; break;
                        case 'J':
                        case 'K':
                        case 'L': numStr += '5'; break;
                        case 'M':
                        case 'N':
                        case 'O': numStr += '6'; break;
                        case 'P':
                        case 'Q':
                        case 'R':
                        case 'S': numStr += '7'; break;
                        case 'T':
                        case 'U':
                        case 'V': numStr += '8'; break;
                        case 'W':
                        case 'X':
                        case 'Y':
                        case 'Z': numStr += '9'; break;
                        default: numStr += char.ToUpper(alphaStr[i]); break;
                    }

                if (valid == false)
                {
                    MessageBox.Show("Not enough characters or Length not 12 or Invalid format!");
                    txtAlphNum.Focus();
                }
                else
                    lblTranslate.Text = numStr;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            txtAlphNum.Text = " ";
            lblTranslate.Text = " ";
            txtAlphNum.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
