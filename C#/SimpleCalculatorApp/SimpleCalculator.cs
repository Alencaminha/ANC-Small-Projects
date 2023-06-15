namespace SimpleCalculatorApp
{
    public partial class SimpleCalculator : Form
    {
        double firstNumber = 0, secondNumber = 0, result = 0;
        String operationSign = "";

        public SimpleCalculator()
        {
            InitializeComponent();
        }

        private void numbers_Click(int number)
        {
            if (textBoxOutput.Text == "0" && textBoxOutput.Text != null)
            {
                textBoxOutput.Text = number.ToString();
            }
            else
            {
                textBoxOutput.Text = textBoxOutput.Text + number.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numbers_Click(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numbers_Click(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numbers_Click(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numbers_Click(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            numbers_Click(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            numbers_Click(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            numbers_Click(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            numbers_Click(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            numbers_Click(9);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            numbers_Click(0);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            firstNumber = 0;
            secondNumber = 0;
            operationSign = "";
            textBoxOutput.Text = "0";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBoxOutput.Text);
            operationSign = "+";
            textBoxOutput.Text = "0";
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBoxOutput.Text);
            operationSign = "-";
            textBoxOutput.Text = "0";
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBoxOutput.Text);
            operationSign = "*";
            textBoxOutput.Text = "0";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBoxOutput.Text);
            operationSign = "/";
            textBoxOutput.Text = "0";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            secondNumber = Convert.ToDouble(textBoxOutput.Text);

            if (operationSign.Equals("+"))
            {
                result = (firstNumber + secondNumber);
                textBoxOutput.Text = Convert.ToString(result);
                firstNumber = result;
                operationSign = "";
            }
            else if (operationSign.Equals("-"))
            {
                result = (firstNumber - secondNumber);
                textBoxOutput.Text = Convert.ToString(result);
                firstNumber = result;
                operationSign = "";
            }
            else if (operationSign.Equals("*"))
            {
                result = (firstNumber * secondNumber);
                textBoxOutput.Text = Convert.ToString(result);
                firstNumber = result;
                operationSign = "";
            }
            else if (operationSign.Equals("/"))
            {
                if (secondNumber == 0)
                {
                    textBoxOutput.Text = "ERROR";
                }
                else
                {
                    result = (firstNumber / secondNumber);
                    textBoxOutput.Text = Convert.ToString(result);
                    firstNumber = result;
                    operationSign = "";
                }
            }
        }
    }
}