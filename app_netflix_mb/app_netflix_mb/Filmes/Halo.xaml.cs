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
    public partial class Halo : ContentPage
    {
        public Halo()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("app_netflix_mb.Img.logonet.png");
            poster.Source = ImageSource.FromResource("app_netflix_mb.Poster.halo.png");

            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width='400' height='300'
                src='https://www.youtube.com/watch?v=tiXSIxQNv2U' 
                frameborder='0' 
                allow='accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture'
                allowfullscreen></iframe>";

            vizualizador.Source = htmlSource;
        }
    }
}