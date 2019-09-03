using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using HamishWadsworthCV.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HamishWadsworthCV
{
    public partial class App : Application
    {
        static Person hamish = new Person();

        public App()
        {
            InitializeComponent();
            BindingContext = hamish;
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
