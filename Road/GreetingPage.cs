using System;

using Xamarin.Forms;

namespace Road
{
    public class GreetingsPage : ContentPage
    {
        public GreetingsPage()
        {
            //初始化 XAML
           

            Content = new Label
            {
                Text = "Greetings, Xamarin.Forms!",

				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center
            };

           
        }
    };
}


