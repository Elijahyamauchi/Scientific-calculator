namespace Sci_Calc

{
    using System;
    using System.Collections.Generic;
    using System.Data;

    public partial class Calculator : Form
    {
        private string currentInput = string.Empty;
        private double currentValue = 0.0;
        private string firstNumberValueString = string.Empty;
        private string secondNumberValueString = string.Empty;
        private double firstNumberValue = 0.0;
        private double secondNumberValue = 0.0;
        private string currentOperator = string.Empty;
        private string equationString = string.Empty;


        public Calculator()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button inputButton = (Button)sender;
            DisplayWindow.Text += inputButton.Text;
            equationString += inputButton.Text;
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            DisplayWindow.Text += ((Button)sender).Text;
            equationString += ((Button)sender).Text;
        }


        public static double Evaluate(string expression)
        {
            try
            {
                var table = new DataTable();
                return Convert.ToDouble(table.Compute(expression, ""));
            }
            catch (Exception ex)
            {
                // Print details of the exception to help with debugging
                Console.WriteLine($"Error evaluating expression: {ex.Message}");
                Console.WriteLine($"Expression: {expression}");
                return double.NaN; // or throw an exception, return a specific value, etc.
            }
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            currentValue = Evaluate(equationString);
            DisplayWindow.Text = currentValue.ToString();
            currentOperator = string.Empty;
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            DisplayWindow.Text = string.Empty;
            currentInput = string.Empty;
            currentOperator = string.Empty;
            equationString=string.Empty;
        }
    }
}
