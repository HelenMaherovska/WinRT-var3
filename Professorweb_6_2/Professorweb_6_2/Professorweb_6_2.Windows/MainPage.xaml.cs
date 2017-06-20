﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Professorweb_6_2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            if(help.Info != null)
            {
                txt.Text = help.Info.ToString();
            }

            
            // NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
            //help h = new help();

        }
        int k = 0;
        protected override void OnNavigatedTo(Windows.UI.Xaml.Navigation.NavigationEventArgs e)
        {
            forwardBtn.IsEnabled = this.Frame.CanGoForward;
            backBtn.IsEnabled = this.Frame.CanGoBack;
            
        }
        private void SecondPageButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SecondPage));
        }
        private void ForwardBtn_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoForward();
        }
        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }

        private void r2(object sender, RoutedEventArgs e)
        {
            txt.Background = new SolidColorBrush(Colors.Red);

        }

        private void r1(object sender, RoutedEventArgs e)
        {
            txt.Background = new SolidColorBrush(Colors.Green);
        }

        private void txt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
