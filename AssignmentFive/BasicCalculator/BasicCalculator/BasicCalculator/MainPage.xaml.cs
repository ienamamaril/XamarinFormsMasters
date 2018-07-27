using System;
using Xamarin.Forms;

namespace BasicCalculator
{
	public partial class MainPage : ContentPage
	{
        int currentState = 1;        
        double firstNumber, secondNumber;
        string mathOperator;

        public MainPage()
		{
			InitializeComponent();
            OnClearButton(this, null);
        }

        void OnNumberButton(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string pressed = button.Text;

            if (this.calulatedDisplay.Text == "0" || currentState < 0)
            {
                this.calulatedDisplay.Text = "";
                if (currentState < 0)
                    currentState *= -1;
            }

            this.calulatedDisplay.Text += pressed;

            double number;
            if (double.TryParse(this.calulatedDisplay.Text, out number))
            {
                this.calulatedDisplay.Text = number.ToString("N0");
                if (currentState == 1)
                {
                    firstNumber = number;
                }
                else
                {
                    secondNumber = number;
                }
            }
        }

        void OnOperatorButton(object sender, EventArgs e)
        {
            currentState = -2;
            Button button = (Button)sender;
            string pressed = button.Text;
            mathOperator = pressed;
        }

        void OnCalculateButton(object sender, EventArgs e)
        {
            if (currentState == 2)
            {                
                var result = CalculateAnswer(firstNumber, secondNumber, mathOperator);
                this.calulatedDisplay.Text = CalculateAnswer(firstNumber, secondNumber, mathOperator).ToString("N0");
                firstNumber = result;
                currentState = -1;                
            }
        }

        public static double CalculateAnswer(double value1, double value2, string mathOperator)
        {
            double result = 0;

            switch (mathOperator)
            {
                case "÷":
                    result = value1 / value2;
                    break;
                case "×":
                    result = value1 * value2;
                    break;
                case "+":
                    result = value1 + value2;
                    break;
                case "-":
                    result = value1 - value2;
                    break;
            }

            return result;
        }

        void OnClearButton(object sender, EventArgs e)
        {
            firstNumber = 0;
            secondNumber = 0;
            currentState = 1;
            this.calulatedDisplay.Text = "0";
        }
    }
}
