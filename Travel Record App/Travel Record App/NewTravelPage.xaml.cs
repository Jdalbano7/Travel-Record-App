using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel_Record_App.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Travel_Record_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewTravelPage : ContentPage
    {
        public NewTravelPage()
        {
            InitializeComponent();
        }

        private void tlbrSave_Clicked(object sender, EventArgs e)
        {
            Post post = new Post()
            {
                Experience = experienceEntry.Text
            };

            SQLiteConnection connection = new SQLiteConnection(App.DatabaseLocation);
            connection.CreateTable<Post>();
            int rows = connection.Insert(post);
            connection.Close();

            if (rows > 0)
                DisplayAlert("Successful post", "Your experience was successfully posted.", "Great!");
            else
                DisplayAlert("Unsuccessful post", "Your experience was not posted", "Okay");
        }
    }
}