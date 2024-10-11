using System.Drawing.Text;
using System.Text;

namespace Assignment_4._1._2
{
    public partial class Calculator : Form
    {
        //Stringbuilder for the history
        StringBuilder history = new StringBuilder();

        public Calculator()
        {
            InitializeComponent();
            historyGroupBox.Hide();

            //Minute detail - gets rid of border on hide history
            hideHistoryButton.FlatStyle = FlatStyle.Flat;
            hideHistoryButton.FlatAppearance.BorderSize = 0;

        }

        //Variables
        Operations operate = new Operations();
        double num1;
        double num2;
        int textNumber = 1;
        string option;


        #region Buttons

        //characters
        private void oneButton_Click(object sender, EventArgs args)
        {

            txtDisplay.Text += "1";
            textNumber++;

        }
        private void twoButton_Click(Object sender, EventArgs args)
        {
            txtDisplay.Text += "2";
            textNumber++;
        }
        private void threeButton_Click(Object sender, EventArgs args)
        {
            txtDisplay.Text += "3";
            textNumber++;
        }
        private void fourButton_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
            textNumber++;
        }
        private void fiveButton_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
            textNumber++;
        }
        private void sixButton_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
            textNumber++;
        }
        private void sevenButton_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
            textNumber++;
        }
        private void eightButton_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
            textNumber++;
        }
        private void nineButton_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
            textNumber++;
        }
        private void zeroButton_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
            textNumber++;
        }

        //Extras
        private void periodButton_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ".";
            textNumber++;
        }
        private void negativeButton_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "-";
            textNumber++;
        }

        #endregion Buttons


        #region Operations

        //Basic Operations
        private void plusButton_Click(object sender, EventArgs args)
        {
            BasicOperationLogic("+");
        }
        private void subtractButton_Click(object sender, EventArgs e)
        {
            BasicOperationLogic("-");
        }
        private void multiplyButton_Click(object sender, EventArgs e)
        {
            BasicOperationLogic("X");
        }
        private void divideButton_Click(object sender, EventArgs e)
        {
            BasicOperationLogic("÷");
        }

        //Unique Operations and Calculation Logic
        private void percentButton_Click(object sender, EventArgs e)
        {
            UniqueOperationLogic("%");
        }
        private void squareRootButton_Click(object sender, EventArgs e)
        {
            UniqueOperationLogic("√");
        }
        private void squaredButton_Click(object sender, EventArgs e)
        {
            UniqueOperationLogic("^");
        }
        private void fractionButton_Click(object sender, EventArgs e)
        {
            UniqueOperationLogic("1/x");
        }


        //Basic Calculation Logic
        private void equalsButton_Click(object sender, EventArgs e)
        {
            switch (option)
            {
                case "+":
                    num2 = double.Parse(txtDisplay.Text);
                    txtDisplay.Text = operate.Add(num1, num2).ToString();
                    history.Append(num2);
                    LocalReset();
                    break;
                case "-":
                    num2 = double.Parse(txtDisplay.Text);
                    txtDisplay.Text = operate.Subtract(num1, num2).ToString();
                    history.Append(num2);
                    LocalReset();
                    break;
                case "X":
                    num2 = double.Parse(txtDisplay.Text);
                    txtDisplay.Text = operate.Multiply(num1, num2).ToString();
                    history.Append(num2);
                    LocalReset();
                    break;
                case "÷":
                    num2 = double.Parse(txtDisplay.Text);
                    txtDisplay.Text = operate.Divide(num1, num2).ToString();
                    history.Append(num2);
                    LocalReset();
                    break;
            }
        }

        //Operation Methods
        void LocalReset()
        {
            historyList.Items.Add($"{num1} {option} {num2} = {txtDisplay.Text}");
            num2 = 0;
            textNumber = txtDisplay.TextLength;
        }
        void BasicOperationLogic(string character)
        {
            option = character;
            num1 = double.Parse(txtDisplay.Text);
            history.Append(num1);
            textNumber = txtDisplay.TextLength;
            txtDisplay.Clear();
        }
        void UniqueOperationLogic(string character)
        {
            option = character;
            num1 = double.Parse(txtDisplay.Text);
            if (option == "%")
            {
                txtDisplay.Text = operate.Percent(num1).ToString();
                historyList.Items.Add($"{num1} {option} = {txtDisplay.Text}");
            }
            else if (option == "√")
            {
                txtDisplay.Text = operate.SqRoot(num1).ToString();
                historyList.Items.Add($"{option}{num1} = {txtDisplay.Text}");
            }
            else if (option == "^")
            {
                txtDisplay.Text = operate.Square(num1).ToString();
                historyList.Items.Add($"{num1}{option}2 = {txtDisplay.Text}");
            }
            else if (option == "1/x")
            {
                txtDisplay.Text = operate.Fraction(num1).ToString();
                historyList.Items.Add($"1/{num1} = {txtDisplay.Text}");
            }
            textNumber = txtDisplay.TextLength;
            LocalReset();
        }

        #endregion Operations


        #region Extras

        private void clearButton_Click(object sender, EventArgs e) //will reset only the current operation
        {
            txtDisplay.Clear();
            num1 = 0;
            num2 = 0;
            textNumber = 1;
            option = null;
        }
        private void clearEverythingButton_Click(object sender, EventArgs e) //Will clear history as well
        {
            txtDisplay.Clear();
            num1 = 0;
            num2 = 0;
            textNumber = 1;
            option = null;
            historyList.Items.Clear();
        }
        private void historyButton_Click(object sender, EventArgs e)
        {
            historyGroupBox.Show();
        }
        private void hideHistoryButton_Click(object sender, EventArgs e)
        {
            historyGroupBox.Hide();
        }

        #endregion Extras


    }
}
