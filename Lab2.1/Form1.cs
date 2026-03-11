using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InputNumber.Text = Properties.Settings.Default.number.ToString();
        }

        private void ButtonInput_Click(object sender, EventArgs e)
        {
            var number = 0;
            try
            {
                number = int.Parse(this.InputNumber.Text);
                var result = LuckyNumberLogic.CheckLuckyNumbersOutput(number);
                MessageBox.Show(result);
            }
            catch (FormatException)
            {
                return;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.number = InputNumber.Text;
            Properties.Settings.Default.Save();
        }
    }

    public class LuckyNumberLogic
    {
        public static bool IsSixDigit(int number)
        {
            return number >= 100000 && number <= 999999;
        }

        public static string CheckLuckyNumber(int number)
        {
            var digit1 = number / 100000;
            var digit2 = (number / 10000) % 10;
            var digit3 = (number / 1000) % 10;
            var digit4 = (number / 100) % 10;
            var digit5 = (number / 10) % 10;
            var digit6 = number % 10;

            var firstSum = digit1 + digit2 + digit3;
            var secondSum = digit4 + digit5 + digit6;

            if (firstSum == secondSum)
            {
                return "×èñëî ÿâëÿåòñÿ ñ÷àñòëèâûì";
            }
            else
            {
                return "×èñëî íå ÿâëÿåòñÿ ñ÷àñòëèâûì";
            }
        }

        public static string CheckLuckyNumbersOutput(int number)
        {
            var result = "";
            if (!LuckyNumberLogic.IsSixDigit(number))
            {
                result = "×èñëî íå ÿâëÿåòñÿ øåñòèçíà÷íûì";
            }
            else
            {
                result = LuckyNumberLogic.CheckLuckyNumber(number);
            }
            return result;
        }
    }
}
