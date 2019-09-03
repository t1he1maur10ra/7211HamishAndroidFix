using System;
using System.Collections.Generic;
using HamishWadsworthCV.Views;
using HamishWadsworthCV.Models;
using Xamarin.Forms;

namespace HamishWadsworthCV.Extensions
{
    public partial class BottomBtnBar : Grid
    {

        public BottomBtnBar()
        {
            InitializeComponent();
        }

        async void Handle_EnvelopeClicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ContactPage());
        }

        void Handle_GithubClicked(object sender, System.EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.github.com//hamishwaddy/"));
        }

        void Handle_LinkedinClicked(object sender, System.EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.linkedin.com/in/hamishwadsworth/"));
        }
    }
}
