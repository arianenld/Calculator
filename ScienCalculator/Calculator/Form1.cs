using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double FirstInputNumber;
        string Ope;
        string MPlus, MMinus, MRetrieve, MClear, MSave;
        public Form1()
        {
            InitializeComponent();
        }

        public void DisplayValue(string value)
        {
            string val = value;
            if (txtboxComp.Text == "0" && txtboxComp.Text != null)
            {
                txtboxComp.Text = val;
            }
            else
            {
                txtboxComp.Text = txtboxComp.Text + val;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            string zero = (sender as Button).Text;
            txtboxComp.Text = txtboxComp.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string one = (sender as Button).Text;
            DisplayValue(one);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string two = (sender as Button).Text;
            DisplayValue(two);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string three = (sender as Button).Text;
            DisplayValue(three);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            string four = (sender as Button).Text;
            DisplayValue(four);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            string five = (sender as Button).Text;
            DisplayValue(five);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            string six = (sender as Button).Text;
            DisplayValue(six);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            string seven = (sender as Button).Text;
            DisplayValue(seven);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            string eight = (sender as Button).Text;
            DisplayValue(eight);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            string nine = (sender as Button).Text;
            DisplayValue(nine);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string add = (sender as Button).Text;
            FirstInputNumber = Convert.ToDouble(txtboxComp.Text);
            txtboxComp.Text = "+";
            Ope = add;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            string minus = (sender as Button).Text;
            FirstInputNumber = Convert.ToDouble(txtboxComp.Text);
            txtboxComp.Text = "0";
            Ope = minus;
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            string multiply = (sender as Button).Text;
            FirstInputNumber = Convert.ToDouble(txtboxComp.Text);
            txtboxComp.Text = "0";
            Ope = multiply;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            string divide = (sender as Button).Text;
            FirstInputNumber = Convert.ToDouble(txtboxComp.Text);
            txtboxComp.Text = "0";
            Ope = divide;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            string equals = (sender as Button).Text;
            double SecondInputNumber;
            double Computation;

            SecondInputNumber = Convert.ToDouble(txtboxComp.Text);

            if (Ope == "+")
            {
                Computation = (FirstInputNumber + SecondInputNumber);
                txtboxComp.Text = Convert.ToString(Computation);
                FirstInputNumber = Computation;
            }
            if (Ope == "-")
            {
                Computation = (FirstInputNumber - SecondInputNumber);
                txtboxComp.Text = Convert.ToString(Computation);
                FirstInputNumber = Computation;
            }
            if (Ope == "*")
            {
                Computation = (FirstInputNumber * SecondInputNumber);
                txtboxComp.Text = Convert.ToString(Computation);
                FirstInputNumber = Computation;
            }
            if (Ope == "/")
            {
                if (SecondInputNumber == 0)
                {
                    txtboxComp.Text = "0";
                    MessageBox.Show("Transaction invalid. Cannot divide by zero.");
                }
                else
                {
                    Computation = (FirstInputNumber / SecondInputNumber);
                    txtboxComp.Text = Convert.ToString(Computation);
                    FirstInputNumber = Computation;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxComp.Text = "0";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtboxComp.Text = txtboxComp.Text + ".";
        }
    }
}
