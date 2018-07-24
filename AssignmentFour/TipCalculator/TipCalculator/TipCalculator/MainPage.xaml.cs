using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }



        void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {

            tipPercentage.Text = String.Format("{0:F1}%", e.NewValue);
            tipAmount.Text = "0.00";
        }

        void OnBtnFifteenClicked(object sender, EventArgs args)
        {
            if (!string.IsNullOrEmpty(billEntry.Text) && !string.IsNullOrEmpty(billEntry.Text))
            {

            }
            else
            {
                App.Current.MainPage.DisplayAlert("WARNING! ", "Bill amount is required.", "OK");


            }
        }

        void OnBtnTwentyClicked(object sender, EventArgs args)
        {
            if (!string.IsNullOrEmpty(billEntry.Text) && !string.IsNullOrEmpty(billEntry.Text))
            {

            }
            else
            {
                App.Current.MainPage.DisplayAlert("WARNING! ", "Bill amount is required.", "OK");


            }
        }

        void OnBtnRoundDownClicked(object sender, EventArgs args)
        {
            if (!string.IsNullOrEmpty(billEntry.Text) && !string.IsNullOrEmpty(billEntry.Text))
            {

            }
            else
            {
                App.Current.MainPage.DisplayAlert("WARNING! ", "Bill amount is required.", "OK");


            }
        }

        void OnBtnRoundUpClicked(object sender, EventArgs args)
        {
            if (!string.IsNullOrEmpty(billEntry.Text) && !string.IsNullOrEmpty(billEntry.Text))
            {

            }
            else
            {
                App.Current.MainPage.DisplayAlert("WARNING! ", "Bill amount is required.", "OK");


            }
        }
    }
}
