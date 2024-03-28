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
using R5.MegaHitDataSetTableAdapters;

namespace R5
{
    /// <summary>
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {


        public Admin(List<MegaHitDataSet.EmployeesRow> InfoForSotr)
        {
            InitializeComponent();

            List<string> list = new List<string>(); 

            if (InfoForSotr[0].DolzhnoctiID == 1)
            {
               list = new List<string>() { "Меню", "Заказы", "Приготовление", "Заказы посетителей", "Чеки" };
                CreateUs.Visibility = Visibility.Hidden; 
            }
            else if (InfoForSotr[0].DolzhnoctiID == 2)
            {
                list = new List<string>() { "Меню", "Способ оплаты", "Заказы", "Посетители", "Заказы посетителей", "Чеки" };
                CreateUs.Visibility = Visibility.Hidden;
            }
            else if (InfoForSotr[0].DolzhnoctiID == 3)
            {
                list = new List<string>() { "Меню", "Способ оплаты", "Заказы", "Повара", "Приготовление", "Посетители", "Заказы посетителей", "Чеки" };
                CreateUs.Visibility = Visibility.Hidden;
            }
            else if (InfoForSotr[0].DolzhnoctiID == 4)
            {
                list = new List<string>() { "Меню", "Способ оплаты", "Должности", "Сотрудники", "Заказы", "Повара", "Приготовление", "Посетители", "Заказы посетителей", "Чеки", "Информация о сотрудниках" };
            }

            CBXTABL.ItemsSource = list; 
        }

        private void OpenTabl_Click(object sender, RoutedEventArgs e)
        {
            Tabl tabl = new Tabl(CBXTABL.Items[CBXTABL.SelectedIndex].ToString());
            tabl.Show();
        }

        private void CBXTABL_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CreateUseraClick(object sender, RoutedEventArgs e)
        {
           CreateUser createUser = new CreateUser();
           createUser.Show();
        }

        private void Exit_Button(object sender, RoutedEventArgs e)
        {
            Vhod vhod = new Vhod();
            vhod.Show();
            Close();
        }
    }
}
