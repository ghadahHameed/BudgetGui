using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetGui
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void yerLbL_Click(object sender, EventArgs e)
        {

        }

        private void monthLbL_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double prcPrdcValue = double.Parse(prcPrdcBox.Text);
                double amnSvValue = double.Parse(amnSvBox.Text);

                if (prcPrdcValue > 0 && amnSvValue > 0)
                {
                    double requiredMnth = prcPrdcValue / amnSvValue;
                    reqMnBox.Text = requiredMnth.ToString();

                    int months = (int)requiredMnth;
                    int years = months / 12;
                    int remainingMonths = months % 12;

                    yearBox.Text = years.ToString();
                    remMnthBox.Text = remainingMonths.ToString();
                }
                else
                {
                    MessageBox.Show("Invalid input. Please enter positive values for Price and Amount Saved.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input format. Please enter numeric values for Price and Amount Saved.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            prcPrdcBox.Clear();
            amnSvBox.Clear();
            reqMnBox.Clear();
            yearBox.Clear();
            remMnthBox.Clear();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 n3 = new Form1();
            n3.ShowDialog();
            this.Close();
        }

        private void stPg_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 n1 = new Form2();
            n1.ShowDialog();
            this.Close();
        }

        private void pnl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void prcPrdcBox_TextChanged(object sender, EventArgs e)
        {
            prcPrdcBox.Focus();
        }
    }
}
