using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coin_Counter
{
    public partial class Form1 : Form
    {
        int PennyCount; // Each of these variables represent the count for how many times each coin has been selected
        int TwoPennyCount;
        int FivePennyCount;
        int TenPennyCount;
        int TwentyPennyCount;
        int FiftyPennyCount;
        int OnePoundCount;
        int TwoPoundCount;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PennyCount++; // Counts up 1 per click
            label1.Text = Convert.ToString("X " + PennyCount); // Converts the count into string so it can be displayed
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TwoPennyCount++;
            label2.Text = Convert.ToString("X " + TwoPennyCount);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FivePennyCount++;
            label3.Text = Convert.ToString("X " + FivePennyCount);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TenPennyCount++;
            label4.Text = Convert.ToString("X " + TenPennyCount);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TwentyPennyCount++;
            label5.Text = Convert.ToString("X " + TwentyPennyCount);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FiftyPennyCount++;
            label6.Text = Convert.ToString("X " + FiftyPennyCount);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OnePoundCount++;
            label7.Text = Convert.ToString("X " + OnePoundCount);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TwoPoundCount++;
            label8.Text = Convert.ToString("X " + TwoPoundCount);
        }
    }
}
