using System;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;

namespace Note_a_rious
{
    public partial class DetailsPage : PhoneApplicationPage
    {
        private Storage storage = new Storage();
        // Constructor
        public DetailsPage()
        {
            InitializeComponent();
        }

        // When page is navigated to set data context to selected item in list
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            //string selectedIndex = "";
            //if (NavigationContext.QueryString.TryGetValue("selectedItem", out selectedIndex))
            //{
            //   int index = int.Parse(selectedIndex);
            //  DataContext = App.ViewModel.Items[index];
            // }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            storage.Save(textBox1.Text);
        }

    }
}