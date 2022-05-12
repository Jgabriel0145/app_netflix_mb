﻿using System;
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
    public partial class Aventura : ContentPage
    {
        public Aventura()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("app_netflix_mb.Img.logonet.png");
            btnHomemAranha.Source = ImageSource.FromResource("app_netflix_mb.Poster.homem_aranha.png");
            btnPanteraNegra.Source = ImageSource.FromResource("app_netflix_mb.Poster.pantera_negra.png");
            btnSegredosDumbledore.Source = ImageSource.FromResource("app_netflix_mb.Poster.segredos_dumbledore.png");
            btnSonic.Source = ImageSource.FromResource("app_netflix_mb.Poster.sonic.png");
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

        private async void btnPanteraNegra_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new PanteraNegra());
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

        private async void btnSonic_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Sonic());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message.ToString(), "OK");
            }
        }
    }
}