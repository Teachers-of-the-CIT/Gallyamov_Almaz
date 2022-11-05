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
    /// Логика взаимодействия для admin.xaml
    /// </summary>
    public partial class admin : Window
    {
        demoekzEntities db = new demoekzEntities();
        private Users _u;
        public admin(object user)
        {
            InitializeComponent();
            _u = user as Users;
            FIO_label.Content = _u.FIO;
            var q = from Tovar in db.Tovar select Tovar;
            table1.ItemsSource = q.ToList();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            this.Close();
        }

        private void Exit_Copy_Click(object sender, RoutedEventArgs e)
        {
            if (c1.SelectedItem == null || c1.SelectedItem.ToString() == "По возрастанию цены")
            {
                var q = from Tovar in db.Tovar where Tovar.Name == Search_tb.Text select Tovar;
                table1.ItemsSource = q.ToList().OrderBy(o => o.Price);
            }
            else if (c1.SelectedItem.ToString() == "По убыванию цены")
            {
                var q = from Tovar in db.Tovar where Tovar.Name == Search_tb.Text select Tovar;
                table1.ItemsSource = q.ToList().OrderByDescending(o => o.Price);
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            del_tovar d = new del_tovar();
            d.Show();
        }
    }
}
