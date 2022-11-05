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
    /// Логика взаимодействия для del_tovar.xaml
    /// </summary>
    public partial class del_tovar : Window
    {
        public del_tovar()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            demoekzEntities db = new demoekzEntities();
            Tovar t = new Tovar();
            bool a = Int32.TryParse(del_tb.Text, out int b);
            if (a)
            {
                var add = del_tb.Text;
                var ad = db.Tovar.Single(o => o.Kod == add);
                if (t != null)
                {
                    db.Tovar.Remove(ad);
                    this.Close();
                }
            }
            else { MessageBox.Show("Ошибка"); }
        }
    }
}
