using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorForm : Form
    {
        private string currentInput = string.Empty;
        private double currentValue = 0.0;
        private string currentOperator = string.Empty;
        private bool isOperatorClicked = false;

        public CalculatorForm()
        {
            InitializeComponent();
            resultTextBox = new TextBox(); // Initialize 'resultTextBox' or set it to an existing non-null TextBox.
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (isOperatorClicked)
            {
                resultTextBox.Text = button.Text;
                isOperatorClicked = false;
            }
            else
            {
                resultTextBox.Text += button.Text;
            }
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentOperator))
            {
                Calculate();
            }
            currentOperator = ((Button)sender).Text;
            isOperatorClicked = true;
            currentInput = resultTextBox.Text;
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            Calculate();
            currentOperator = string.Empty;
        }

        private void Calculate()
        {
            if (double.TryParse(currentInput, out double input) && double.TryParse(resultTextBox.Text, out double currentValue))
            {
                switch (currentOperator)
                {
                    case "+":
                        currentValue = input + currentValue;
                        break;
                    case "-":
                        currentValue = input - currentValue;
                        break;
                    case "×":
                        currentValue = input * currentValue;
                        break;
                    case "÷":
                        if (currentValue != 0)
                        {
                            currentValue = input / currentValue;
                        }
                        else
                        {
                            currentValue = double.NaN;
                        }
                        break;
                }
                resultTextBox.Text = currentValue.ToString();
                isOperatorClicked = true;
                currentInput = currentValue.ToString();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = string.Empty;
            currentInput = string.Empty;
            currentOperator = string.Empty;
        }

        private TextBox resultTextBox;
        private Button numberButton1;
        private Button numberButton2;
        private Button numberButton3;
        private Button numberButton4;
        private Button numberButton5;
        private Button numberButton6;
        private Button numberButton7;
        private Button numberButton8;
        private Button numberButton9;
        private Button numberButton0;

        private Button operatorButtonAdd;
        private Button operatorButtonSubtract;
        private Button operatorButtonMultiply;
        private Button operatorButtonDivide;
        private Button equalsButton;
        private Button clearButton;

        private void InitializeComponent()
        {


            this.numberButton1 = new System.Windows.Forms.Button();
            this.numberButton1.Visible = true;
            this.numberButton1.Size = new System.Drawing.Size(50, 50);
            this.numberButton1.Location = new System.Drawing.Point(10, 50);
            this.numberButton1.Text = "1";

            this.numberButton2 = new System.Windows.Forms.Button();
            this.numberButton2.Visible = true;
            this.numberButton2.Size = new System.Drawing.Size(50, 50);
            this.numberButton2.Location = new System.Drawing.Point(70, 50);
            this.numberButton2.Text = "2";

            this.numberButton3 = new System.Windows.Forms.Button();
            this.numberButton3.Visible = true;
            this.numberButton3.Size = new System.Drawing.Size(50, 50);
            this.numberButton3.Location = new System.Drawing.Point(130, 50);
            this.numberButton3.Text = "3";
            
            this.operatorButtonSubtract = new System.Windows.Forms.Button();
            this.operatorButtonSubtract.Visible = true;
            this.operatorButtonSubtract.Size = new System.Drawing.Size(50, 50);
            this.operatorButtonSubtract.Location = new System.Drawing.Point(190, 50);
            this.operatorButtonSubtract.Text = "-";

            this.numberButton4 = new System.Windows.Forms.Button();
            this.numberButton4.Visible = true;
            this.numberButton4.Size = new System.Drawing.Size(50, 50);
            this.numberButton4.Location = new System.Drawing.Point(10, 110);
            this.numberButton4.Text = "4";

            this.numberButton5 = new System.Windows.Forms.Button();
            this.numberButton5.Visible = true;
            this.numberButton5.Size = new System.Drawing.Size(50, 50);
            this.numberButton5.Location = new System.Drawing.Point(70, 110);
            this.numberButton5.Text = "5";

            this.numberButton6 = new System.Windows.Forms.Button();
            this.numberButton6.Visible = true;
            this.numberButton6.Size = new System.Drawing.Size(50, 50);
            this.numberButton6.Location = new System.Drawing.Point(130, 110);
            this.numberButton6.Text = "6";

            this.operatorButtonAdd=new System.Windows.Forms.Button();
            this.operatorButtonAdd.Visible = true;
            this.operatorButtonAdd.Size = new System.Drawing.Size(50, 50);
            this.operatorButtonAdd.Location = new System.Drawing.Point(190, 110);
            this.operatorButtonAdd.Text = "+";

            this.numberButton7 = new System.Windows.Forms.Button();
            this.numberButton7.Visible = true;
            this.numberButton7.Size = new System.Drawing.Size(50, 50);
            this.numberButton7.Location = new System.Drawing.Point(10, 170);
            this.numberButton7.Text = "7";

            this.numberButton8 = new System.Windows.Forms.Button();
            this.numberButton8.Visible = true;
            this.numberButton8.Size = new System.Drawing.Size(50, 50);
            this.numberButton8.Location = new System.Drawing.Point(70, 170);
            this.numberButton8.Text = "8";

            this.numberButton9 = new System.Windows.Forms.Button();
            this.numberButton9.Visible = true;
            this.numberButton9.Size = new System.Drawing.Size(50, 50);
            this.numberButton9.Location = new System.Drawing.Point(130, 170);
            this.numberButton9.Text = "9";

            this.operatorButtonMultiply = new System.Windows.Forms.Button();
            this.operatorButtonMultiply.Visible = true;
            this.operatorButtonMultiply.Size = new System.Drawing.Size(50, 50);
            this.operatorButtonMultiply.Location = new System.Drawing.Point(190, 170);
            this.operatorButtonMultiply.Text = "*";

            this.operatorButtonDivide = new System.Windows.Forms.Button();
            this.operatorButtonDivide.Visible = true;
            this.operatorButtonDivide.Size = new System.Drawing.Size(50, 50);
            this.operatorButtonDivide.Location = new System.Drawing.Point(190, 230);
            this.operatorButtonDivide.Text = "/";

            this.numberButton0 = new System.Windows.Forms.Button();
            this.numberButton0.Visible = true;
            this.numberButton0.Size = new System.Drawing.Size(50, 50);
            this.numberButton0.Location = new System.Drawing.Point(70, 230);
            this.numberButton0.Text = "0";

            this.equalsButton = new System.Windows.Forms.Button();
            this.equalsButton.Visible = true;
            this.equalsButton.Size = new System.Drawing.Size(50, 50);
            this.equalsButton.Location = new System.Drawing.Point(130, 230);
            this.equalsButton.Text = "=";

            this.clearButton = new System.Windows.Forms.Button();
            this.clearButton.Visible = true;
            this.clearButton.Size = new System.Drawing.Size(50, 50);
            this.clearButton.Location = new System.Drawing.Point(10, 230);
            this.clearButton.Text = "C";

            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox.Visible = true;
            this.resultTextBox.Size = new System.Drawing.Size(200, 30);  // Set the size (width and height) in pixels
            this.resultTextBox.Location = new System.Drawing.Point(10, 10);  // Set the location (X and Y coordinates) in pixels
            this.resultTextBox.Text = "";  // Set the initial text



            // Add controls to the form.
            this.Controls.Add(resultTextBox);
            this.Controls.Add(numberButton1);
            this.Controls.Add(numberButton2);
            this.Controls.Add(numberButton3);
            this.Controls.Add(numberButton4);
            this.Controls.Add(numberButton5);
            this.Controls.Add(numberButton6);
            this.Controls.Add(numberButton7);
            this.Controls.Add(numberButton8);
            this.Controls.Add(numberButton9);
            this.Controls.Add(numberButton0);
            this.Controls.Add(operatorButtonAdd);
            this.Controls.Add(operatorButtonSubtract);
            this.Controls.Add(operatorButtonDivide);
            this.Controls.Add(operatorButtonMultiply);
            this.Controls.Add(clearButton);
            this.Controls.Add(equalsButton);
            this.Text = "Calculator";
        }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CalculatorForm());
        }
    }
}
