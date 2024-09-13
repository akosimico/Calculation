using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmCalculator
{
    public partial class Form1 : Form
    {
        private CalculatorClass cal;
        double num1, num2;
        string op;
        public Form1()
        {
            InitializeComponent();
            cal = new CalculatorClass();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(guna2TextBox1.Text);
            num2 = Convert.ToDouble(guna2TextBox2.Text);
            
            if (guna2ComboBox1.SelectedItem == null)
            {
                answer.Text = "Please select an operator.";
            }
            else
                op = guna2ComboBox1.SelectedItem.ToString();
            switch (op)
            {
                case "+":
                    cal.CalculateEvent += cal.GetSum;
                    answer.Text = cal.Calculate(num1, num2).ToString();
                    break;
                case "-":
                    cal.CalculateEvent += cal.GetDiff;
                    answer.Text = cal.Calculate(num1, num2).ToString();
                    break;
                case "*":
                    cal.CalculateEvent += cal.GetProduct;
                    answer.Text = cal.Calculate(num1, num2).ToString();
                    break;
                case "/":
                    if(num2 != 0)
                    {
                        cal.CalculateEvent += cal.GetQou;
                        answer.Text = cal.Calculate(num1, num2).ToString();
                    }
                    else
                    {
                        answer.Text = "Cannot divide by zero.";
                    }
                    break;
                   
            }

        }
    }
}
