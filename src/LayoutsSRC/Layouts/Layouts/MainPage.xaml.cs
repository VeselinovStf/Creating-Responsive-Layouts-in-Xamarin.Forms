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

        private async void RelativeLayoutDemo_OnButtonClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RelativeLayoutPage());
        }

        private async void StackLayoutDemo_OnButtonClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StackLayoutPage());
        }

        private async void NestedStackDemo_OnButtonClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NestedStackLayouts());
        }

        private async void GridDemo_OnButtonClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GridPage());
        }

        private async void FlexDemo_OnButtonClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FlexLayoutPage());
        }
    }
}
