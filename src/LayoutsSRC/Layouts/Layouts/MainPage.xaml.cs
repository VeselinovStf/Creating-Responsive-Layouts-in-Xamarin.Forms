using Layouts.Demos;
using System;
using Xamarin.Forms;

namespace Layouts
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ScrollViewAndDemo_OnButtonClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ScrollAndFrameDemoPage());
        }
    }
}
