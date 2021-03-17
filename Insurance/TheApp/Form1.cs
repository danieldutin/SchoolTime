using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheApp
{
    public partial class InsuranceCalculator : Form
    {
        public InsuranceCalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string input1 = textBox2.Text;
            double lorrysAge = double.Parse(input1);
            string input2 = textBox1.Text;
            double lorryPrice = double.Parse((input2));
            string planSelection = comboBox1.Text;
            double newTarrif = 0;
            double insurancePrice = 0;
            double tarrifNumber = 0;
            double mainDiscount = 0;
            const double dzp = 0.02;
            
            if (planSelection == "No Service Plan")
            {
                mainDiscount = 0.45;
                if (lorrysAge <= 3)
                {

                    tarrifNumber = 0.021;

                    insurancePrice += ((Math.Abs(tarrifNumber - (tarrifNumber * mainDiscount))));
                    newTarrif = insurancePrice * (lorryPrice + (lorryPrice * dzp));
                }
                else if (lorrysAge <= 10 && lorrysAge > 3)
                {
                    if (lorryPrice <= 30000)
                    {
                        tarrifNumber = 0.026;
                    }
                    else
                    {
                        tarrifNumber = 0.023;
                    }
                    insurancePrice += ((Math.Abs(tarrifNumber - (tarrifNumber * mainDiscount))));
                    newTarrif = insurancePrice * (lorryPrice + (lorryPrice * dzp));
                }
                else if (lorrysAge > 10)
                {
                    if (lorryPrice <= 30000)
                    {
                        tarrifNumber = 0.029;
                    }
                    else
                    {
                        tarrifNumber = 0.026;
                    }
                    insurancePrice += ((Math.Abs(tarrifNumber - (tarrifNumber * mainDiscount))));
                    newTarrif = insurancePrice * (lorryPrice + (lorryPrice * dzp));
                }
            }
            else if (planSelection == "Official Dealership Service Plan")
            {
                mainDiscount = 0.20;

                if (lorrysAge <= 3)
                {

                    tarrifNumber = 0.021;

                    insurancePrice += ((Math.Abs(tarrifNumber - (tarrifNumber * mainDiscount))));
                    newTarrif = insurancePrice * (lorryPrice + (lorryPrice * dzp));
                }
                if (lorrysAge <= 10 && lorrysAge > 3)
                {
                    if (lorryPrice <= 30000)
                    {
                        tarrifNumber = 0.026;
                    }
                    else
                    {
                        tarrifNumber = 0.023;
                    }
                    insurancePrice += ((Math.Abs(tarrifNumber - (tarrifNumber * mainDiscount))));
                    newTarrif = insurancePrice * (lorryPrice + (lorryPrice * dzp));
                }

                if (lorrysAge > 10)
                {
                    if (lorryPrice <= 30000)
                    {
                        tarrifNumber = 0.029;
                    }
                    else
                    {
                        tarrifNumber = 0.026;
                    }
                    insurancePrice += ((Math.Abs(tarrifNumber - (tarrifNumber * mainDiscount))));
                    newTarrif = insurancePrice * (lorryPrice + (lorryPrice * dzp));
                }
            }
           
            
            label1.Text = ($"Your insurance price is: {newTarrif:f2}");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label1.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
