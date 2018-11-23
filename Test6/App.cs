using System;
using Xamarin.Forms;

namespace Test6
{
    public class App : Application
    {
        public App()
        {
            MainPage = new ContentPage { Content = new Label {Text = "Hello", VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center }};
        }
    }
}
