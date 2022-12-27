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

namespace Exam27._12._2022.Windows
{
    /// <summary>
    /// Логика взаимодействия для AppWindow.xaml
    /// </summary>
    public partial class AppWindow : Window
    {
        public AppWindow()
        {
            InitializeComponent();
            GetUserView();
        }

        private void GetUserView()
        {
            if(CurrentUser.user.idUserType == 1)
            {
                appFrame.NavigationService.Navigate(new Pages.AdminViewPage());
            }
            else if(CurrentUser.user.idUserType == 2)
            {

            }
        }

        private void btnGoBack_Click(object sender, RoutedEventArgs e)
        {
            if (appFrame.NavigationService.CanGoBack)
            {
                appFrame.NavigationService.GoBack();
            }
        }
    }
}
