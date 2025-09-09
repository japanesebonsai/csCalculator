
namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            lblInput = new Label();
            btnModulo = new Button();
            btnCE = new Button();
            btnC = new Button();
            btnBackspace = new Button();
            btnFraction = new Button();
            btnSquare = new Button();
            btnSquareRoot = new Button();
            btnSign = new Button();
            btnDivide = new Button();
            btnMultiply = new Button();
            btnMinus = new Button();
            btnPlus = new Button();
            btnEqual = new Button();
            btnDecimalPoint = new Button();
            btn0 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            lblHistory = new Label();
            SuspendLayout();
            // 
            // lblInput
            // 
            lblInput.BackColor = Color.White;
            lblInput.BorderStyle = BorderStyle.FixedSingle;
            lblInput.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblInput.Location = new Point(16, 40);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(397, 70);
            lblInput.TabIndex = 1;
            lblInput.Text = "0";
            lblInput.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnModulo
            // 
            btnModulo.Location = new Point(16, 189);
            btnModulo.Name = "btnModulo";
            btnModulo.Size = new Size(95, 65);
            btnModulo.TabIndex = 1;
            btnModulo.Text = "%";
            btnModulo.UseVisualStyleBackColor = true;
            btnModulo.Click += btnOperation_Click;
            // 
            // btnCE
            // 
            btnCE.Location = new Point(116, 189);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(95, 65);
            btnCE.TabIndex = 10;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            btnCE.Click += btnClear_Click;
            // 
            // btnC
            // 
            btnC.Location = new Point(217, 189);
            btnC.Name = "btnC";
            btnC.Size = new Size(95, 65);
            btnC.TabIndex = 11;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnClear_Click;
            // 
            // btnBackspace
            // 
            btnBackspace.Location = new Point(318, 189);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(95, 65);
            btnBackspace.TabIndex = 13;
            btnBackspace.Text = "⌫";
            btnBackspace.UseVisualStyleBackColor = true;
            btnBackspace.Click += btnClear_Click;
            // 
            // btnFraction
            // 
            btnFraction.Location = new Point(16, 260);
            btnFraction.Name = "btnFraction";
            btnFraction.Size = new Size(95, 65);
            btnFraction.TabIndex = 12;
            btnFraction.Text = "1/x";
            btnFraction.UseVisualStyleBackColor = true;
            btnFraction.Click += btnFunction_Click;
            // 
            // btnSquare
            // 
            btnSquare.Location = new Point(116, 260);
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new Size(95, 65);
            btnSquare.TabIndex = 14;
            btnSquare.Text = "x²";
            btnSquare.UseVisualStyleBackColor = true;
            btnSquare.Click += btnFunction_Click;
            // 
            // btnSquareRoot
            // 
            btnSquareRoot.Location = new Point(217, 260);
            btnSquareRoot.Name = "btnSquareRoot";
            btnSquareRoot.Size = new Size(95, 65);
            btnSquareRoot.TabIndex = 15;
            btnSquareRoot.Text = "√x";
            btnSquareRoot.UseVisualStyleBackColor = true;
            btnSquareRoot.Click += btnFunction_Click;
            // 
            // btnSign
            // 
            btnSign.Location = new Point(16, 544);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(95, 65);
            btnSign.TabIndex = 29;
            btnSign.Text = "+/-";
            btnSign.UseVisualStyleBackColor = true;
            btnSign.Click += btnFunction_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(318, 260);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(95, 65);
            btnDivide.TabIndex = 16;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnOperation_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(318, 331);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(95, 65);
            btnMultiply.TabIndex = 20;
            btnMultiply.Text = "×";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnOperation_Click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(318, 402);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(95, 65);
            btnMinus.TabIndex = 25;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnOperation_Click;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(318, 473);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(95, 65);
            btnPlus.TabIndex = 28;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnOperation_Click;
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(318, 544);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(95, 65);
            btnEqual.TabIndex = 32;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnDecimalPoint
            // 
            btnDecimalPoint.Location = new Point(217, 544);
            btnDecimalPoint.Name = "btnDecimalPoint";
            btnDecimalPoint.Size = new Size(95, 65);
            btnDecimalPoint.TabIndex = 31;
            btnDecimalPoint.Text = ".";
            btnDecimalPoint.UseVisualStyleBackColor = true;
            btnDecimalPoint.Click += btnNumber_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(116, 544);
            btn0.Name = "btn0";
            btn0.Size = new Size(95, 65);
            btn0.TabIndex = 30;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btnNumber_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(16, 473);
            btn1.Name = "btn1";
            btn1.Size = new Size(95, 65);
            btn1.TabIndex = 24;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnNumber_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(117, 473);
            btn2.Name = "btn2";
            btn2.Size = new Size(95, 65);
            btn2.TabIndex = 26;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnNumber_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(217, 473);
            btn3.Name = "btn3";
            btn3.Size = new Size(95, 65);
            btn3.TabIndex = 27;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnNumber_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(16, 402);
            btn4.Name = "btn4";
            btn4.Size = new Size(95, 65);
            btn4.TabIndex = 21;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btnNumber_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(116, 402);
            btn5.Name = "btn5";
            btn5.Size = new Size(95, 65);
            btn5.TabIndex = 22;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btnNumber_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(217, 402);
            btn6.Name = "btn6";
            btn6.Size = new Size(95, 65);
            btn6.TabIndex = 23;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnNumber_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(16, 331);
            btn7.Name = "btn7";
            btn7.Size = new Size(95, 65);
            btn7.TabIndex = 17;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btnNumber_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(116, 331);
            btn8.Name = "btn8";
            btn8.Size = new Size(95, 65);
            btn8.TabIndex = 18;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btnNumber_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(217, 331);
            btn9.Name = "btn9";
            btn9.Size = new Size(95, 65);
            btn9.TabIndex = 19;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btnNumber_Click;
            // 
            // lblHistory
            // 
            lblHistory.Font = new Font("Segoe UI", 12F);
            lblHistory.ForeColor = Color.Gray;
            lblHistory.Location = new Point(16, 10);
            lblHistory.Name = "lblHistory";
            lblHistory.Size = new Size(397, 25);
            lblHistory.TabIndex = 0;
            lblHistory.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 623);
            Controls.Add(lblHistory);
            Controls.Add(lblInput);
            Controls.Add(btnEqual);
            Controls.Add(btnDecimalPoint);
            Controls.Add(btn0);
            Controls.Add(btnSign);
            Controls.Add(btnPlus);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btnMinus);
            Controls.Add(btn1);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnMultiply);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnDivide);
            Controls.Add(btnSquareRoot);
            Controls.Add(btnSquare);
            Controls.Add(btnBackspace);
            Controls.Add(btnFraction);
            Controls.Add(btnC);
            Controls.Add(btnCE);
            Controls.Add(btnModulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
        }



        #endregion
        private Button btnModulo;
        private Button btnCE;
        private Button btnC;
        private Button btnBackspace;

        private Button btnFraction;
        private Button btnSquare;
        private Button btnSquareRoot;
        private Button btnSign;

        private Button btnDivide;
        private Button btnMultiply;
        private Button btnMinus;
        private Button btnPlus;
        private Button btnEqual;
        private Button btnDecimalPoint;

        private Button btn0;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;

        private Label lblInput;
        private Label lblHistory;
    }
}
