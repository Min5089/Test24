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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Regml.xaml
    /// </summary>
    public partial class Regml : Window
    {
        VarEntities DB = new VarEntities();
        public Regml()
        {
            InitializeComponent();
        }

        public bool Avtr(string Login, string Pass)
        {
            var Users = DB.User.ToList();
            foreach (User User in Users)
            {
                if (Login == User.Name & Pass == User.Password)
                {
                    return true;
                }


            }
            return false;
        }
        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            User user =  new User();
            user.Id = 1;
            string Name = "Fe";
            string Password = "1234";
            bool res = Avtr(Name ,Password);

            if ( res == true)
            {
                new MainWindow().Show();
                this.Close();
            }

            //var Users = DB.User.ToList();
            //foreach (User u in Users )
            //{
            //    if (u.Name == user.Name & u.Password == user.Password)
            //    {
            //        new MainWindow().Show();
            //        this.Close();
            //    }
                
            //}
        }
    }
}
