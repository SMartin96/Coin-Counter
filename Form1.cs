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

        int Penny = 1; // These variables are to count the full total of pennies collected
        int TwoPenny = 2;
        int FivePenny = 5;
        int TenPenny = 10;
        int TwentyPenny = 20;
        int FiftyPenny = 50;
        int Pound = 100;
        int TwoPound = 200;
        int PenceTotal; // This variable collects all the penny total variables

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PennyCount++; // Counts up 1 per click
            label1.Text = Convert.ToString("X " + PennyCount); // Converts the count into string so it can be displayed

            PenceTotal += Penny; // Operator to have PenceTotal rise with every value Penny count
            label10.Text = Convert.ToString(PenceTotal); // Adds to the full total for pennies
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TwoPennyCount++;
            label2.Text = Convert.ToString("X " + TwoPennyCount);

            PenceTotal += TwoPenny;
            label10.Text = Convert.ToString(PenceTotal);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FivePennyCount++;
            label3.Text = Convert.ToString("X " + FivePennyCount);

            PenceTotal += FivePenny;
            label10.Text = Convert.ToString(PenceTotal);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TenPennyCount++;
            label4.Text = Convert.ToString("X " + TenPennyCount);

            PenceTotal += TenPenny;
            label10.Text = Convert.ToString(PenceTotal);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TwentyPennyCount++;
            label5.Text = Convert.ToString("X " + TwentyPennyCount);

            PenceTotal += TwentyPenny;
            label10.Text = Convert.ToString(PenceTotal);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FiftyPennyCount++;
            label6.Text = Convert.ToString("X " + FiftyPennyCount);

            PenceTotal += FiftyPenny;
            label10.Text = Convert.ToString(PenceTotal);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OnePoundCount++;
            label7.Text = Convert.ToString("X " + OnePoundCount);

            PenceTotal += Pound;
            label10.Text = Convert.ToString(PenceTotal);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TwoPoundCount++;
            label8.Text = Convert.ToString("X " + TwoPoundCount);

            PenceTotal += TwoPound;
            label10.Text = Convert.ToString(PenceTotal);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
