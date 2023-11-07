namespace Sci_Calc
{
    public partial class Calculator : Form
    {
        private string currentInput = string.Empty;
        private double currentValue = 0.0;
        private string firstNumberValueString = string.Empty;
        private string secondNumberValueString = string.Empty;
        private double firstNumberValue = 0.0;
        private double secondNumberValue = 0.0;
        private string currentOperator = string.Empty;


        public Calculator()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button inputButton = (Button)sender;
            DisplayWindow.Text += inputButton.Text;

            if (currentOperator == string.Empty)
            {
                firstNumberValueString = firstNumberValueString + inputButton.Text;
            }
            else
            {
                secondNumberValueString = secondNumberValueString + inputButton.Text;
            }
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            currentOperator = ((Button)sender).Text;
            DisplayWindow.Text += ((Button)sender).Text;
        }

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