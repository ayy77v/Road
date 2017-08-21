using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Road
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
			NavigationPage.SetHasBackButton(this, false);
			NavigationPage.SetBackButtonTitle(this, "回到首頁");
        }
    }
}
