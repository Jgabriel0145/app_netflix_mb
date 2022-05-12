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
    public partial class Drama : ContentPage
    {
        public Drama()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            btnBreakingBad.Source = ImageSource.FromResource("app_netflix_mb.Poster.breaking_bad.png");
            btnElite.Source = ImageSource.FromResource("app_netflix_mb.Poster.tropa_elite.png");
            btnHalo.Source = ImageSource.FromResource("app_netflix_mb.Poster.halo.png");
            btnSegredosDumbledore.Source = ImageSource.FromResource("app_netflix_mb.Poster.segredos_dumbledore.png");


        }

        private async void btnBreakingBad_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new BreakingBad());
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

        private async void btnElite_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Elite());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message.ToString(), "OK");
            }
        }

        private async void btnHalo_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Halo());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message.ToString(), "OK");
            }
        }
    }
}