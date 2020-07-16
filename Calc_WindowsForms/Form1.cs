using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_WindowsForms
{
    public partial class Calculator : Form
    {
        double FirstNumber;
        string Operation;

        public Calculator()
        {
            InitializeComponent();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "0" && textBoxDisplay.Text != null)
            {
                textBoxDisplay.Text = "7";
            }
            else
            {
                textBoxDisplay.Text = textBoxDisplay.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "0" && textBoxDisplay.Text != null)
            {
                textBoxDisplay.Text = "8";
            }
            else
            {
                textBoxDisplay.Text = textBoxDisplay.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "0" && textBoxDisplay.Text != null)
            {
                textBoxDisplay.Text = "9";
            }
            else
            {
                textBoxDisplay.Text = textBoxDisplay.Text + "9";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "0" && textBoxDisplay.Text != null)
            {
                textBoxDisplay.Text = "4";
            }
            else
            {
                textBoxDisplay.Text = textBoxDisplay.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "0" && textBoxDisplay.Text != null)
            {
                textBoxDisplay.Text = "5";
            }
            else
            {
                textBoxDisplay.Text = textBoxDisplay.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "0" && textBoxDisplay.Text != null)
            {
                textBoxDisplay.Text = "6";
            }
            else
            {
                textBoxDisplay.Text = textBoxDisplay.Text + "6";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "0" && textBoxDisplay.Text != null)
            {
                textBoxDisplay.Text = "1";
            }
            else
            {
                textBoxDisplay.Text = textBoxDisplay.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "0" && textBoxDisplay.Text != null)
            {
                textBoxDisplay.Text = "2";
            }
            else
            {
                textBoxDisplay.Text = textBoxDisplay.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "0" && textBoxDisplay.Text != null)
            {
                textBoxDisplay.Text = "3";
            }
            else
            {
                textBoxDisplay.Text = textBoxDisplay.Text + "3";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "0" && textBoxDisplay.Text != null)
            {
                textBoxDisplay.Text = "0";
            }
            else
            {
                textBoxDisplay.Text = textBoxDisplay.Text + "0";
            }
        }

        private void btndecimal_Click(object sender, EventArgs e)
        {
            
                textBoxDisplay.Text = textBoxDisplay.Text + ".";
            
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBoxDisplay.Text);
            textBoxDisplay.Text = "0";
            Operation = "+";
        }

        private void btnsubtract_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBoxDisplay.Text);
            textBoxDisplay.Text = "0";
            Operation = "-";
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBoxDisplay.Text);
            textBoxDisplay.Text = "0";
            Operation = "*";
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBoxDisplay.Text);
            textBoxDisplay.Text = "0";
            Operation = "/";
        }

        private void btnac_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = "0";
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            double Result;

            var SecondNumber = Convert.ToDouble(textBoxDisplay.Text);

            if (Operation == "+")
            {
               Result = CalcEngine.Calculator.Add(FirstNumber, SecondNumber);
               textBoxDisplay.Text = Result.ToString();
               FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = CalcEngine.Calculator.Subtract(FirstNumber, SecondNumber);
                textBoxDisplay.Text = Result.ToString();
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = CalcEngine.Calculator.Multiply(FirstNumber, SecondNumber);
                textBoxDisplay.Text = Result.ToString();
                FirstNumber = Result;
            }
            if (Operation == "/")
            {

                if (SecondNumber == 0)
                {
                    textBoxDisplay.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = CalcEngine.Calculator.Divide(FirstNumber, SecondNumber);
                    textBoxDisplay.Text = Result.ToString();
                    FirstNumber = Result;
                }
            }
        }
    }
}
