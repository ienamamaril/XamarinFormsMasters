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
        async void OnTapNewton(object sender, EventArgs args)
        {
            tapCount++;
            var layoutSender = (AbsoluteLayout)sender;

            if (tapCount % 1 == 0)
            {
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

            
        //PASTEUR
        async void OnTapPasteur(object sender, EventArgs args)
        {
            tapCount++;
            var layoutSender = (AbsoluteLayout)sender;
            
            if (tapCount % 1 == 0)
            {                
                var information = new Information
                {
                    Name = "Louis Pasteur",
                    Image = "louis_pasteur.jpg",
                    Year = "1822–1895",
                    Description = "Pasteur contributed greatly towards the advancement of medical sciences developing cures for rabies, anthrax and other infectious diseases. Also invented the process of pasteurisation to make milk safer to drink. He probably saved more lives than any other person."
                };

                var detailsPage = new DetailsPage();
                detailsPage.BindingContext = information;
                await Navigation.PushAsync(detailsPage);
            }            
        }

        //GALILEO
        async void OnTapGalileo(object sender, EventArgs args)
        {
            tapCount++;
            var layoutSender = (AbsoluteLayout)sender;
            
            if (tapCount % 1 == 0)
            {
                var information = new Information
                {
                    Name = "Galileo",
                    Image = "galileo.jpg",
                    Year = "1564–1642",
                    Description = "Creating one of the first modern telescopes, Galileo revolutionised our understanding of the world, successfully proving the Earth revolves around the Sun and not the other way around. His work Two New Sciences laid the groundwork for the science of Kinetics and strength of materials."
                };

                var detailsPage = new DetailsPage();
                detailsPage.BindingContext = information;
                await Navigation.PushAsync(detailsPage);
            }
        }

        //CURIE
        async void OnTapCurie(object sender, EventArgs args)
        {
            tapCount++;
            var layoutSender = (AbsoluteLayout)sender;

            if (tapCount % 1 == 0)
            {
                var information = new Information
                {
                    Name = "Marie Curie",
                    Image = "marie_curie.jpg",
                    Year = "1867–1934",
                    Description = "Polish physicist and chemist. Discovered radiation and helped to apply it in the field of X-ray. She won the Nobel Prize in both Chemistry and Physics."
                };

                var detailsPage = new DetailsPage();
                detailsPage.BindingContext = information;
                await Navigation.PushAsync(detailsPage);
            }
        }

        //EINSTEIN
        async void OnTapEinstein(object sender, EventArgs args)
        {
            tapCount++;
            var layoutSender = (AbsoluteLayout)sender;

            if (tapCount % 1 == 0)
            {
                var information = new Information
                {
                    Name = "Albert Einstein",
                    Image = "albert_einstein.jpg",
                    Year = "1879–1955",
                    Description = "Revolutionised modern physics with his general theory of relativity. He won the Nobel Prize in Physics (1921) for his discovery of the Photoelectric effect, which formed the basis of Quantum Theory."
                };

                var detailsPage = new DetailsPage();
                detailsPage.BindingContext = information;
                await Navigation.PushAsync(detailsPage);
            }
        }

        //DARWIN
        async void OnTapDarwin(object sender, EventArgs args)
        {
            tapCount++;
            var layoutSender = (AbsoluteLayout)sender;

            if (tapCount % 1 == 0)
            {
                var information = new Information
                {
                    Name = "Charles Darwin",
                    Image = "charles_darwin.jpg",
                    Year = "1809–1882",
                    Description = "Darwin developed his theory of evolution against a backdrop of disbelief and scepticism. He collected evidence over 20 years and published his conclusions in On the Origin of Species (1859)."
                };

                var detailsPage = new DetailsPage();
                detailsPage.BindingContext = information;
                await Navigation.PushAsync(detailsPage);
            }
        }

        //HAHN
        async void OnTapHahn(object sender, EventArgs args)
        {
            tapCount++;
            var layoutSender = (AbsoluteLayout)sender;

            if (tapCount % 1 == 0)
            {
                var information = new Information
                {
                    Name = "Otto Hahn",
                    Image = "otto_hahn.jpg",
                    Year = "1879–1968",
                    Description = "Hahn was a German chemist who discovered nuclear fission (1939). He was a pioneering scientist in the field of radiochemistry and discovered radioactive elements and nuclear isomerism (1921). He was awarded the Nobel Prize for Chemistry in 1944."
                };

                var detailsPage = new DetailsPage();
                detailsPage.BindingContext = information;
                await Navigation.PushAsync(detailsPage);
            }
        }

        //TESLA
        async void OnTapTesla(object sender, EventArgs args)
        {
            tapCount++;
            var layoutSender = (AbsoluteLayout)sender;

            if (tapCount % 1 == 0)
            {
                var information = new Information
                {
                    Name = "Nikola Tesla",
                    Image = "nikola_tesla.jpg",
                    Year = "1856–1943",
                    Description = "Tesla worked on electromagnetism and AC current. He is credited with many patents from electricity to radio transmission and played a key role in the development of modern electricity."
                };

                var detailsPage = new DetailsPage();
                detailsPage.BindingContext = information;
                await Navigation.PushAsync(detailsPage);
            }
        }

        //MAXWELL
        async void OnTapMaxwell(object sender, EventArgs args)
        {
            tapCount++;
            var layoutSender = (AbsoluteLayout)sender;

            if (tapCount % 1 == 0)
            {
                var information = new Information
                {
                    Name = "James Clerk Maxwell",
                    Image = "james_clerk_maxwell.jpg",
                    Year = "1831–1879",
                    Description = "Maxwell made great strides in understanding electromagnetism. His research in electricity and kinetics laid the foundation for quantum physics. Einstein said of Maxwell, 'The work of James Clerk Maxwell changed the world forever'."
                };

                var detailsPage = new DetailsPage();
                detailsPage.BindingContext = information;
                await Navigation.PushAsync(detailsPage);
            }
        }
        
        //ARISTOTLE
        async void OnTapAristotle(object sender, EventArgs args)
        {
            tapCount++;
            var layoutSender = (AbsoluteLayout)sender;

            if (tapCount % 1 == 0)
            {
                var information = new Information
                {
                    Name = "Aristotle",
                    Image = "aristotle.jpg",
                    Year = "384 BCE–322 BCE",
                    Description = "A great early Greek scientist who made many types of research in the natural sciences including botany, zoology, physics, astronomy, chemistry, meteorology and geometry."
                };

                var detailsPage = new DetailsPage();
                detailsPage.BindingContext = information;
                await Navigation.PushAsync(detailsPage);
            }
        }
        
    }
}
