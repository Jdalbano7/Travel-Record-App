using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Travel_Record_App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            bool isEmailEmpty = string.IsNullOrEmpty(entryEmail.Text);
            bool isPasswordEmpty = string.IsNullOrEmpty(entryPassword.Text);

            if(isEmailEmpty || isPasswordEmpty)
            {
                DisplayAlert("Email or Password is Empty", "Please enter a password and email", "Got it");
            }
            else
            {
                Navigation.PushAsync(new HomePage());
            }
        }
    }
}
