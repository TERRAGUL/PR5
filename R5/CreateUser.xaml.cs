using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Логика взаимодействия для CreateUser.xaml
    /// </summary>
    public partial class CreateUser : Window
    {


        private static DolzhnoctiTableAdapter dolzhnoctii = new DolzhnoctiTableAdapter();
        private EmployeesTableAdapter employeess = new EmployeesTableAdapter();
        public CreateUser()
        {
            InitializeComponent();

            SotGRD.ItemsSource = employeess.GetData();


            Doldol.ItemsSource = dolzhnoctii.GetData();
            Doldol.DisplayMemberPath = "DolzhnoctiName";
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void Create_Employee(object sender, RoutedEventArgs e)
        {
            try
            {
                employeess.InsertQueru(NameSotr.Text, SurnameSotr.Text, Doldol.SelectedIndex + 1, Convert.ToInt32(SalarySotr.Text), LoginSotr.Text, Vhod.Hach(PasswordSotr.Password));

                SotGRD.ItemsSource = employeess.GetData();
            }
            catch (System.FormatException) { }

        }

        private void Surname_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void NameSotr_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
