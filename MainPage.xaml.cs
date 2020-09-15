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

namespace HamburgerPractice
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            LoadUp();
           
        }

        private void MainIconButton_Click(object sender, RoutedEventArgs e)
        {           
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FinancialItem.IsSelected)
            {
                
                BackButton.Visibility = Visibility.Collapsed;
                TitleTextBlock.Text = "Financial";
                MyFrame.Navigate(typeof(Financial));
            }
            else if(FoodItem.IsSelected) {

                TitleTextBlock.Text = "Food";
                BackButton.Visibility = Visibility.Visible;
                MyFrame.Navigate(typeof(Food));

            }

           
        }

        private void LoadUp() {
            FinancialItem.IsSelected = true;
            TitleTextBlock.Text = "Financial";
            MyFrame.Navigate(typeof(Financial));
           

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (MyFrame.CanGoBack) {

                MyFrame.GoBack();
                FinancialItem.IsSelected = true;
            }
        }
    }
}
