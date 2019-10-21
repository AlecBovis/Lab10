using System;
using Lab10.Views;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab10
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


            Item1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new CommandDemo());

            };
            Item2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new InteractiveDemo());
            };
            Item3.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Operaciones());

            };
            Item4.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new SimpleDemo());
            };
    }
    }
}


