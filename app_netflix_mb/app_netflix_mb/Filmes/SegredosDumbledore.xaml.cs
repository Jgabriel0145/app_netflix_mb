using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace app_netflix_mb.Filmes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SegredosDumbledore : ContentPage
    {
        public SegredosDumbledore()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("app_netflix_mb.Img.logonet.png");
            poster.Source = ImageSource.FromResource("app_netflix_mb.Poster.segredos_dumbledore.png");

            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width='400' height='300'
                src='https://www.youtube.com/watch?v=LcCrLZceCmg' 
                frameborder='0' 
                allow='accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture'
                allowfullscreen></iframe>";

            vizualizador.Source = htmlSource;

        }
    }
}