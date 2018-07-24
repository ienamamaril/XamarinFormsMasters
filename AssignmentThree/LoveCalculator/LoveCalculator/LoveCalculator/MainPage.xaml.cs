using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoveCalculator
{
    [XamlCompilation(XamlCompilationOptions.Skip)]
    public partial class MainPage : ContentPage
	{
        public char letter;
       

        public MainPage()
		{
            InitializeComponent();            
		}

        void OnButtonClicked(object sender, EventArgs args)
        {           
            if (!string.IsNullOrEmpty(fName.Text) && !string.IsNullOrEmpty(pName.Text))
            {
                int restCharsCount = LoveCalculator.CalculateResult.CalculateFlamesCount(fName.Text.Trim().ToLower(), pName.Text.Trim().ToLower());
                letter = LoveCalculator.CalculateResult.CalculateRelation(restCharsCount);
                flamesResultView.setResult(letter);
                flamesResultView.IsVisible = true;
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Name/s is required! ", "Fields cannot be empty.", "OK");

                if (flamesResultView.IsVisible)
                {
                    flamesResultView.IsVisible = false;
                }
            }
        }
    }
}
