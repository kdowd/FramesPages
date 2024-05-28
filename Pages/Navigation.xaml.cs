using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FramesPages.Pages
{
    /// <summary>
    /// Interaction logic for Navigation.xaml
    /// </summary>
    public partial class Navigation : Page
    {
        public Navigation()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var w = Application.Current.MainWindow as MainWindow;
            var clickedElement = sender as MenuItem;
            if (clickedElement != null)
            {
                object headerText = clickedElement.Header;

                switch (headerText)
                {

                    case "_Close":

                        Application.Current.MainWindow.Close();
                        break;
                    case "_Login":
                        w?.AppFrame.Navigate(new Login());
                        break;
                    default: break;
                }
            }


        }
    }
}
