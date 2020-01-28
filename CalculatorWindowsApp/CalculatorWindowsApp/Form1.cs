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
        string Num1, Num2, Sum;

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

            if (tbResult.Text == ".")
            {
                if (tbResult.Text.Contains("."))
                {
                    tbResult.Text = tbResult.Text + button.Text;
                }
            }
            else
            {
                tbResult.Text = tbResult.Text + button.Text;
            }

        }

        /// <summary>
        /// Operator Buntton (+, -, *, /)
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
                operatorChar = button.Text;
                lbNum1.Text = resultValue + "   " + operatorChar;
                operatorBool = true;
                Num1 = lbNum1.Text;
                tbValue.AppendText(operatorChar);
            }
            else
            {
                operatorChar = button.Text;
                resultValue = double.Parse(tbResult.Text);
                operatorChar = button.Text;
                lbNum1.Text = resultValue + "   " + operatorChar;
                operatorBool = true;
                Num1 = lbNum1.Text;
            }

        }

        /// <summary>
        /// Equal Button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btEqual_Click(object sender, EventArgs e)
        {
            switch (operatorChar)
            {
                case "+":
                    lbNum2.Text = double.Parse(tbResult.Text).ToString(); 
                    tbResult.Text = (resultValue + double.Parse(tbResult.Text)).ToString();
                    Num2 = lbNum2.Text;
                    Sum = tbResult.Text;
                    break;

                case "-":
                    lbNum2.Text = double.Parse(tbResult.Text).ToString();
                    tbResult.Text = (resultValue - double.Parse(tbResult.Text)).ToString();
                    Num2 = lbNum2.Text;
                    Sum = tbResult.Text;
                    break;

                case "*":
                    lbNum2.Text = double.Parse(tbResult.Text).ToString();
                    tbResult.Text = (resultValue * double.Parse(tbResult.Text)).ToString();
                    Num2 = lbNum2.Text;
                    Sum = tbResult.Text;
                    break;

                case "/":
                    lbNum2.Text = double.Parse(tbResult.Text).ToString();
                    tbResult.Text = (resultValue / double.Parse(tbResult.Text)).ToString();
                    Num2 = lbNum2.Text;
                    Sum = tbResult.Text;
                    break;
            }
            tbHistory.AppendText(Num1 + "  " + Num2 + "  " + "=" + "  " + Sum + "\r\n");    //Show on History Box.
            
        }

        /// <summary>
        /// Percent Button (%)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btPercent_Click(object sender, EventArgs e)
        {
            //Button button = (Button)sender;
            //if (tbResult.Text != 0 || )
            //{
            //    operatorChar = button.Text;
            //    resultValue = double.Parse(tbResult.Text);
            //    operatorChar = button.Text;
            //    lbNum1.Text = resultValue + "   " + operatorChar;
            //    operatorBool = true;
            //    Num1 = lbNum1.Text;

            //tbResult.Text = ((resultValue / double.Parse(tbResult.Text))/100).ToString();
            //test = tbResult.Text;
            //tbResult.AppendText(test);
            //}
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
            }
        }

       
    }
}
