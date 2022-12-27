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
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if(DbAccess.TryLogin(tbLogin.Text, pbPassword.Password))
            {
                CurrentUser.user = DbAccess.GetUser(tbLogin.Text, pbPassword.Password);
                Window oldWindow = App.Current.MainWindow;
                App.Current.MainWindow = new Windows.AppWindow();
                App.Current.MainWindow.Show();
                oldWindow.Close();
            }
        }
    }
}
