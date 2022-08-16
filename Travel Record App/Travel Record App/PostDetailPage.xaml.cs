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
    public partial class PostDetailPage : ContentPage
    {
        Post SelectedPost;
        public PostDetailPage(Post selectedPost)
        {
            InitializeComponent();

            SelectedPost = selectedPost;

            experienceEntry.Text = selectedPost.Experience;
        }

        private void btnUpdate_Clicked(object sender, EventArgs e)
        {
            SelectedPost.Experience = experienceEntry.Text;

            using (SQLiteConnection connection = new SQLiteConnection(App.DatabaseLocation))//using statement for IDisposable
            {
                connection.CreateTable<Post>();
                int rows = connection.Update(SelectedPost);

                if (rows > 0)
                    DisplayAlert("Successful update", "Your experience was successfully updated.", "Great!");
                else
                    DisplayAlert("Unsuccessful update", "Your experience was not updated", "Okay");
            }
        }

        private void btnDelete_Clicked(object sender, EventArgs e)
        {
            SelectedPost.Experience = experienceEntry.Text;

            using (SQLiteConnection connection = new SQLiteConnection(App.DatabaseLocation))//using statement for IDisposable
            {
                connection.CreateTable<Post>();
                int rows = connection.Delete(SelectedPost);

                if (rows > 0)
                    DisplayAlert("Successful delete", "Your experience was successfully deleted.", "Great!");
                else
                    DisplayAlert("Unsuccessful delete", "Your experience was not deleted", "Okay");
            }
        }
    }
}