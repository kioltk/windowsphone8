using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using wp8.Helper;
using System.Windows.Media;
namespace wp8.Helper
{

    public enum Resolutions { WVGA, WXGA, HD };

    public static class ResolutionHelper
    {
        private static bool IsWvga
        {
            get
            {
                return App.Current.Host.Content.ScaleFactor == 100;
            }
        }

        private static bool IsWxga
        {
            get
            {
                return App.Current.Host.Content.ScaleFactor == 160;
            }
        }

        private static bool IsHD
        {
            get
            {
                return App.Current.Host.Content.ScaleFactor == 150;
            }
        }

        public static Resolutions CurrentResolution
        {
            get
            {
                if (IsWvga) return Resolutions.WVGA;
                else if (IsWxga) return Resolutions.WXGA;
                else if (IsHD) return Resolutions.HD;
                else throw new InvalidOperationException("Unknown resolution");
            }
        }
    }
    public static class ThemeHelper
    {
        public static void SetLightTheme()
        {
          //  ((SolidColorBrush)Resources["PhoneRadioCheckBoxCheckBrush"]).Color = ((SolidColorBrush)Resources["PhoneRadioCheckBoxBorderBrush"]).Color = ((SolidColorBrush)Resources["PhoneForegroundBrush"]).Color = Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);
            
            
            
        }
    }
    public class ResourceImage
    {
        public static string Get(string name)
        {

            switch (ResolutionHelper.CurrentResolution)
            {
           /*     case Resolutions.HD:
                    return new Uri("Assets/" + name + ".screen-720p.jpg", UriKind.Relative);
                case Resolutions.WXGA:
                    return new Uri("Assets/" + name + ".screen-wxga.jpg", UriKind.Relative);
                case Resolutions.WVGA:
                    return new Uri("Assets/" + name + ".screen-wvga.jpg", UriKind.Relative);
             */ 
                default:
                    return "/Assets/" + name + ".png";
            }
        }

    }
}
