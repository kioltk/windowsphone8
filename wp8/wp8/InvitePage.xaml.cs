using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Windows.Media;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using wp8.Server;
namespace wp8
{
    public partial class InvitePage : PhoneApplicationPage
    {
        public InvitePage()
        {
            InitializeComponent();
        }

        private void InviteButtonClick(object sender, RoutedEventArgs e)
        {
            string email = "";
            string type = "";
            email = EmailField.Text;
            type = TypeField.SelectedItem.ToString();
            if (DataBase.IsValidEmail(email))
            {
                PageContent.Visibility = System.Windows.Visibility.Collapsed;
                DataBase.Invite(email, type, InviteRequestCallBack);
                ResponseLoading.Visibility = System.Windows.Visibility.Visible;
                ResponseGrid.Visibility = System.Windows.Visibility.Visible;
            }
            else
            {
                InvitePageInfo.Text = "Invalid email";
                InvitePageInfo.Foreground = new SolidColorBrush() { Color = Color.FromArgb(0xFF, 0xCC, 0x00, 0x00) };
            }
        }


        public void InviteRequestCallBack(DataBase.Response result)
        {
            ResponseLoading.Visibility  = System.Windows.Visibility.Collapsed;
            if (result != null)
            {
                if (result.code == 0)
                {
                    TwitterLink.Visibility = System.Windows.Visibility.Visible;
                    if (result.response == "success")
                    {

                        ResponseStatus.Text = "Thank you for trusting us. We would contact you before we start";
                    }
                    else
                    {
                        ResponseStatus.Text = "We already have this email in invite list";
                    }
                }
                else
                {
                    switch (result.code)
                    {
                        case 400:
                            ResponseStatus.Text = "We have an error here, in application :(";
                            break;
                        case 500:
                            ResponseStatus.Text = "We have an error there..";
                            break;

                    }
                }
            }
            else
            {
                ResponseGrid.Visibility = System.Windows.Visibility.Collapsed;
                InvitePageInfo.Text = "Check your internet connection";
                PageContent.Visibility = System.Windows.Visibility.Visible;
            }
            InvitePageInfo.Foreground = new SolidColorBrush() { Color = Color.FromArgb(0xFF, 0xCC, 0x00, 0x00) };

        }
    }

}
