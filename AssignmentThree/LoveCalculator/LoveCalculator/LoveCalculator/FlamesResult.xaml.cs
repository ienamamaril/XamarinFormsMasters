using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoveCalculator
{
    [XamlCompilation(XamlCompilationOptions.Skip)]
    public partial class FlamesResult : ContentView
	{
        public char letterResult;       

        public FlamesResult ()
		{
			InitializeComponent();
        }

        public void setResult(char letter)
        {
            this.letterResult = letter;
            txtRelationship.Text = LoveCalculator.CalculateResult.ShowRelationshipResult(letterResult);
            txtMeaning.Text = LoveCalculator.CalculateResult.ShowMeaningResult(letterResult);
        }
    }
}