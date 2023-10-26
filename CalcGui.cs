using System;
using System.Windows.Forms;
//things to upgrade
//make it able to handle 2 digit numbers
//fix divide by zero
//pendas
//make the window fit the button
//fix up the names get rid of "testnum bla"
namespace CalculatorApp
{
    public partial class CalculatorForm : Form
    {
        // Fields to keep track of user input and calculations
        private string currentInput = string.Empty;
        private double currentValue = 0.0;
        private string num1=string.Empty;
        private string num2=string.Empty;
        private double  testnum1=0.0;
        private double  testnum2=0.0;
        private string currentOperator = string.Empty;
        private bool isOperatorClicked = false;

        private TextBox resultTextBox;

        //declaring the buttons
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

        //declaring the operators
        private Button operatorButtonAdd;
        private Button operatorButtonSubtract;
        private Button operatorButtonMultiply;
        private Button operatorButtonDivide;
        private Button equalsButton;
        private Button clearButton;

        public Button NumberButton5 { get => numberButton5; set => numberButton5 = value; }

        public CalculatorForm()
        {
            InitializeComponent();
        }

        // current main poblem, the test num cant get a double from the num 1 which should be getting a string number from the button
        private void NumberButton_Click(object sender, EventArgs e)
        {
            
            if (currentOperator == string.Empty){

                Button button = (Button)sender;
                num1=button.Text;
                resultTextBox.Text += button.Text;
                testnum1=Convert.ToDouble(num1);

            }
            else{
                Button button = (Button)sender;
                num2=button.Text;
                resultTextBox.Text += button.Text;
                testnum2=Convert.ToDouble(num2);

            }
            
        }

        //event handeler for operators
        private void OperatorButton_Click(object sender, EventArgs e)
        {
            currentOperator = ((Button)sender).Text;
            resultTextBox.Text += ((Button)sender).Text;
        }


        private void EqualsButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(resultTextBox.Text))
            {
                Calculate();
                currentOperator = string.Empty;
            }
        }

        //event handeler for clear button
        private void ClearButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = string.Empty;
            currentInput = string.Empty;
            currentOperator = string.Empty;
        }

        private void Calculate()
        {



                switch (currentOperator)
                {
                    case "+":
                        currentValue = testnum1 + testnum2;

                        break;
                    case "-":
                        currentValue = testnum1 - testnum2;
                        break;
                    case "×":
                        currentValue = testnum1 * testnum2;
                        break;
                    case "÷":
                        if (currentValue != 0)
                        {
                            currentValue = testnum1 / testnum2;
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


        //creating the buttons, makes them visable, sets their size and position, text, and click function
        private void InitializeComponent()
        {
            resultTextBox = new TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox.Visible = true;
            this.resultTextBox.Size = new System.Drawing.Size(200, 30);  // Set the size (width and height) in pixels
            this.resultTextBox.Location = new System.Drawing.Point(10, 10);  // Set the location (X and Y coordinates) in pixels
            this.resultTextBox.Text = "";  // Set the initial text
            this.Controls.Add(resultTextBox);

            this.numberButton1 = new System.Windows.Forms.Button();
            this.numberButton1.Visible = true;
            this.numberButton1.Size = new System.Drawing.Size(50, 50);
            this.numberButton1.Location = new System.Drawing.Point(10, 50);
            this.numberButton1.Text = "1";
            this.Controls.Add(numberButton1);
            this.numberButton1.Click += NumberButton_Click;

            this.numberButton2 = new System.Windows.Forms.Button();
            this.numberButton2.Visible = true;
            this.numberButton2.Size = new System.Drawing.Size(50, 50);
            this.numberButton2.Location = new System.Drawing.Point(70, 50);
            this.numberButton2.Text = "2";
            this.Controls.Add(numberButton2);
            this.numberButton2.Click += NumberButton_Click;

            this.numberButton3 = new System.Windows.Forms.Button();
            this.numberButton3.Visible = true;
            this.numberButton3.Size = new System.Drawing.Size(50, 50);
            this.numberButton3.Location = new System.Drawing.Point(130, 50);
            this.numberButton3.Text = "3";
            this.Controls.Add(numberButton3);
            this.numberButton3.Click += NumberButton_Click;

            this.operatorButtonSubtract = new System.Windows.Forms.Button();
            this.operatorButtonSubtract.Visible = true;
            this.operatorButtonSubtract.Size = new System.Drawing.Size(50, 50);
            this.operatorButtonSubtract.Location = new System.Drawing.Point(190, 50);
            this.operatorButtonSubtract.Text = "-";
            this.Controls.Add(operatorButtonSubtract);
            this.operatorButtonSubtract.Click += OperatorButton_Click;

            this.numberButton4 = new System.Windows.Forms.Button();
            this.numberButton4.Visible = true;
            this.numberButton4.Size = new System.Drawing.Size(50, 50);
            this.numberButton4.Location = new System.Drawing.Point(10, 110);
            this.numberButton4.Text = "4";
            this.Controls.Add(numberButton4);
            this.numberButton4.Click += NumberButton_Click;

            this.NumberButton5 = new System.Windows.Forms.Button();
            this.NumberButton5.Visible = true;
            this.NumberButton5.Size = new System.Drawing.Size(50, 50);
            this.NumberButton5.Location = new System.Drawing.Point(70, 110);
            this.NumberButton5.Text = "5";
            this.Controls.Add(NumberButton5);
            this.NumberButton5.Click += NumberButton_Click;

            this.numberButton6 = new System.Windows.Forms.Button();
            this.numberButton6.Visible = true;
            this.numberButton6.Size = new System.Drawing.Size(50, 50);
            this.numberButton6.Location = new System.Drawing.Point(130, 110);
            this.numberButton6.Text = "6";
            this.Controls.Add(numberButton6);
            this.numberButton6.Click += NumberButton_Click;

            this.operatorButtonAdd = new System.Windows.Forms.Button();
            this.operatorButtonAdd.Visible = true;
            this.operatorButtonAdd.Size = new System.Drawing.Size(50, 50);
            this.operatorButtonAdd.Location = new System.Drawing.Point(190, 110);
            this.operatorButtonAdd.Text = "+";
            this.Controls.Add(operatorButtonAdd);
            this.operatorButtonAdd.Click += OperatorButton_Click;

            this.numberButton7 = new System.Windows.Forms.Button();
            this.numberButton7.Visible = true;
            this.numberButton7.Size = new System.Drawing.Size(50, 50);
            this.numberButton7.Location = new System.Drawing.Point(10, 170);
            this.numberButton7.Text = "7";
            this.Controls.Add(numberButton7);
            this.numberButton7.Click += NumberButton_Click;

            this.numberButton8 = new System.Windows.Forms.Button();
            this.numberButton8.Visible = true;
            this.numberButton8.Size = new System.Drawing.Size(50, 50);
            this.numberButton8.Location = new System.Drawing.Point(70, 170);
            this.numberButton8.Text = "8";
            this.Controls.Add(numberButton8);
            this.numberButton8.Click += NumberButton_Click;

            this.numberButton9 = new System.Windows.Forms.Button();
            this.numberButton9.Visible = true;
            this.numberButton9.Size = new System.Drawing.Size(50, 50);
            this.numberButton9.Location = new System.Drawing.Point(130, 170);
            this.numberButton9.Text = "9";
            this.Controls.Add(numberButton9);
            this.numberButton9.Click += NumberButton_Click;

            this.operatorButtonMultiply = new System.Windows.Forms.Button();
            this.operatorButtonMultiply.Visible = true;
            this.operatorButtonMultiply.Size = new System.Drawing.Size(50, 50);
            this.operatorButtonMultiply.Location = new System.Drawing.Point(190, 170);
            this.operatorButtonMultiply.Text = "*";
            this.Controls.Add(operatorButtonMultiply);
            this.operatorButtonMultiply.Click += OperatorButton_Click;

            this.operatorButtonDivide = new System.Windows.Forms.Button();
            this.operatorButtonDivide.Visible = true;
            this.operatorButtonDivide.Size = new System.Drawing.Size(50, 50);
            this.operatorButtonDivide.Location = new System.Drawing.Point(190, 230);
            this.operatorButtonDivide.Text = "/";
            this.Controls.Add(operatorButtonDivide);
            this.operatorButtonDivide.Click += OperatorButton_Click;

            this.numberButton0 = new System.Windows.Forms.Button();
            this.numberButton0.Visible = true;
            this.numberButton0.Size = new System.Drawing.Size(50, 50);
            this.numberButton0.Location = new System.Drawing.Point(70, 230);
            this.numberButton0.Text = "0";
            this.Controls.Add(numberButton0);
            this.numberButton0.Click += NumberButton_Click;

            this.equalsButton = new System.Windows.Forms.Button();
            this.equalsButton.Visible = true;
            this.equalsButton.Size = new System.Drawing.Size(50, 50);
            this.equalsButton.Location = new System.Drawing.Point(130, 230);
            this.equalsButton.Text = "=";
            this.Controls.Add(equalsButton);
            this.equalsButton.Click += EqualsButton_Click;

            this.clearButton = new System.Windows.Forms.Button();
            this.clearButton.Visible = true;
            this.clearButton.Size = new System.Drawing.Size(50, 50);
            this.clearButton.Location = new System.Drawing.Point(10, 230);
            this.clearButton.Text = "C";
            this.Controls.Add(clearButton);
            this.clearButton.Click += ClearButton_Click;

            //Title
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
