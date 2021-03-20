using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace stupendous_challenge
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            myframe.Navigate(typeof(donutpage));
        }

        private void donutbutton_Click(object sender, RoutedEventArgs e)
        {
            myframe.Navigate(typeof(donutpage));
        }

        private void coffeebutton_Click(object sender, RoutedEventArgs e)
        {
            myframe.Navigate(typeof(Coffeepage));
        }

        private void shedulebutton_Click(object sender, RoutedEventArgs e)
        {
            myframe.Navigate(typeof(shedulepage));
        }

        private void completebutton_Click(object sender, RoutedEventArgs e)
        {
            myframe.Navigate(typeof(completepage));
        }
    }
}
