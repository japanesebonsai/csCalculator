namespace Calculator
{
    
    public partial class Calculator : Form
    {
        const string DIVBYZERO = "Cannot divide by zero";

        private double firstValue = 0;
        private string operation = "";
        private double lastSecondValue = 0;
        private bool repeatEqual = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (lblInput.Text == "0" || string.IsNullOrWhiteSpace(lblInput.Text) || lblHistory.Text.EndsWith("=") || lblInput.Text == DIVBYZERO)
            {
                lblInput.Text = btn.Text;
                if (lblHistory.Text.EndsWith("=")) lblHistory.Text = "";
            }
            else
            {
                lblInput.Text += btn.Text;
            }
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (double.TryParse(lblInput.Text, out firstValue))
            {
                operation = btn.Text;
                lblHistory.Text = $"{firstValue} {operation}";
                lblInput.Text = "0";
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(operation))
            {
                repeatEqual = false;
                return;
            }

            double secondValue;

            if (repeatEqual && !string.IsNullOrEmpty(operation))
            {
                secondValue = lastSecondValue;
            }
            else if (double.TryParse(lblInput.Text, out secondValue))
            {
                lastSecondValue = secondValue;
            }
            else
            {
                return; 
            }

            double result = 0;

            switch (operation)
            {
                case "+":
                    result = firstValue + secondValue;
                    break;
                case "-":
                    result = firstValue - secondValue;
                    break;
                case "×":
                    result = firstValue * secondValue;
                    break;
                case "/":
                    if (secondValue != 0)
                        result = firstValue / secondValue;
                    else
                    {
                        lblInput.Text = DIVBYZERO;
                        firstValue = 0;
                        lblHistory.Text = "";
                        operation = "";
                        repeatEqual = false;
                        return;
                    }
                    break;
                case "%":
                    result = firstValue % secondValue;
                    break;
                default:
                    lblInput.Text = "exception occurred";
                    return;
            }

            lblHistory.Text = $"{firstValue} {operation} {secondValue} =";
            lblInput.Text = result.ToString();

            firstValue = result;
            repeatEqual = true;
        }

        private void btnFunction_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lblInput.Text, out double value))
            {
                double result = 0;
                Button btn = (Button)sender;

                switch (btn.Text)
                {
                    case "x²":
                        result = value * value;
                        lblHistory.Text = $"sqr({value})";
                        break;
                    case "√x":
                        result = Math.Sqrt(value);
                        lblHistory.Text = $"√({value})";
                        break;
                    case "1/x":
                        if (value != 0)
                        {
                            result = 1 / value;
                            lblHistory.Text = $"1/({value})";
                        }
                        else
                        {
                            lblInput.Text = DIVBYZERO;
                            firstValue = 0;
                            lblHistory.Text = "";
                            operation = "";
                            return;
                        }
                        break;
                    case "+/-":
                        result = -value;
                        lblHistory.Text = $"negate({value})";
                        break;
                }

                lblInput.Text = result.ToString();
                repeatEqual = false;
                operation = "";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            switch (btn.Text)
            {
                case "C":
                    lblInput.Text = "0";
                    lblHistory.Text = "";
                    firstValue = 0;
                    operation = "";
                    break;
                case "CE":
                    lblInput.Text = "0";
                    break;
                case "⌫":
                    if (!string.IsNullOrEmpty(lblInput.Text) && lblInput.Text.Length > 1)
                        lblInput.Text = lblInput.Text.Substring(0, lblInput.Text.Length - 1);
                    else
                        lblInput.Text = "0";
                    break;
            }
        }
    }
}
