namespace Sci_Calc
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NumberButton1 = new Button();
            NumberButton2 = new Button();
            NumberButton3 = new Button();
            NumberButton4 = new Button();
            NumberButton5 = new Button();
            NumberButton6 = new Button();
            NumberButton7 = new Button();
            NumberButton8 = new Button();
            NumberButton9 = new Button();
            NumberButton0 = new Button();
            DisplayWindow = new TextBox();
            ClearButton = new Button();
            EqualsButton = new Button();
            SubtractionButton = new Button();
            AdditionButton = new Button();
            MultiplicationButton = new Button();
            DivisionButton = new Button();
            SuspendLayout();
            // 
            // NumberButton1
            // 
            NumberButton1.Location = new Point(10, 162);
            NumberButton1.Name = "NumberButton1";
            NumberButton1.Size = new Size(50, 50);
            NumberButton1.TabIndex = 0;
            NumberButton1.Text = "1";
            NumberButton1.UseVisualStyleBackColor = true;
            NumberButton1.Click += NumberButton_Click;
            // 
            // NumberButton2
            // 
            NumberButton2.Location = new Point(66, 162);
            NumberButton2.Name = "NumberButton2";
            NumberButton2.Size = new Size(50, 50);
            NumberButton2.TabIndex = 1;
            NumberButton2.Text = "2";
            NumberButton2.UseVisualStyleBackColor = true;
            NumberButton2.Click += NumberButton_Click;
            // 
            // NumberButton3
            // 
            NumberButton3.Location = new Point(122, 162);
            NumberButton3.Name = "NumberButton3";
            NumberButton3.Size = new Size(50, 50);
            NumberButton3.TabIndex = 2;
            NumberButton3.Text = "3";
            NumberButton3.UseVisualStyleBackColor = true;
            NumberButton3.Click += NumberButton_Click;
            // 
            // NumberButton4
            // 
            NumberButton4.Location = new Point(10, 106);
            NumberButton4.Name = "NumberButton4";
            NumberButton4.Size = new Size(50, 50);
            NumberButton4.TabIndex = 3;
            NumberButton4.Text = "4";
            NumberButton4.UseVisualStyleBackColor = true;
            NumberButton4.Click += NumberButton_Click;
            // 
            // NumberButton5
            // 
            NumberButton5.Location = new Point(66, 106);
            NumberButton5.Name = "NumberButton5";
            NumberButton5.Size = new Size(50, 50);
            NumberButton5.TabIndex = 4;
            NumberButton5.Text = "5";
            NumberButton5.UseVisualStyleBackColor = true;
            NumberButton5.Click += NumberButton_Click;
            // 
            // NumberButton6
            // 
            NumberButton6.Location = new Point(122, 106);
            NumberButton6.Name = "NumberButton6";
            NumberButton6.Size = new Size(50, 50);
            NumberButton6.TabIndex = 5;
            NumberButton6.Text = "6";
            NumberButton6.UseVisualStyleBackColor = true;
            NumberButton6.Click += NumberButton_Click;
            // 
            // NumberButton7
            // 
            NumberButton7.Location = new Point(12, 50);
            NumberButton7.Name = "NumberButton7";
            NumberButton7.Size = new Size(50, 50);
            NumberButton7.TabIndex = 6;
            NumberButton7.Text = "7";
            NumberButton7.UseVisualStyleBackColor = true;
            NumberButton7.Click += NumberButton_Click;
            // 
            // NumberButton8
            // 
            NumberButton8.Location = new Point(66, 50);
            NumberButton8.Name = "NumberButton8";
            NumberButton8.Size = new Size(50, 50);
            NumberButton8.TabIndex = 7;
            NumberButton8.Text = "8";
            NumberButton8.UseVisualStyleBackColor = true;
            NumberButton8.Click += NumberButton_Click;
            // 
            // NumberButton9
            // 
            NumberButton9.Location = new Point(122, 50);
            NumberButton9.Name = "NumberButton9";
            NumberButton9.Size = new Size(50, 50);
            NumberButton9.TabIndex = 8;
            NumberButton9.Text = "9";
            NumberButton9.UseVisualStyleBackColor = true;
            NumberButton9.Click += NumberButton_Click;
            // 
            // NumberButton0
            // 
            NumberButton0.Location = new Point(66, 218);
            NumberButton0.Name = "NumberButton0";
            NumberButton0.Size = new Size(50, 50);
            NumberButton0.TabIndex = 9;
            NumberButton0.Text = "0";
            NumberButton0.UseVisualStyleBackColor = true;
            NumberButton0.Click += NumberButton_Click;
            // 
            // DisplayWindow
            // 
            DisplayWindow.Location = new Point(10, 10);
            DisplayWindow.Name = "DisplayWindow";
            DisplayWindow.ReadOnly = true;
            DisplayWindow.Size = new Size(218, 23);
            DisplayWindow.TabIndex = 10;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(10, 218);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(50, 50);
            ClearButton.TabIndex = 11;
            ClearButton.Text = "C";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // EqualsButton
            // 
            EqualsButton.Location = new Point(122, 218);
            EqualsButton.Name = "EqualsButton";
            EqualsButton.Size = new Size(50, 50);
            EqualsButton.TabIndex = 12;
            EqualsButton.Text = "=";
            EqualsButton.UseVisualStyleBackColor = true;
            EqualsButton.Click += EqualsButton_Click;
            // 
            // SubtractionButton
            // 
            SubtractionButton.Location = new Point(178, 50);
            SubtractionButton.Name = "SubtractionButton";
            SubtractionButton.Size = new Size(50, 50);
            SubtractionButton.TabIndex = 13;
            SubtractionButton.Text = "-";
            SubtractionButton.UseVisualStyleBackColor = true;
            SubtractionButton.Click += OperatorButton_Click;
            // 
            // AdditionButton
            // 
            AdditionButton.Location = new Point(178, 106);
            AdditionButton.Name = "AdditionButton";
            AdditionButton.Size = new Size(50, 50);
            AdditionButton.TabIndex = 14;
            AdditionButton.Text = "+";
            AdditionButton.UseVisualStyleBackColor = true;
            AdditionButton.Click += OperatorButton_Click;
            // 
            // MultiplicationButton
            // 
            MultiplicationButton.Location = new Point(178, 162);
            MultiplicationButton.Name = "MultiplicationButton";
            MultiplicationButton.Size = new Size(50, 50);
            MultiplicationButton.TabIndex = 15;
            MultiplicationButton.Text = "*";
            MultiplicationButton.UseVisualStyleBackColor = true;
            MultiplicationButton.Click += OperatorButton_Click;
            // 
            // DivisionButton
            // 
            DivisionButton.Location = new Point(178, 218);
            DivisionButton.Name = "DivisionButton";
            DivisionButton.Size = new Size(50, 50);
            DivisionButton.TabIndex = 16;
            DivisionButton.Text = "/";
            DivisionButton.UseVisualStyleBackColor = true;
            DivisionButton.Click += OperatorButton_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(240, 280);
            Controls.Add(DivisionButton);
            Controls.Add(MultiplicationButton);
            Controls.Add(AdditionButton);
            Controls.Add(SubtractionButton);
            Controls.Add(EqualsButton);
            Controls.Add(ClearButton);
            Controls.Add(DisplayWindow);
            Controls.Add(NumberButton0);
            Controls.Add(NumberButton9);
            Controls.Add(NumberButton8);
            Controls.Add(NumberButton7);
            Controls.Add(NumberButton6);
            Controls.Add(NumberButton5);
            Controls.Add(NumberButton4);
            Controls.Add(NumberButton3);
            Controls.Add(NumberButton2);
            Controls.Add(NumberButton1);
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button NumberButton1;
        private Button NumberButton2;
        private Button NumberButton3;
        private Button NumberButton4;
        private Button NumberButton5;
        private Button NumberButton6;
        private Button NumberButton7;
        private Button NumberButton8;
        private Button NumberButton9;
        private Button NumberButton0;
        private TextBox DisplayWindow;
        private Button ClearButton;
        private Button EqualsButton;
        private Button SubtractionButton;
        private Button AdditionButton;
        private Button MultiplicationButton;
        private Button DivisionButton;
    }
}