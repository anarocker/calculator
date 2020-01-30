using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsApp
{
    public partial class Form1 : Form
    {
        double resultValue;
        string operatorChar = "";
        bool operatorBool = false;
        string Num1, Sum;

        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Number and Dot Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNum_Click(object sender, EventArgs e)
        {
            if (tbResult.Text == "0" || operatorBool)
            {
                tbResult.Clear();
            }
            operatorBool = false;

            Button button = (Button)sender;

            if (button.Text == ".")
            {
                if (!tbResult.Text.Contains("."))
                {
                    tbResult.Text = tbResult.Text + button.Text;
                    tbValue.AppendText(button.Text);
                }
            }
            else
            {
                tbResult.Text = tbResult.Text + button.Text;
                tbValue.AppendText(button.Text);
            }

        }

        /// <summary>
        /// Operator Buntton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btOperator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                operatorChar = button.Text;
                resultValue = double.Parse(tbResult.Text);
                lbNum1.Text = resultValue + "   " + operatorChar;
                tbValue.AppendText(operatorChar);
                operatorBool = true;
            }
            else
            {
                operatorChar = button.Text;
                resultValue = double.Parse(tbResult.Text);
                lbNum1.Text = resultValue + "   " + operatorChar;
                if (tbResult.Text != "0")
                {
                    tbValue.AppendText(operatorChar);
                }
                operatorBool = true;
            }

        }

        /// <summary>
        /// Sum Button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btEqual_Click(object sender, EventArgs e)
        {
            lbNum2.Text = double.Parse(tbResult.Text).ToString();
            Num1 = lbNum1.Text + " " + lbNum2.Text;
            switch (operatorChar)
            {
                case "+":
                    tbResult.Text = (resultValue + double.Parse(tbResult.Text)).ToString();
                    Sum = tbResult.Text;
                    break;

                case "-":
                    tbResult.Text = (resultValue - double.Parse(tbResult.Text)).ToString();
                    Sum = tbResult.Text;
                    break;

                case "*":
                    tbResult.Text = (resultValue * double.Parse(tbResult.Text)).ToString();
                    Sum = tbResult.Text;
                    break;

                case "/":
                    tbResult.Text = (resultValue / double.Parse(tbResult.Text)).ToString();
                    Sum = tbResult.Text;
                    break;
                
            }
            tbHistory.AppendText(Num1 + "  " + "=" + "  " + "\r\n");    //Show on History Box.
            tbHistory.AppendText(Sum+"\r\n");
        }


        /// <summary>
        /// Percent Button (%)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btPercent_Click(object sender, EventArgs e)
        {
            if (operatorChar == "+" || operatorChar == "-" || operatorChar == "*" || operatorChar == "/")
            {
                tbResult.Text = ((double.Parse(tbResult.Text) / 100) * resultValue).ToString();
            }
            else
            {
                tbResult.Text = (double.Parse(tbResult.Text) / 100).ToString();
            }
        }


        /// <summary>
        /// Clear Value Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btClear_Click(object sender, EventArgs e)
        {
            tbResult.Text = "0";
            resultValue = 0;
            lbNum1.Text = "";
            lbNum2.Text = "";
            tbValue.Text = "";
        }


        /// <summary>
        /// Clear History Box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btClearHis_Click(object sender, EventArgs e)
        {
            tbHistory.Text = "";
        }


        /// <summary>
        /// Delete Last Number (Backspace)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btBackspace_Click(object sender, EventArgs e)
        {
            if (tbResult.TextLength != 0)
            {
                tbResult.Text = tbResult.Text.Remove(tbResult.Text.Length - 1, 1);
                tbValue.Text = tbValue.Text.Remove(tbValue.Text.Length - 1, 1);
            }
        }


    }
}