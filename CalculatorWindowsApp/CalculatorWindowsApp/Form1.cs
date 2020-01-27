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

        public Form1()
        {
            InitializeComponent();
        }

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

        private void btOperator_Click(object sender, EventArgs e)
        {

        }

        private void btEqual_Click(object sender, EventArgs e)
        {
            switch (switch_on)
            {
                default:
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbResult.Text = "0";
            resultValue = 0;
        }

        private void btPercent_Click(object sender, EventArgs e)
        {

        }
    }
}
