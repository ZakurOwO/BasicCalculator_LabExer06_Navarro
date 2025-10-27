using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorPrivateAssembly2;


namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBoxInput1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxData_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxInput2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResultTotal_Click(object sender, EventArgs e)
        {

        }

        private void ComputeBTN_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(TextBoxInput1.Text);
            float num2 = float.Parse(TextBoxInput2.Text);
            string operation = ComboBoxData.Text;
            float result = 0;

            if (operation == "+")
            {
                result = BasicComputation.Add(num1, num2);
            }
            else if (operation == "-")
            {
                result = BasicComputation.Subtract(num1, num2);
            }
            else if (operation == "*")
            {
                result = BasicComputation.Multiply(num1, num2);
            }
            else if (operation == "/")
            {
                result = BasicComputation.Divide(num1, num2);
            }

            ResultTotal.Text = result.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}