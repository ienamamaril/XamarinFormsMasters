using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ScientistApp
{
	public partial class MainPage : ContentPage
	{
        public int tapCount;

		public MainPage()
		{
			InitializeComponent();
        }

        //NEWTON
        void OnTapNewton(object sender, EventArgs args)
        {
            tapCount++;
            var layoutSender = (AbsoluteLayout)sender;            

            if (tapCount % 1 == 0)
            {                
                DisplayAlert("Alert", "You have been Newton", "OK");
            }
            else
            {
                DisplayAlert("HOY", "You have been Newton", "CANCEL");
            }
        }

        //PASTEUR
        void OnTapPasteur(object sender, EventArgs args)
        {
            tapCount++;
            var layoutSender = (AbsoluteLayout)sender;
            
            if (tapCount % 1 == 0)
            {                
                DisplayAlert("Alert", "You have been Pasteur", "OK");
            }
            else
            {                
                DisplayAlert("HOY", "You have been Pasteur", "CANCEL");
            }
        }

        //GALILEO
        void OnTapGalileo(object sender, EventArgs args)
        {
            tapCount++;
            var layoutSender = (AbsoluteLayout)sender;
            
            if (tapCount % 1 == 0)
            {
                DisplayAlert("Alert", "You have been Galileo", "OK");
            }
            else
            {
                DisplayAlert("HOY", "You have been Galileo", "CANCEL");
            }
        }

        //CURIE
        void OnTapCurie(object sender, EventArgs args)
        {
            tapCount++;
            var layoutSender = (AbsoluteLayout)sender;

            if (tapCount % 1 == 0)
            {
                DisplayAlert("Alert", "You have been Curie", "OK");
            }
            else
            {
                DisplayAlert("HOY", "You have been Curie", "CANCEL");
            }
        }

        //EINSTEIN
        void OnTapEinstein(object sender, EventArgs args)
        {
            tapCount++;
            var layoutSender = (AbsoluteLayout)sender;

            if (tapCount % 1 == 0)
            {
                DisplayAlert("Alert", "You have been Einstein", "OK");
            }
            else
            {
                DisplayAlert("HOY", "You have been Einstein", "CANCEL");
            }
        }

        //DARWIN
        void OnTapDarwin(object sender, EventArgs args)
        {
            tapCount++;
            var layoutSender = (AbsoluteLayout)sender;

            if (tapCount % 1 == 0)
            {
                DisplayAlert("Alert", "You have been Darwin", "OK");
            }
            else
            {
                DisplayAlert("HOY", "You have been Darwin", "CANCEL");
            }
        }

        //HAHN
        void OnTapHahn(object sender, EventArgs args)
        {
            tapCount++;
            var layoutSender = (AbsoluteLayout)sender;

            if (tapCount % 1 == 0)
            {
                DisplayAlert("Alert", "You have been Hahn", "OK");
            }
            else
            {
                DisplayAlert("HOY", "You have been Hahn", "CANCEL");
            }
        }

        //TESLA
        void OnTapTesla(object sender, EventArgs args)
        {
            tapCount++;
            var layoutSender = (AbsoluteLayout)sender;

            if (tapCount % 1 == 0)
            {
                DisplayAlert("Alert", "You have been Tesla", "OK");
            }
            else
            {
                DisplayAlert("HOY", "You have been Tesla", "CANCEL");
            }
        }

        //MAXWELL
        void OnTapMaxwell(object sender, EventArgs args)
        {
            tapCount++;
            var layoutSender = (AbsoluteLayout)sender;

            if (tapCount % 1 == 0)
            {
                DisplayAlert("Alert", "You have been Mawell", "OK");
            }
            else
            {
                DisplayAlert("HOY", "You have been Mawell", "CANCEL");
            }
        }

        //ARISTOTLE
        void OnTapAristotle(object sender, EventArgs args)
        {
            tapCount++;
            var layoutSender = (AbsoluteLayout)sender;

            if (tapCount % 1 == 0)
            {
                DisplayAlert("Alert", "You have been Aristotle", "OK");
            }
            else
            {
                DisplayAlert("HOY", "You have been Aristotle", "CANCEL");
            }
        }
    }
}
