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
        int PennyCount; // These variables represent the count for how many times each coin has been selected
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
        int PenceTotal; // This variable collects all the interger penny values

        double PennyCountTotal = 0.01; // These variables represent the full total in pounds and pence
        double TwoPennyCountTotal = 0.02;
        double FivePennyCountTotal = 0.05;
        double TenPennyCountTotal = 0.10;
        double TwentyPennyCountTotal = 0.20;
        double FiftyPennyCountTotal = 0.50;
        double OnePoundCountTotal = 1.00;
        double TwoPoundCountTotal = 2.00;
        double FullTotal; // This variable collects all the double penny values

        int CostPerCredit; // This variable calculates the Cost against each credit

        int Credits; // Credits variable
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CostPerCredit < 1) // If statement to allow me to only execute when requirements are met
            {
                MessageBox.Show("You need to set the cost of credit!");
            }
            else
            { 
                PennyCount++; // Counts up 1 per click
            label1.Text = Convert.ToString("X " + PennyCount); // Converts the count into string so it can be displayed

            PenceTotal += Penny; // Operator to have PenceTotal rise with every value Penny count
            label10.Text = Convert.ToString(PenceTotal); // Adds to the full total for pennies

            FullTotal += PennyCountTotal; // Operator to have FullTotal rise with every value penny count
            label11.Text = Convert.ToString(FullTotal); // Adds to the full value of pounds and pence

            Credits = PenceTotal / Convert.ToInt32(CostPerCredit); // Operation to give amount of credits
            label17.Text = Convert.ToString(Credits); // Converts to string
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CostPerCredit < 1)
            {
                MessageBox.Show("You need to set the cost of credit!");
            }
            else
            {
                TwoPennyCount++;
                label2.Text = Convert.ToString("X " + TwoPennyCount);

                PenceTotal += TwoPenny;
                label10.Text = Convert.ToString(PenceTotal);

                FullTotal += TwoPennyCountTotal;
                label11.Text = Convert.ToString(FullTotal);

                Credits = PenceTotal / Convert.ToInt32(CostPerCredit);
                label17.Text = Convert.ToString(Credits);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CostPerCredit < 1)
            {
                MessageBox.Show("You need to set the cost of credit!");
            }
            else
            {
                FivePennyCount++;
                label3.Text = Convert.ToString("X " + FivePennyCount);

                PenceTotal += FivePenny;
                label10.Text = Convert.ToString(PenceTotal);

                FullTotal += FivePennyCountTotal;
                label11.Text = Convert.ToString(FullTotal);

                Credits = PenceTotal / Convert.ToInt32(CostPerCredit);
                label17.Text = Convert.ToString(Credits);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (CostPerCredit < 1)
            {
                MessageBox.Show("You need to set the cost of credit!");
            }
            else
            {
                TenPennyCount++;
                label4.Text = Convert.ToString("X " + TenPennyCount);

                PenceTotal += TenPenny;
                label10.Text = Convert.ToString(PenceTotal);

                FullTotal += TenPennyCountTotal;
                label11.Text = Convert.ToString(FullTotal);

                Credits = PenceTotal / Convert.ToInt32(CostPerCredit);
                label17.Text = Convert.ToString(Credits);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (CostPerCredit < 1)
            {
                MessageBox.Show("You need to set the cost of credit!");
            }
            else
            {
                TwentyPennyCount++;
                label5.Text = Convert.ToString("X " + TwentyPennyCount);

                PenceTotal += TwentyPenny;
                label10.Text = Convert.ToString(PenceTotal);

                FullTotal += TwentyPennyCountTotal;
                label11.Text = Convert.ToString(FullTotal);

                Credits = PenceTotal / Convert.ToInt32(CostPerCredit);
                label17.Text = Convert.ToString(Credits);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (CostPerCredit < 1)
            {
                MessageBox.Show("You need to set the cost of credit!");
            }
            else
            {
                FiftyPennyCount++;
                label6.Text = Convert.ToString("X " + FiftyPennyCount);

                PenceTotal += FiftyPenny;
                label10.Text = Convert.ToString(PenceTotal);

                FullTotal += FiftyPennyCountTotal;
                label11.Text = Convert.ToString(FullTotal);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (CostPerCredit < 1)
            {
                MessageBox.Show("You need to set the cost of credit!");
            }
            else
            {
                OnePoundCount++;
                label7.Text = Convert.ToString("X " + OnePoundCount);

                PenceTotal += Pound;
                label10.Text = Convert.ToString(PenceTotal);

                FullTotal += OnePoundCountTotal;
                label11.Text = Convert.ToString(FullTotal);

                Credits = PenceTotal / Convert.ToInt32(CostPerCredit);
                label17.Text = Convert.ToString(Credits);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (CostPerCredit < 1)
            {
                MessageBox.Show("You need to set the cost of credit!");
            }
            else
            {
                TwoPoundCount++;
                label8.Text = Convert.ToString("X " + TwoPoundCount);

                PenceTotal += TwoPound;
                label10.Text = Convert.ToString(PenceTotal);

                FullTotal += TwoPoundCountTotal;
                label11.Text = Convert.ToString(FullTotal);

                Credits = PenceTotal / Convert.ToInt32(CostPerCredit);
                label17.Text = Convert.ToString(Credits);
            }
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

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString("X " + 0);
            label2.Text = Convert.ToString("X " + 0);
            label3.Text = Convert.ToString("X " + 0);
            label4.Text = Convert.ToString("X " + 0);
            label5.Text = Convert.ToString("X " + 0);
            label6.Text = Convert.ToString("X " + 0);
            label7.Text = Convert.ToString("X " + 0);
            label8.Text = Convert.ToString("X " + 0);
            label10.Text = Convert.ToString(0);
            label11.Text = Convert.ToString(0);
            label17.Text = Convert.ToString(0);
            textBox1.ResetText();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out CostPerCredit);

                if (CostPerCredit < 1)
                {
                    MessageBox.Show("Please enter a valid amount");
                    textBox1.ResetText();
                }
                
        }
    }
}
