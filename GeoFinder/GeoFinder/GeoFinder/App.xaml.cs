﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using GeoFinder.View;

namespace GeoFinder
{
    public partial class App : Application
    {
        public App()
        {
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
