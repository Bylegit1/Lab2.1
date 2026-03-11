namespace Lab2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            var number = 0;
            try
            {
                number = int.Parse(this.inputNumber.Text);
                MessageBox.Show(LuckyNumberLogic.checkLuckyNumbersOutput(number));
            }
            catch(FormatException) {
                return;
            }
        }
    }

    public class LuckyNumberLogic
    {
        public static bool isSixDigit(int number)
        {
            return number >= 100000 && number <= 999999;
        }

        public static string checkLuckyNumber(int number)
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

        public static string checkLuckyNumbersOutput(int number)
        {
            var result = "";
            if (!LuckyNumberLogic.isSixDigit(number))
            {
                result = "×èñëî íå ÿâëÿåòñÿ øåñòèçíà÷íûì";
            }
            else
            {
                result = LuckyNumberLogic.checkLuckyNumber(number);
            }
            return result;
        }
    }
}
