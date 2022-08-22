using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace TelekomNevaSvyaz.Pagess
{
    /// <summary>
    /// Interaction logic for AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void BtAdmin(object sender, RoutedEventArgs e)
        {
            if (TbAdminCode.Password == "2222")
            {
                NavigationService.Navigate(new ServicePage());
            }

            else
            {
                MessageBox.Show("Код неверный");
            }
        }
    }
}
