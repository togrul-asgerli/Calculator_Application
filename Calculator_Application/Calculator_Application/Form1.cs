using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Calculator_Application
{
    public partial class Calculator : Form
    {
        bool operandPerformed = false;
        string operand = "";
        double result = 0;
        public Calculator()
        {
            InitializeComponent();
        }
       
        private void NumEvent(object sender, EventArgs e)
        {
            if(textBox1.Text=="0" || operandPerformed)
            {
                textBox1.Clear();
            }
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
            operandPerformed = false;
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            lbl_result.Text = "";
            operandPerformed = true;

            switch(operand)
            {

                case "+":
                    textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "X":
                    textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "÷":
                    textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString();
                    break;
                default: break;
            }
            result = Double.Parse(textBox1.Text);
            textBox1.Text = result.ToString();
            result = 0;
            operand = "";
        }

        private void btn_point_Click(object sender, EventArgs e)
        {
            int c = textBox1.TextLength;
            int flag = 0;
            string text = textBox1.Text;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag = 1; break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }

        private void OperandEvent(object sender, EventArgs e)
        {
            operandPerformed = true;
            Button btn = (Button)sender;
            string newOperand = btn.Text;

            lbl_result.Text = lbl_result.Text + " " + textBox1.Text + " " + newOperand;

            switch (operand)
            {
                case "+":textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "X":textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "÷":textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:break;
            }
            result = Double.Parse(textBox1.Text);
            operand = newOperand;
        }

        private void btn_ce_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            lbl_result.Text = "";
            result = 0;
            operand = "";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length==0)
            {
                textBox1.Text = "0";
            }
            textBox1.Text=textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

        private void btn_reverse_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_result.Text = lbl_result.Text + "1/" + textBox1.Text;
                textBox1.Text = (1 / Double.Parse(textBox1.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("NAN doesn't aceptable");
            }
        }

        private void btn_square_Click(object sender, EventArgs e)
        {
            lbl_result.Text = "";
            lbl_result.Text = lbl_result.Text + "sqr(" + textBox1.Text + ")";
            textBox1.Text = (Math.Pow(Double.Parse(textBox1.Text), 2)).ToString();
            
        }

        private void btn_root_Click(object sender, EventArgs e)
        {
            
                lbl_result.Text = "";
                lbl_result.Text = lbl_result.Text + "sqrt(" + textBox1.Text + ")";
                textBox1.Text = (Math.Sqrt(Double.Parse(textBox1.Text))).ToString();
            
           
        }

        private void btn_percent_Click(object sender, EventArgs e)
        {
            double  pi= Math.PI;
            textBox1.Text = pi.ToString();
        }

        private void btn_sign_Click(object sender, EventArgs e)
        {
            textBox1.Text = ((-1) * Double.Parse(textBox1.Text)).ToString();
        }
    }
}
