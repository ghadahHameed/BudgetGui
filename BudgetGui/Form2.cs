﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void svPG_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 n1 = new Form1();
            n1.ShowDialog();
            this.Close();
        }

        private void nxPG_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 n1 = new Form3();
            n1.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "hi";
            textBox1.Show();
        }
    }
}
