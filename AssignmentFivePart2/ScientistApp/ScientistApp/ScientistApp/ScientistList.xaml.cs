using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ScientistApp
{
	[XamlCompilation(XamlCompilationOptions.Skip)]
	public partial class ScientistList : ContentView
	{
        public int tapCount;

        public ScientistList ()
		{
			InitializeComponent ();
		}

        //NEWTON
        async void OnTapNewton(object sender, EventArgs args)
        {
            tapCount++;
            var layoutSender = (AbsoluteLayout)sender;

            if (tapCount % 1 == 0)
            {
                await Navigation.PushAsync(new DetailsPage());

                var information = new Information
                {
                    Name = "Sir Isaac Newton",
                    Image = "albert_einstein.jpg",
                    Year = "1642–1726",
                    Description = "Newton was a polymath who made investigations into a whole range of subjects including mathematics, optics, physics, and astronomy. In his Principia Mathematica, published in 1687, he laid the foundations for classical mechanics, explaining the law of gravity and the laws of motion."
                };

                var detailsPage = new DetailsPage();
                detailsPage.BindingContext = information;
                await Navigation.PushAsync(detailsPage);
            }
        }

    }
}