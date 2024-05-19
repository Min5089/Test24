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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        VarEntities DB = new VarEntities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();

            user.Id= 2;
            user.Name = TextLogin.Text;
            user.Password = TextPassword.Text;

            DB.User.Add(user);
            DB.SaveChanges();

             
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            new Regml().Show();
            this.Close();

        }
    }
}
