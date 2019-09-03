using System;
using System.Collections.Generic;
using HamishWadsworthCV.Models;
using Xamarin.Forms;

namespace HamishWadsworthCV.Views
{
    public partial class ProfilePage : ContentPage
    {
        Person hamish = new Person();

        public ProfilePage()
        {
            InitializeComponent();
            BindingContext = hamish;
        }

        async void Handle_WorkHistoryBtnClicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new WorkHistoryPage());
        }

        void Handle_ProjectsBtnClicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ProjectsPage());
        }


        async void Handle_TestBtnClicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new TestPage());
        }

    }
}
