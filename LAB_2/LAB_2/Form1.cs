using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_2
{
    public partial class Form1 : Form
    {
        //variables for the operands
        private double firstValue;
        private double secondValue;

        //var for temporary values
        private double tempValue;

        //true if variable has decimals alse false
        private bool hasDecimal = false;
        private bool inputStatus = true;

        //variable to hold the operator
        private string calcFunc;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if(inputStatus)
            {
                textBox1.Text += btn9.Text;
            }
            else
            {
                textBox1.Text = btn9.Text;
                inputStatus = true;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (inputStatus)
            {
                textBox1.Text += btn8.Text;
            }
            else
            {
                textBox1.Text = btn8.Text;
                inputStatus = true;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (inputStatus)
            {
                textBox1.Text += btn7.Text;
            }
            else
            {
                textBox1.Text = btn7.Text;
                inputStatus = true;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (inputStatus)
            {
                textBox1.Text += btn6.Text;
            }
            else
            {
                textBox1.Text = btn6.Text;
                inputStatus = true;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (inputStatus)
            {
                textBox1.Text += btn5.Text;
            }
            else
            {
                textBox1.Text = btn5.Text;
                inputStatus = true;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (inputStatus)
            {
                textBox1.Text += btn4.Text;
            }
            else
            {
                textBox1.Text = btn4.Text;
                inputStatus = true;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (inputStatus)
            {
                textBox1.Text += btn3.Text;
            }
            else
            {
                textBox1.Text = btn3.Text;
                inputStatus = true;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (inputStatus)
            {
                textBox1.Text += btn2.Text;
            }
            else
            {
                textBox1.Text = btn2.Text;
                inputStatus = true;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (inputStatus)
            {
                textBox1.Text += btn1.Text;
            }
            else
            {
                textBox1.Text = btn1.Text;
                inputStatus = true;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (inputStatus)
            {
                if (textBox1.Text.Length >= 1)
                {
                    textBox1.Text += btn0.Text;
                }
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length != 0)
            {
                if(calcFunc == string.Empty)
                {
                    firstValue = System.Double.Parse(textBox1.Text);
                    textBox1.Text = string.Empty;
                }
                else
                {
                    //CalculateTotal();
                }
                calcFunc = "Add";
                hasDecimal = false;
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                if (calcFunc == string.Empty)
                {
                    firstValue = System.Double.Parse(textBox1.Text);
                    textBox1.Text = string.Empty;
                }
                else
                {
                    //CalculateTotal();
                }
                calcFunc = "Subtract";
                hasDecimal = false;
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                if (calcFunc == string.Empty)
                {
                    firstValue = System.Double.Parse(textBox1.Text);
                    textBox1.Text = string.Empty;
                }
                else
                {
                    //CalculateTotal();
                }
                calcFunc = "Multiply";
                hasDecimal = false;
            }
        }

        private void btnDevide_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                if (calcFunc == string.Empty)
                {
                    firstValue = System.Double.Parse(textBox1.Text);
                    textBox1.Text = string.Empty;
                }
                else
                {
                    //CalculateTotal();
                }
                calcFunc = "Divide";
                hasDecimal = false;
            }
        }

        private void btnExponent_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                if (calcFunc == string.Empty)
                {
                    firstValue = System.Double.Parse(textBox1.Text);
                    textBox1.Text = string.Empty;
                }
                else
                {
                    //CalculateTotal();
                }
                calcFunc = "PowerOf";
                hasDecimal = false;
            }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                tempValue = System.Double.Parse(textBox1.Text);
                tempValue = System.Math.Sqrt(tempValue);
                textBox1.Text = tempValue.ToString();
                hasDecimal = false;
            }
        }

        private void equals_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length != 0 && firstValue != 0)
            {
                //CalculateTotal();
                calcFunc = string.Empty;
                hasDecimal = false;
            }
        }

        private void btnInverse_Click(object sender, EventArgs e)
        {
            tempValue = System.Double.Parse(textBox1.Text);
            tempValue = 1 / tempValue;
            textBox1.Text = tempValue.ToString();
            hasDecimal = false;
        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            if(inputStatus)
            {
                if(textBox1.Text.Length > 0)
                {
                    firstValue = -1 * System.Double.Parse(textBox1.Text);
                    textBox1.Text = firstValue.ToString();
                }
            }
        }
    }
}
