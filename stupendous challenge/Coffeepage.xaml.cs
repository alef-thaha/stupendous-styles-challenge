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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace stupendous_challenge
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Coffeepage : Page
    {
        public Coffeepage()
        {
            this.InitializeComponent();
        }


        private string roast;
        private string sweetner;
        private string cream;
        private void Roast_Click(object sender, RoutedEventArgs e)
        {
            var selected = (MenuFlyoutItem)sender;
            roast = selected.Text;
            result();
        }

        private void Sweetner_Click(object sender, RoutedEventArgs e)
        {
            var selected = (MenuFlyoutItem)sender;
            sweetner = selected.Text;
            result();
        }

        private void Cream_Click(object sender, RoutedEventArgs e)
        {
            var selected = (MenuFlyoutItem)sender;
            cream = selected.Text;
            result();
        }
        private void result()
        {
            if(roast=="None" || string.IsNullOrEmpty(roast))
            {
                resulttextblock.Text = "None";
                return;
            }
            resulttextblock.Text = roast;
            if(cream!="None" && !string.IsNullOrEmpty(cream))
            {
                resulttextblock.Text += " + " + cream;
            }
            if (cream != "None" && !string.IsNullOrEmpty(sweetner))
            {
                resulttextblock.Text += " + " + sweetner;
            }
        }
    }
}
