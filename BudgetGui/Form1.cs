namespace BudgetGui
{
    public partial class Form1 : Form
    {
        int salary;
        int month;
        double percente;
        double APM;
        public Form1()
        {
            InitializeComponent();
        }
        private void nxtPgBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 n1 = new Form3();
            n1.ShowDialog();
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void salaryBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void percentBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void APMBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            salaryBox.Clear();
            monthBox.Clear();
            percentBox.Clear();
            APMBox.Clear();
            prcntBox.Clear();
            mthBox.Clear();
            TASBox.Clear();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {

            try
            {
                int salary = int.Parse(salaryBox.Text);
                double percent = double.Parse(percentBox.Text);
                int months = int.Parse(monthBox.Text);

                if (salary > 0 && percent >= 0 && months >= 0)
                {
                    double savingPerMonth = (percent / 100) * salary;
                    double totalSaving = savingPerMonth * months;
                    APMBox.Text = savingPerMonth.ToString();
                    prcntBox.Text = percent.ToString();
                    mthBox.Text = months.ToString();
                    TASBox.Text = totalSaving.ToString();
                }
                else
                {
                    MessageBox.Show("Invalid input. Please enter positive values for salary, percent, and months.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input format. Please enter numeric values for salary, percent, and months.");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Input value is too large or too small. Please enter valid values.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void mthBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mthLbL_Click(object sender, EventArgs e)
        {

        }

        private void stPg_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 n1 = new Form2();
            n1.ShowDialog();
            this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
