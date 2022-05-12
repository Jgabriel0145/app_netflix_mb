using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using app_netflix_mb.Filmes;

namespace app_netflix_mb.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Fantasia : ContentPage
    {
        public Fantasia()
        {
            {
                InitializeComponent();
                NavigationPage.SetHasNavigationBar(this, false);

                logo.Source = ImageSource.FromResource("app_netflix_mb.Img.logonet.png");
                btnHomemAranha.Source = ImageSource.FromResource("app_netflix_mb.Poster.homem_aranha.png");
                btnStrangerThings.Source = ImageSource.FromResource("app_netflix_mb.Poster.stranger_things.png");
                btnSegredosDumbledore.Source = ImageSource.FromResource("app_netflix_mb.Poster.segredos_dumbledore.png");
                btnMaskara.Source = ImageSource.FromResource("app_netflix_mb.Poster.filho_maskara.png");
            }
        }

        private async void btnHomemAranha_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new HomemAranha());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message.ToString(), "OK");
            }
        }

        private async void btnStrangerThings_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new StrangerThings());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message.ToString(), "OK");
            }
        }

        private async void btnSegredosDumbledore_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new SegredosDumbledore());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message.ToString(), "OK");
            }
        }

        private async void btnMaskara_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Maskara());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message.ToString(), "OK");
            }
        }
    }
}