//Hardik Shahu
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {

        string first = "";
        string second = "";
        string userinput = "";
        char function;
        double result = 0.0;
        string userInput  = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void ZeroBut_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userinput += "0";
            CalculatorDisplay.Text += userinput; 
        }

        private void OneBut_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userinput += "1";
            CalculatorDisplay.Text += userinput;
        }

        private void TwoBut_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userinput += "2";
            CalculatorDisplay.Text += userinput;
        }

        private void ThreeBut_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userinput += "3";
            CalculatorDisplay.Text += userinput;
        }

        private void FourBut_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userinput += "4";
            CalculatorDisplay.Text += userinput;
        }

        private void FiveBut_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";

            userinput += "5";
            CalculatorDisplay.Text += userinput;
        }

        private void SixBut_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userinput += "6";
            CalculatorDisplay.Text += userinput;
        }

        private void SevenBut_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userinput += "7";
            CalculatorDisplay.Text += userinput;
        }

        private void EightBut_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userinput += "8";
            CalculatorDisplay.Text += userinput;
        }

        private void NineBut_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userinput += "9";
            CalculatorDisplay.Text += userinput;
        }

        private void DecimalBut_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userinput += ".";
            CalculatorDisplay.Text += userinput;
        }

        private void ClearBut_Click(object sender, EventArgs e)
        {
            
            first = "";
            second = "";
            userinput = "";
            result = 0.0;
            CalculatorDisplay.Text = "0";
        }

        private void divideBut_Click(object sender, EventArgs e)
        {
            function = '/';
            first = userinput;
            userinput = "";
        }

        private void multiplyBut_Click(object sender, EventArgs e)
        {
            function = '*';
            first = userinput;
            userinput = "";
        }

        private void PlusBut_Click(object sender, EventArgs e)
        {
            function = '+';
            first = userinput;
            userinput = "";
        }

        private void MinusBut_Click(object sender, EventArgs e)
        {
            function = '-';
            first = userinput;
            userinput = "";
        }

        private void EqualBut_Click(object sender, EventArgs e)
        {
            second = userinput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);

            switch (function)
            {
                case '+':
                    result = firstNum + secondNum;
                    CalculatorDisplay.Text = result.ToString();
                    break;

                case '-':
                    result = firstNum - secondNum;
                    CalculatorDisplay.Text = result.ToString();
                    break;

                case '*':
                    result = firstNum * secondNum;
                    CalculatorDisplay.Text = result.ToString();
                    break;

                case '/':
                    {
                        if(secondNum == '0') //If they try to divide by 0 it will throw an error
                           CalculatorDisplay.Text = "Error 0";
                        else
                            result = firstNum / secondNum;
                            CalculatorDisplay.Text = result.ToString();
                        break;
                    }

                default: break;


            }
            
        }




    }
}
