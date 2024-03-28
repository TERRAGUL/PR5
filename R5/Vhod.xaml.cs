using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
    /// Логика взаимодействия для Vhod.xaml
    /// </summary>
    public partial class Vhod : Window
    {

        private EmployeesTableAdapter EmployeesTable = new EmployeesTableAdapter();
        public Vhod()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextError.Text = "";

            if (Logintxt.Text != "" && Passwordtxt.Password != "")
            {
                //   int auntififi = Convert.ToInt32(EmployeesTable.ScalarQuery(Logintxt.Text, Hach(Passwordtxt.Password)));

                List<MegaHitDataSet.EmployeesRow> auntififi = EmployeesTable.Aunti(Logintxt.Text, Hach(Passwordtxt.Password)).ToList();

                if (auntififi.Count != 0)
                {
                    Admin AdminWindow = new Admin(auntififi);
                    AdminWindow.Show();
                    Close();
                } 
                else              
                {
                    TextError.Text = "Ошибка входа, неверный логин или пароль.";
                }
            }
            else
            {
                TextError.Text = "Пустое поле, введите логин и пароль!";
            }

        }

        public static string Hach(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
