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

namespace demo
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        { string login = t1.Text;
            string pass = t2.Text;
            demoekzEntities d = new demoekzEntities();



            try
            {
                Users users = (Users)d.Users.Where((o) => o.Login == login && o.Password == pass).Single();
                if (users != null)
                {
                    
                        if (users.Role == "Клиент")
                        {

                            kabinet k = new kabinet(users);
                            k.Show();
                            this.Close();
                            return;

                        }
                    if (users.Role == "Администратор")
                    {

                        admin a = new admin(users);
                        a.Show();
                        this.Close();
                        return;

                    }


                }
            }
            catch { MessageBox.Show("Invalid Login or password"); }
        } 
    }

       

                    
                   
                   
                }

            
        
    

