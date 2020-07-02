using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TP_Twitter.services;
using Xamarin.Forms;


namespace TP_Twitter
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private ITwitterService twitterService = new TwitterService();

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Console.WriteLine("Connexion demandée par l'utilisateur");
            this.HideError();
            String usernameStr = this.username.Text;
            String pwdStr = this.pwd.Text;
            Boolean isRemember = this.rememberme.IsToggled;

            if(string.IsNullOrEmpty(usernameStr) || usernameStr.Length < 3)
            {
                this.DisplayError("Identifiant invalide. 3 caractères minimum");
                return;
            }

            if (string.IsNullOrEmpty(pwdStr) || pwdStr.Length < 5)
            {
                this.DisplayError("Mot de passe invalide. Entre 5 et 10 caractères minimum");
                return;
            }
            if (isRemember == true)
            {
                DisplayAlert("Information", "Vos informations de connexion seront enregistrées localement", "Ok");
            }

            this.ConnexionForm.IsVisible = false;
            this.TweetList.IsVisible = true;
            if (this.twitterService.authenticate(usernameStr, pwdStr))
            {
                this.ConnexionForm.IsVisible = false;
                this.TweetList.IsVisible = true;
            } else
            {
                this.error.Text="Identifiants incorrects";
                this.error.IsVisible = true;

            }

        }

        private void HideError() 
        {
            this.error.IsVisible = false;
        }

        private void DisplayError(string msg)
        {
            this.error.IsVisible = true;
            this.error.Text = msg;
        }

    }
}
