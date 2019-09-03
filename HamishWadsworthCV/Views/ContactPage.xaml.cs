using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Essentials;
using System.Collections.Generic;

namespace HamishWadsworthCV.Views
{
    public partial class ContactPage : ContentPage
    {

        public ContactPage()
        {
            InitializeComponent();
            validation_message.IsVisible = false;
        }

        void OnNameChanged(object sender, System.EventArgs e)
        {
            var name = Name.Text;
            if (name.Length > 0 && name.Length < 3)
            {
                NameError.IsVisible = true;
                string errorMsg = "Please enter at least 3 characters.";
                NameError.Text = errorMsg;
            }
            else
                NameError.IsVisible = false;
        }

        void OnPhoneNumberChanged(object sender, System.EventArgs e)
        {
            var phoneNum = PhoneNumber.Text;
            if (phoneNum.Length > 0 && phoneNum.Length < 9)
            {
                PhoneNumError.IsVisible = true;
                string errorMsg = "Please enter a valid phone number.";
                PhoneNumError.Text = errorMsg;
            }
            else
                PhoneNumError.IsVisible = false;
        }

        void OnEmailChanged(object sender, System.EventArgs e)
        {
            var email = EmailAddress.Text;
            if (email.Length < 1)
            {
                EmailError.IsVisible = true;
                string errorMsg = "Please enter a valid email.";
                EmailError.Text = errorMsg;
            }
            else
                EmailError.IsVisible = false;
        }

        void OnMessageChanged(object sender, System.EventArgs e)
        {
            var message = Message.Text;
            if (message.Length > 0 && message.Length < 10)
            {
                MessageError.IsVisible = true;
                string errorMsg = "Message must be at least 10 characters.";
                MessageError.Text = errorMsg;
            }
            else
                MessageError.IsVisible = false;

        }

        async void Handle_SubmitClicked(object sender, System.EventArgs e)
        {
            if (Name.Text.Length > 3 &&
                PhoneNumber.Text.Length > 8 &&
                EmailAddress.Text.Length > 0 &&
                Message.Text.Length > 9)
            {
                Info_Message.Text = "Message successfully sent.";
                validation_message.IsVisible = true;
                await Task.Delay(2000);
                validation_message.IsVisible = false;
            }
            else
            {
                Info_Message.Text = "All fields required.";
                validation_message.IsVisible = true;
                await Task.Delay(2000);
                validation_message.IsVisible = false;
            }

            try
            {
                List<string> recipients = new List<string> { EmailAddress.Text };
                var message = new EmailMessage
                {
                    Subject = Name.Text + " " + PhoneNumber.Text,
                    Body = Message.Text,
                    To = recipients
                    //Cc = ccRecipients,
                    //Bcc = bccRecipients
                };
                await Email.ComposeAsync(message);
            }
            catch (FeatureNotSupportedException fbsEx)
            {
                // Email is not supported on this device
            }

        }

    }
}