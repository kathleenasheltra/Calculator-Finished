using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class frmCalculator : Form
    {
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        string result;
        char operation;

        public frmCalculator()
        {
            InitializeComponent();
        }

        private void frmCalculator_Load(object sender, EventArgs e)
        {
            btn1.Click += new EventHandler(btn_Click);
            btn2.Click += new EventHandler(btn_Click);
            btn3.Click += new EventHandler(btn_Click);
            btn4.Click += new EventHandler(btn_Click);
            btn5.Click += new EventHandler(btn_Click);
            btn6.Click += new EventHandler(btn_Click);
            btn7.Click += new EventHandler(btn_Click);
            btn8.Click += new EventHandler(btn_Click);
            btn9.Click += new EventHandler(btn_Click);
            btn0.Click += new EventHandler(btn_Click);

            btnDot.Click += new EventHandler(btn_Click);
        }

        void btn_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = sender as Button;

                switch (btn.Name)
                {
                    case "btn1":
                        txtInput.Text += "1";
                        break;
                    case "btn2":
                        txtInput.Text += "2";
                        break;
                    case "btn3":
                        txtInput.Text += "3";
                        break;
                    case "btn4":
                        txtInput.Text += "4";
                        break;
                    case "btn5":
                        txtInput.Text += "5";
                        break;
                    case "btn6":
                        txtInput.Text += "6";
                        break;
                    case "btn7":
                        txtInput.Text += "7";
                        break;
                    case "btn8":
                        txtInput.Text += "8";
                        break;
                    case "btn9":
                        txtInput.Text += "9";
                        break;
                    case "btn0":
                        txtInput.Text += "0";
                        break;             

                    case "btnDot":
                        if(!txtInput.Text.Contains("."))
                            txtInput.Text += ".";
                        break;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sorry for the inconvenience, Unexpected error occured. Details: " +
                    ex.Message);
            }
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            operand2 = txtInput.Text;

            double opr1, opr2;
            double.TryParse(operand1, out opr1);
            double.TryParse(operand2, out opr2);

            switch (operation)
            {
                case '+':
                    result = (opr1 + opr2).ToString();
                    break;

                case '-':
                    result = (opr1 - opr2).ToString();
                    break;

                case '*':
                    result = (opr1 * opr2).ToString();
                    break;

                case '/':
                    if (opr2 != 0)
                    {
                        result = (opr1 / opr2).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Can't divide by zero");
                    }
                    break;
            }

            txtInput.Text = result.ToString();
        }


        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                case '2':
          
                //case '+':
                //case '-':
                //case '*':
                //case '/':
                //case '.':
                    break;
                default:
                    e.Handled = true;
                    MessageBox.Show("Only numbers, +, -, ., *, / are allowed");
                    break;
            }           
        }


       

       



        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            operand1 = txtInput.Text;
            operation = '+';
            txtInput.Text = "";
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            operand1 = txtInput.Text;
            operation = '-';
            txtInput.Text = "";
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            operand1 = txtInput.Text;
            operation = '/';
            txtInput.Text = "";
        }
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            operand1 = txtInput.Text;
            operation = '*';
            txtInput.Text = "";
        }
        private void btnSqrRoot_Click(object sender, EventArgs e)
        {
            double opr1;
            if (double.TryParse(txtInput.Text, out opr1))
            {
                txtInput.Text = (Math.Sqrt(opr1)).ToString();
            }
        }

        private void btnByTwo_Click(object sender, EventArgs e)
        {
            double opr1;
            if (double.TryParse(txtInput.Text, out opr1))
            {
                txtInput.Text = (opr1 / 2).ToString();
            }
        }

        private void btnByFour_Click(object sender, EventArgs e)
        {
            double opr1;
            if (double.TryParse(txtInput.Text, out opr1))
            {
                txtInput.Text = (opr1 / 4).ToString();
            }
        }

    }
}
