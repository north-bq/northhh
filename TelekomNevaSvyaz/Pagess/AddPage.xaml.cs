using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.IO;
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
    /// Interaction logic for AddPage.xaml
    /// </summary>
    public partial class AddPage : Page
    {
        Service service;
        public AddPage(Service service)
        {
            this.service = service;
            InitializeComponent();
            DataContext = service;
        }

        private void ImageClick(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog { Filter = "All Files|*.*" };
            if (openFile.ShowDialog() == true)
            {
            }
        }

        private void BtAddClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (service.ServiceId == 0)
                EfModel.Init().Services.Add(service);
                EfModel.Init().SaveChanges();
                if (NavigationService.CanGoBack)
                    NavigationService.GoBack();
                NavigationService.Navigate(new ServicePage());
                
            }
            catch (DbEntityValidationException ex)
            {
                MessageBox.Show(String.Join(", ", ex.EntityValidationErrors.Last().ValidationErrors.Select(ve => ve.ErrorMessage)));
            }
        }
    }
}

        
  
