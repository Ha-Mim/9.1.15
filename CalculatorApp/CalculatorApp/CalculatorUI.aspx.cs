using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorApp
{
    public partial class CalculatorUI : System.Web.UI.Page
    {
        Calculator aCalculator = new Calculator();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            double sum = aCalculator.ADD(firstNumber,secondNumber);
            resultTextBox.Text = sum.ToString();
        }

        protected void substractButton_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            double sum = aCalculator.Subtract(firstNumber,secondNumber);
            resultTextBox.Text = sum.ToString();
        }

        protected void multiplyButton_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            double sum = aCalculator.Multiply(firstNumber,secondNumber);
            resultTextBox.Text = sum.ToString();
        }

        protected void divideButton_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            double sum = aCalculator.Divide(firstNumber,secondNumber);
            resultTextBox.Text = sum.ToString();
        }
    }
}