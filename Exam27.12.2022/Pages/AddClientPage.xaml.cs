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
    /// Логика взаимодействия для AddClientPage.xaml
    /// </summary>
    public partial class AddClientPage : Page
    {
        public Client Client { get; set; }
        public AddClientPage()
        {
            InitializeComponent();
            Client= new Client();
            DataContext = Client;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            DbAccess.SaveClient(Client);
        }
    }
}
