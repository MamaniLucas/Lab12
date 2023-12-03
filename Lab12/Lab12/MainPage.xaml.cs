using Lab12.Models;
using Lab12.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab12
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


            Item1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new View.TaskView());

            };

            List<TaskModels> list = new List<TaskModels>
            {
                new TaskModels{ Title="Monday", Description="¡Listen Friday I'm In Love by The Cure!" },
                new TaskModels{ Title="Thursday", Description="¡Listen Friday I'm In Love by The Cure!"},
                new TaskModels{ Title="Friday", Description="¡Listen Friday I'm In Love by The Cure!"}

            };
            myListView.ItemsSource = list;
        }

       

    }
}
