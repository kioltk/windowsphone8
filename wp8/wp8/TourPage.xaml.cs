using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Windows.Media;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using wp8.Helper;
namespace wp8
{
    public partial class TourPage : PhoneApplicationPage
    {
        public TourPage()
        {
           InitializeTheme();
            InitializeComponent();
          //  SystemTray.IsVisible = true;
        }
        private void InitializeTheme()
        {
     /*    
            Color redLight = Color.FromArgb(0xFF, 0xF3, 0xAB, 0x9F);
            Color red = Color.FromArgb(0xFF, 0xE8, 0x57, 0x44);
            Color redDark =  Color.FromArgb(0xFF, 0xCC, 0x00, 0x00);

            Color white = Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);
            Color grey = Color.FromArgb(0xFF, 0xDC, 0xDC, 0xDC);
            Color greyDark = Color.FromArgb(0xFF, 0x82, 0x82, 0x82);
            Color black = Color.FromArgb(0xFF, 0x00, 0x00, 0x00);

            string[] backgrounds = { 
                                       "PhoneBackgroundColor","PhoneForegroundColor","PhoneContrastBackgroundColor","PhoneContrastForegroundColor" };
            
            foreach (var background in backgrounds)
            {
                (Resources[background]) = black;
            }

            ((SolidColorBrush)Resources["PhoneRadioCheckBoxCheckBrush"]).Color =
                ((SolidColorBrush)Resources["PhoneRadioCheckBoxBorderBrush"]).Color =
                ((SolidColorBrush)Resources["PhoneForegroundBrush"]).Color = Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneBackgroundBrush"]).Color = Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneContrastForegroundBrush"]).Color = Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneContrastBackgroundBrush"]).Color = Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneDisabledBrush"]).Color = Color.FromArgb(0x66, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneProgressBarBackgroundBrush"]).Color = Color.FromArgb(0x19, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneTextCaretBrush"]).Color = Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneTextBoxBrush"]).Color = Color.FromArgb(0xBF, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneTextBoxForegroundBrush"]).Color = Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneTextBoxEditBackgroundBrush"]).Color = Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneTextBoxReadOnlyBrush"]).Color = Color.FromArgb(0x77, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneSubtleBrush"]).Color = Color.FromArgb(0x99, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneTextBoxSelectionForegroundBrush"]).Color = Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneButtonBasePressedForegroundBrush"]).Color = Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneTextHighContrastBrush"]).Color = Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneTextMidContrastBrush"]).Color = Color.FromArgb(0x99, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneTextLowContrastBrush"]).Color = Color.FromArgb(0x73, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneSemitransparentBrush"]).Color = Color.FromArgb(0xAA, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneChromeBrush"]).Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x1F);

            ((SolidColorBrush)Resources["PhoneInactiveBrush"]).Color = Color.FromArgb(0x33, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneInverseInactiveBrush"]).Color = Color.FromArgb(0xFF, 0xCC, 0xCC, 0xCC);
            ((SolidColorBrush)Resources["PhoneInverseBackgroundBrush"]).Color = Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneBorderBrush"]).Color = Color.FromArgb(0xBF, 0xFF, 0xFF, 0xFF);
            */

        }
        private class TourPageInfo
        {
            public Visibility buttonVisibility
            {
                get;
                set;
            }
            public string header
            {
                get;
                set;
            }
            public string image
            {
                get;
                set;
            }
            public string description
            {
                get;
                set;
            }
            public TourPageInfo()
            {
                buttonVisibility = Visibility.Collapsed;
            }
        }

        private void TourLoaded(object sender, RoutedEventArgs e)
        {
            

           // var firstItem = simplePanoramaItem;
           // firstItem.DataContext = 
            var firstPage = new TourPageInfo()
            {
                header= "Registration",
                image = ResourceImage.Get("client"),
                description = "We just want to know who you are"
            };

            var secondPage = new TourPageInfo()
            {
                header = "Create",
                image = ResourceImage.Get("page"),
                description = "Also we want to know what we can you help with"
            };
            var thirdPage = new TourPageInfo()
            {
                header = "Hire",
                image = ResourceImage.Get("agent"),
                description = "Than our agents will complete your mission, isnt it simple?"
            };
            var firthPage = new TourPageInfo()
            {
                header = "Be first",
                buttonVisibility = System.Windows.Visibility.Visible,
                description = "And we will contact you"
            };
        //    var body = firstItem.Content;
       /*     var secondItem = new PanoramaItem()
            {
                DataContext = new TourPageInfo()
                {
                    header = "Create",
                    image= ResourceImage.Get("page"),
                    description = "Also we want to know what you want"
                }
            };
            */
            var Items = new ObservableCollection<TourPageInfo>();
            Items.Add(firstPage);
            Items.Add(secondPage);
            Items.Add(thirdPage);
            Items.Add(firthPage);
            TourPanorama.ItemsSource = Items;
            


        }

        private void GetInviteButtonClick(object sender, RoutedEventArgs e)
        {
            
            NavigationService.Navigate(new Uri("/InvitePage.xaml", UriKind.Relative));
        
        }
    }
}