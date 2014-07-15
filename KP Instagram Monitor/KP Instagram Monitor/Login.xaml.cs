using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO.IsolatedStorage;

namespace KP_Instagram_Monitor
{
    public partial class Login : PhoneApplicationPage
    {
        public Login()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            AuthBrowser.Navigate(new Uri("https://instagram.com/oauth/authorize/?client_id=bb5c1dc1010b4eddb396c2d41792bfdb&redirect_uri=http://instagram.com&response_type=token"));
        }

        void AuthBrowser_Navigated(object sender, NavigationEventArgs e)
        {
            //access token is a Url fragment and these fragments start with '#'
            if (e.Uri.AbsoluteUri.Contains('#'))
            {
                //parse our access token
                if (e.Uri.Fragment.StartsWith("#access_token="))
                {
                    string token = e.Uri.Fragment.Replace("#access_token=", string.Empty);

                    //save our token
                    IsolatedStorageSettings.ApplicationSettings["access_token"] = token;
                    IsolatedStorageSettings.ApplicationSettings.Save();

                    NavigationService.Navigate(new Uri("/Content.xaml", UriKind.Relative));
                }
            }
        }
    }
}