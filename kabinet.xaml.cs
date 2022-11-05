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

namespace demo
{
    /// <summary>
    /// Логика взаимодействия для kabinet.xaml
    /// </summary>
    public partial class kabinet : Window
    {
        demoekzEntities db = new demoekzEntities();
        string[] b = { "АА", "ФФ", "ЕЕ" };
        private Users _u;
        public kabinet(object user)
        {
            InitializeComponent();
           
            _u = user as Users;
            FIO_label.Content = _u.FIO;
            var q = from Tovar in db.Tovar select Tovar ;
            table1.ItemsSource = q.ToList();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Exit_Copy_Click(object sender, RoutedEventArgs e)
        {if (Search_tb.Text != null)
            {
                var q = from Tovar in db.Tovar where Tovar.Name == ""+Search_tb.Text+"" select Tovar;
                table1.ItemsSource = q.ToList();
            }
            else
            {
                var q = from Tovar in db.Tovar  select Tovar;
                table1.ItemsSource = q.ToList();
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(c1.SelectedItem==null||c1.SelectedItem.ToString()=="по возрастанию цены")
            {
                var q = from Tovar in db.Tovar where Tovar.Name == Search_tb.Text select Tovar;
                table1.ItemsSource = q.ToList().OrderBy(o=>o.Price);
            }
            else if (c1.SelectedItem.ToString() == "по убыванию цены")
            {
                var q = from Tovar in db.Tovar where Tovar.Name == Search_tb.Text select Tovar;
                table1.ItemsSource = q.ToList().OrderByDescending(o => o.Price);
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {MainWindow m = new MainWindow();
            m.Show();
            this.Close();
        }
    }
}
