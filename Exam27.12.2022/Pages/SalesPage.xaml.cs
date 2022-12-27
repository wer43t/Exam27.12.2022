using ExamCore;
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
    /// Логика взаимодействия для SalesPage.xaml
    /// </summary>
    public partial class SalesPage : Page
    {
        public List<Client> Clients { get; set; }
        public List<Phone> Phones { get; set; }

        public List<Phone> RequestPhones { get; set; }
        public SalesPage()
        {
            InitializeComponent();
            Clients = DbAccess.GetClients();
            Phones = DbAccess.GetPhones();
            RequestPhones = new List<Phone>();
            DataContext = this;
        }

        private void cbPhones_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RequestPhones.Add(cbPhones.SelectedItem as Phone);
            lbRequestPhones.ItemsSource = RequestPhones;
            lbRequestPhones.Items.Refresh();
        }
    }
}
