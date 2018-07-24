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
            billEntry.Text = "101"; //TINAMAD NA KASI AKO MAG INPUT =)
        }

        void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            tipPercentage.Text = String.Format("{0:F1}%", e.NewValue);

            if (!string.IsNullOrEmpty(billEntry.Text) && !string.IsNullOrEmpty(billEntry.Text))
            {
                double billAmountValue = Convert.ToDouble(billEntry.Text);
                tipAmount.Text = String.Format(" {0:F2}", billAmountValue * (Convert.ToDouble(String.Format("{0:F1}", e.NewValue)) / 100));
                double totalAmountValue = Convert.ToDouble(billAmountValue + (billAmountValue * (Convert.ToDouble(String.Format("{0:F1}", e.NewValue)) / 100)));
                totalAmount.Text = String.Format(" {0:F2}", totalAmountValue);
            }                
        }

        void OnBtnFifteenClicked(object sender, EventArgs args)
        {
            if (!string.IsNullOrEmpty(billEntry.Text) && !string.IsNullOrEmpty(billEntry.Text))
            {               
                tipSlider.Value = 15;
                double billAmountValue = Convert.ToDouble(billEntry.Text);
                tipAmount.Text = String.Format(" {0:F2}", billAmountValue * 0.15f);
                double totalAmountValue = Convert.ToDouble(billAmountValue + (billAmountValue * 0.15f));
                totalAmount.Text = String.Format(" {0:F2}", totalAmountValue);
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
                tipSlider.Value = 20;
                double billAmountValue = Convert.ToDouble(billEntry.Text);
                tipAmount.Text = String.Format(" {0:F2}", (billAmountValue * 0.20f));
                double totalAmountValue = Convert.ToDouble(billAmountValue + (billAmountValue * 0.20f));
                totalAmount.Text = String.Format(" {0:F2}", (totalAmountValue));
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
                double itip = Convert.ToDouble(tipAmount.Text);
                tipAmount.Text = String.Format(" {0}", Math.Floor(itip));
                double itotal = Convert.ToDouble(totalAmount.Text);
                totalAmount.Text = String.Format(" {0}", Math.Floor(itotal));
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
                double itip = Convert.ToDouble(tipAmount.Text);
                tipAmount.Text = String.Format(" {0}", Math.Ceiling(itip));
                double itotal = Convert.ToDouble(totalAmount.Text);
                totalAmount.Text = String.Format(" {0}", Math.Ceiling(itotal));
            }
            else
            {
                App.Current.MainPage.DisplayAlert("WARNING! ", "Bill amount is required.", "OK");
            }
        }
    }
}
