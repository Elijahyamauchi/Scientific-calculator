namespace Sci_Calc

{
    using System;
    using System.Collections.Generic;
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
            equationString+=inputButton.Text;
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            DisplayWindow.Text += ((Button)sender).Text;
            equationString +=((Button)sender).Text;
        }

        //
        Dictionary<string, int> numbers_dict = new Dictionary<string, int>();
        List<char> operators = new List<char>();
        
        private void parsre(string equationString) {
            for (int i = 0; i < equationString.Length; i++)
            {
                char c = equationString[i];

                if (char.IsDigit(c) || equationString[i] == '.')
                {
                    int start = i;
                    while (i < equationString.Length && (char.IsDigit(equationString[i]) || equationString[i] == '.'))
                    {
                        i++;
                    }
                    string number = equationString.Substring(start, i - start);
                    numbers_dict[number] = start;
                    i--;
                }
                else
                {
                    operators.Add(c);
                    numbers_dict[c.ToString()] = i;
                }
            }
        }

        //
        private void EqualsButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(DisplayWindow.Text))
            {
                double firstNumberValue = Convert.ToDouble(firstNumberValueString);
                double secondNumberValue = Convert.ToDouble(secondNumberValueString);

                switch (currentOperator)
                {
                    case "+":
                        currentValue = firstNumberValue + secondNumberValue;
                        break;
                    case "-":
                        currentValue = firstNumberValue - secondNumberValue;
                        break;
                    case "*":
                        currentValue = firstNumberValue * secondNumberValue;
                        break;
                    case "/":
                        currentValue = secondNumberValue == 0 ? double.NaN :
                                       firstNumberValue / secondNumberValue;
                        break;
                }
                DisplayWindow.Text = currentValue.ToString();
                currentInput = currentValue.ToString();
                currentOperator = string.Empty;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DisplayWindow.Text = string.Empty;
            currentInput = string.Empty;
            currentOperator = string.Empty;
        }
    }
}