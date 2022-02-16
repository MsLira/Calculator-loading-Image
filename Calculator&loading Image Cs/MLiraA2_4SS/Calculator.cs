using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLiraA2_4SS
{
    public partial class Calculator : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            // clear the Zero that is befault 
            if ((txtBox_Result.Text == "0") || (isOperationPerformed))
                txtBox_Result.Clear();

            isOperationPerformed = false;
            // click event for all numbers
            Button button = (Button)sender;

            // For limited the Pions (.)
            if (button.Text == ".")
            { 
            
            if(!txtBox_Result.Text.Contains("."))
              txtBox_Result.Text = txtBox_Result.Text + button.Text;
            }
            else

            txtBox_Result.Text = txtBox_Result.Text + button.Text;

        }

        private void operator_click(object sender, EventArgs e)
        {
            // click event for all numbers
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                btn_equal.PerformClick();
                operationPerformed = button.Text;
               // resultValue = double.Parse(txtBox_Result.Text); // --> keep this line here
                lbl_CurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;// tracking of what I press

            }
            else
            {

                operationPerformed = button.Text;
                resultValue = Double.Parse(txtBox_Result.Text);
                lbl_CurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;// tracking of what I press
            }

        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            txtBox_Result.Text = "0";
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtBox_Result.Text = "0";
            resultValue = 0;
            
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            switch(operationPerformed)
            {
                case "+":
                    txtBox_Result.Text = (resultValue + Double.Parse(txtBox_Result.Text)).ToString();
                    break;

                case "-":
                    txtBox_Result.Text = (resultValue - Double.Parse(txtBox_Result.Text)).ToString();
                    break;

                case "*":
                    txtBox_Result.Text = (resultValue * Double.Parse(txtBox_Result.Text)).ToString();
                    break;

                case "/":
                    txtBox_Result.Text = (resultValue / Double.Parse(txtBox_Result.Text)).ToString();
                    break;

                default:
                    break;

            }
            // fixing the lebel update of numbers
            resultValue = Double.Parse(txtBox_Result.Text);
            lbl_CurrentOperation.Text = "";

        }
    }
}
