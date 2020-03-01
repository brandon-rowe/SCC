using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimelessDesignGPACalculator
{
    public partial class CPT202 : Form
    {
        public CPT202()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            List<double> homeworkGrades = new List<double>();
            List<double> testGrades = new List<double>();
            List<double> finalGrades = new List<double>();
            double homework = 0;
            double tests = 0;
            double final = 0;
            homeworkGrades.Add(int.Parse(txtAss1.Text));
            homeworkGrades.Add(int.Parse(txtAss2.Text));
            homeworkGrades.Add(int.Parse(txtAss3.Text));
            homeworkGrades.Add(int.Parse(txtAss4.Text));
            homeworkGrades.Add(int.Parse(txtAss5.Text));
            homeworkGrades.Add(int.Parse(txtAss6.Text));
            homeworkGrades.Add(int.Parse(txtAss7.Text));
            homeworkGrades.Add(int.Parse(txtAss8.Text));
            homeworkGrades.Add(int.Parse(txtAss9.Text));
            homeworkGrades.Add(int.Parse(txtAss10.Text));

            testGrades.Add(int.Parse(txtTest1.Text));
            testGrades.Add(int.Parse(txtTest2.Text));
            testGrades.Add(int.Parse(txtTest3.Text));

            finalGrades.Add(int.Parse(txtFinal.Text));

            foreach (int i in homeworkGrades)
            {
                homework += i * (0.4 / homeworkGrades.Count);
            }

            foreach (int i in testGrades)
            {
                tests += i * (0.4 / testGrades.Count);
            }

            foreach (int i in finalGrades)
            {
                final += i * (0.2 / finalGrades.Count);
            }

            txtFinalScore.Text = (homework + tests + final).ToString();

        }

        private void btnFill100_Click(object sender, EventArgs e)
        {
            List<TextBox> homeworkGrades = new List<TextBox>();
            List<TextBox> testGrades = new List<TextBox>();
            List<TextBox> finalGrades = new List<TextBox>();

            homeworkGrades.Add(txtAss1);
            homeworkGrades.Add(txtAss2);
            homeworkGrades.Add(txtAss3);
            homeworkGrades.Add(txtAss4);
            homeworkGrades.Add(txtAss5);
            homeworkGrades.Add(txtAss6);
            homeworkGrades.Add(txtAss7);
            homeworkGrades.Add(txtAss8);
            homeworkGrades.Add(txtAss9);
            homeworkGrades.Add(txtAss10);

            testGrades.Add(txtTest1);
            testGrades.Add(txtTest2);
            testGrades.Add(txtTest3);

            finalGrades.Add(txtFinal);

            foreach (TextBox i in homeworkGrades)
            {
                if (i.Text == "")
                {
                    i.Text = "100";
                }

            }

            foreach (TextBox i in testGrades)
            {
                if (i.Text == "")
                {
                    i.Text = "100";
                }

            }

            foreach (TextBox i in finalGrades)
            {
                if (i.Text == "")
                {
                    i.Text = "100";
                }

            }

        }

        private void btnFill0_Click(object sender, EventArgs e)
        {
            List<TextBox> homeworkGrades = new List<TextBox>();
            List<TextBox> testGrades = new List<TextBox>();
            List<TextBox> finalGrades = new List<TextBox>();

            homeworkGrades.Add(txtAss1);
            homeworkGrades.Add(txtAss2);
            homeworkGrades.Add(txtAss3);
            homeworkGrades.Add(txtAss4);
            homeworkGrades.Add(txtAss5);
            homeworkGrades.Add(txtAss6);
            homeworkGrades.Add(txtAss7);
            homeworkGrades.Add(txtAss8);
            homeworkGrades.Add(txtAss9);
            homeworkGrades.Add(txtAss10);

            testGrades.Add(txtTest1);
            testGrades.Add(txtTest2);
            testGrades.Add(txtTest3);

            finalGrades.Add(txtFinal);

            foreach (TextBox i in homeworkGrades)
            {
                if (i.Text == "")
                {
                    i.Text = "0";
                }

            }

            foreach (TextBox i in testGrades)
            {
                if (i.Text == "")
                {
                    i.Text = "0";
                }

            }

            foreach (TextBox i in finalGrades)
            {
                if (i.Text == "")
                {
                    i.Text = "0";
                }

            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAss1.Clear();
            txtAss2.Clear();
            txtAss3.Clear();
            txtAss4.Clear();
            txtAss5.Clear();
            txtAss6.Clear();
            txtAss7.Clear();
            txtAss8.Clear();
            txtAss9.Clear();
            txtAss10.Clear();
            txtTest1.Clear();
            txtTest2.Clear();
            txtTest3.Clear();
            txtFinal.Clear();

            txtFinalScore.Clear();
            txtFinalGrade.Clear();

            lblPassResult.Text = "";
            txtAss1.Focus();
        }
    }
}
