using Microsoft.Win32;
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
using TelekomNevaSvyaz.Entity.Entitysss;

namespace TelekomNevaSvyaz.Pagess
{
    /// <summary>
    /// Interaction logic for ChangePage.xaml
    /// </summary>
    public partial class ChangePage : Page
    {
        Service service;
        public ChangePage(Service service)
        {
            this.service = service;
            InitializeComponent();
            DataContext = service;
        }

        private void BtSaveClick(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            Service service = button.DataContext as Service;
            NavigationService.Navigate(new ServicePage());
        }

        private void ImageClick(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog { Filter = "All Files|*.*" };
            if (openFile.ShowDialog() == true)
            {
            }
        }
    }
    }

