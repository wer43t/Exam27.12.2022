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
using ExamCore;

namespace Exam27._12._2022.Pages
{
    /// <summary>
    /// Логика взаимодействия для AdminViewPage.xaml
    /// </summary>
    public partial class AdminViewPage : Page
    {
        public List<Phone> Phones { get; set; }
        public AdminViewPage()
        {
            InitializeComponent();
            Phones = DbAccess.GetPhones();
            DataContext = this;
        }

        private void btnAddClient_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.AddClientPage());
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            lvPhones.ItemsSource = DbAccess.GetPhones();
        }

        private void btnAddRequest_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.SalesPage());
        }
    }
}
