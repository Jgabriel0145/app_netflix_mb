using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using app_netflix_mb.Categorias;

namespace app_netflix_mb
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            logo.Source = ImageSource.FromResource("app_netflix_mb.Img.logonet.png");
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Btn_Open_Aventura(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Aventura());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message.ToString(), "OK");
            }
        }

        private async void Btn_Open_Animacao(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Animacao());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message.ToString(), "OK");
            }
        }

        private async void Btn_Open_Drama(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Drama());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message.ToString(), "OK");
            }
        }

        private async void Btn_Open_Fantasia(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Fantasia());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message.ToString(), "OK");
            }
        }
    }
}
