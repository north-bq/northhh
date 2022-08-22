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
using TelekomNevaSvyaz.Entity;
using TelekomNevaSvyaz.Entity.Entitysss;

namespace TelekomNevaSvyaz.Pagess
{
    /// <summary>
    /// Interaction logic for ServicePage.xaml
    /// </summary>
    public partial class ServicePage : Page
    {
        bool IsUpdate = true;
        public ServicePage()
        {
            
            InitializeComponent();
            CbFilt.Items.Add("По  названии услуги");
            CbFilt.Items.Add("По времени выполнения");
            CbFilt.SelectedIndex = 0;
            IsUpdate = true;
            UpdateData();
        }

        private void BtAddClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddPage(new Service()));
        }
        private void UpdateData()
        {
            IEnumerable<Service> services = EfModel.Init().Services
              .Where(s => s.ServiceName.Contains(TbSearch.Text));
            switch (CbFilt.SelectedIndex)
            {
                case 0:
                    services = services.OrderBy(s => s.ServiceName);
                    break;
                case 1:
                    services = services.OrderByDescending(s => s.ServiceDurationInMunutes);
                    break;
            }
            ListView.ItemsSource = services.ToList();
        }

        private void CbSortChange(object sender, SelectionChangedEventArgs e)
        {
            if (IsUpdate)
                UpdateData();
        }

        private void CbFiltChange(object sender, SelectionChangedEventArgs e)
        {
            if (IsUpdate)
                UpdateData();
        }

        private void TbSearchChange(object sender, RoutedEventArgs e)
        {
            if (IsUpdate)
                UpdateData();
        }

        private void BtChangeClick(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            Service service = button.DataContext as Service;
            NavigationService.Navigate(new ChangePage(service));
        }

        private void BtDelete(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            Service service = button.DataContext as Service;
            if (MessageBox.Show("Вы действительно хотите удалить?" + service.ServiceName + "?", "Удаление услуги", MessageBoxButton.YesNo)
                == MessageBoxResult.Yes)
            {
                EfModel.Init().Services.Remove(service);
                EfModel.Init().SaveChanges();
                UpdateData();
            }
        }
    }
    }
