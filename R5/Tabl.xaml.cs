    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics;
    using System.Globalization;
    using System.Linq;
    using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Documents;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using System.Windows.Shapes;
    using MaterialDesignThemes.Wpf;
    using R5.MegaHitDataSetTableAdapters;
    using static MaterialDesignThemes.Wpf.Theme;

    namespace R5
    {
        /// <summary>
        /// Логика взаимодействия для Tabl.xaml
        /// </summary>
        public partial class Tabl : Window
        {

            EmployeesTableAdapter employeesTableAdapter = new EmployeesTableAdapter();
            MenuTableAdapter menutableadapter = new MenuTableAdapter();
            PaymentMethodsTableAdapter paymentMethodsTableAdapter = new PaymentMethodsTableAdapter();
            DolzhnoctiTableAdapter dolzhnoctiTableAdapter = new DolzhnoctiTableAdapter();
            OrdersTableAdapter ordersTableAdapter = new OrdersTableAdapter();                                                     
            ChefsTableAdapter chefsTableAdapter = new ChefsTableAdapter();
            CookingTableAdapter cookingTableAdapter = new CookingTableAdapter();
            CustomersTableAdapter customersTableAdapter = new CustomersTableAdapter();
            CustomerOrdersTableAdapter customerOrdersTableAdapter = new CustomerOrdersTableAdapter();
            ChecksTableAdapter checksTableAdapter = new ChecksTableAdapter();
            EmployeeInfoTableAdapter employeeInfoTableAdapter = new EmployeeInfoTableAdapter();



            public static string Tab;
            public Tabl(string tablbl)
            {
                InitializeComponent();

                Tab = tablbl;

                switch (Tab)
                {
                    case "Сотрудники":
                        Tablica.ItemsSource = employeesTableAdapter.GetData();

                        TEXTBOX1.SetValue(HintAssist.HintProperty, "Имя");
                        TEXTBOX2.SetValue(HintAssist.HintProperty, "Фамилия");
                        TEXTBOX3.SetValue(HintAssist.HintProperty, "Зарплата");
                        TEXTBOX4.SetValue(HintAssist.HintProperty, "Логин");
                        TEXTBOX5.SetValue(HintAssist.HintProperty, "Пароль");
                        TEXTBOX6.Visibility = Visibility.Hidden;
                        TEXTBOX7.Visibility = Visibility.Hidden;

                        Combobox1.SetValue(HintAssist.HintProperty, "Должность");
                        Combobox2.Visibility = Visibility.Hidden;
                        Combobox3.Visibility = Visibility.Hidden;
                        Combobox4.Visibility = Visibility.Hidden;
                        Combobox5.Visibility = Visibility.Hidden;
                        Combobox6.Visibility = Visibility.Hidden;
                        Combobox7.Visibility = Visibility.Hidden;

                        Combobox1.ItemsSource = dolzhnoctiTableAdapter.GetData();
                        Combobox1.DisplayMemberPath = "DolzhnoctiName";
                        break;
                    case "Меню":
                        Tablica.ItemsSource = menutableadapter.GetData();

                        TEXTBOX1.SetValue(HintAssist.HintProperty, "Название блюда");
                        TEXTBOX2.SetValue(HintAssist.HintProperty, "Цена");
                        TEXTBOX3.Visibility = Visibility.Hidden;
                        TEXTBOX4.Visibility = Visibility.Hidden;
                        TEXTBOX5.Visibility = Visibility.Hidden;
                        TEXTBOX6.Visibility = Visibility.Hidden;
                        TEXTBOX7.Visibility = Visibility.Hidden;

                        Combobox1.Visibility = Visibility.Hidden;
                        Combobox2.Visibility = Visibility.Hidden;
                        Combobox3.Visibility = Visibility.Hidden;
                        Combobox4.Visibility = Visibility.Hidden;
                        Combobox5.Visibility = Visibility.Hidden;
                        Combobox6.Visibility = Visibility.Hidden;
                        Combobox7.Visibility = Visibility.Hidden;

                        break;
                    case "Способ оплаты":
                        Tablica.ItemsSource = paymentMethodsTableAdapter.GetData();

                        TEXTBOX1.SetValue(HintAssist.HintProperty, "Наименование оплаты");
                        TEXTBOX2.Visibility = Visibility.Hidden;
                        TEXTBOX3.Visibility = Visibility.Hidden;
                        TEXTBOX4.Visibility = Visibility.Hidden;
                        TEXTBOX5.Visibility = Visibility.Hidden;
                        TEXTBOX6.Visibility = Visibility.Hidden;
                        TEXTBOX7.Visibility = Visibility.Hidden;

                        Combobox1.Visibility = Visibility.Hidden;
                        Combobox2.Visibility = Visibility.Hidden;
                        Combobox3.Visibility = Visibility.Hidden;
                        Combobox4.Visibility = Visibility.Hidden;
                        Combobox5.Visibility = Visibility.Hidden;
                        Combobox6.Visibility = Visibility.Hidden;
                        Combobox7.Visibility = Visibility.Hidden;


                        break;
                    case "Должности":
                        Tablica.ItemsSource = dolzhnoctiTableAdapter.GetData();

                        TEXTBOX1.SetValue(HintAssist.HintProperty, "Должность");
                        TEXTBOX2.Visibility = Visibility.Hidden;
                        TEXTBOX3.Visibility = Visibility.Hidden;
                        TEXTBOX4.Visibility = Visibility.Hidden;
                        TEXTBOX5.Visibility = Visibility.Hidden;
                        TEXTBOX6.Visibility = Visibility.Hidden;
                        TEXTBOX7.Visibility = Visibility.Hidden;

                        Combobox1.Visibility = Visibility.Hidden;
                        Combobox2.Visibility = Visibility.Hidden;
                        Combobox3.Visibility = Visibility.Hidden;
                        Combobox4.Visibility = Visibility.Hidden;
                        Combobox5.Visibility = Visibility.Hidden;
                        Combobox6.Visibility = Visibility.Hidden;
                        Combobox7.Visibility = Visibility.Hidden;

                        break;
                    case "Заказы":
                        Tablica.ItemsSource = ordersTableAdapter.GetData();

                        TEXTBOX1.SetValue(HintAssist.HintProperty, "Время заказа");
                        TEXTBOX2.SetValue(HintAssist.HintProperty, "Номер стола");
                        TEXTBOX3.Visibility = Visibility.Hidden;
                        TEXTBOX4.Visibility = Visibility.Hidden;
                        TEXTBOX5.Visibility = Visibility.Hidden;
                        TEXTBOX6.Visibility = Visibility.Hidden;
                        TEXTBOX7.Visibility = Visibility.Hidden;

                        Combobox1.SetValue(HintAssist.HintProperty, "Номер должности");
                        Combobox2.SetValue(HintAssist.HintProperty, "Способ оплаты");
                        Combobox3.Visibility = Visibility.Hidden;
                        Combobox4.Visibility = Visibility.Hidden;
                        Combobox5.Visibility = Visibility.Hidden;
                        Combobox6.Visibility = Visibility.Hidden;
                        Combobox7.Visibility = Visibility.Hidden;

                        Combobox1.ItemsSource = ordersTableAdapter.GetData();
                        Combobox1.DisplayMemberPath = "DolzhnoctiID";

                        Combobox2.ItemsSource = paymentMethodsTableAdapter.GetData();
                        Combobox2.DisplayMemberPath = "NamePayment";

                        break;
                    case "Повара":
                        Tablica.ItemsSource = chefsTableAdapter.GetData();

                        TEXTBOX1.SetValue(HintAssist.HintProperty, "Имя");
                        TEXTBOX2.SetValue(HintAssist.HintProperty, "Фамилия");
                        TEXTBOX3.Visibility = Visibility.Hidden;
                        TEXTBOX4.Visibility = Visibility.Hidden;
                        TEXTBOX5.Visibility = Visibility.Hidden;
                        TEXTBOX6.Visibility = Visibility.Hidden;
                        TEXTBOX7.Visibility = Visibility.Hidden;

                        Combobox1.SetValue(HintAssist.HintProperty, "Фамилия сотрудника");
                        Combobox2.Visibility = Visibility.Hidden;
                        Combobox3.Visibility = Visibility.Hidden;
                        Combobox4.Visibility = Visibility.Hidden;
                        Combobox5.Visibility = Visibility.Hidden;
                        Combobox6.Visibility = Visibility.Hidden;
                        Combobox7.Visibility = Visibility.Hidden;

                        Combobox1.ItemsSource = chefsTableAdapter.GetData();
                        Combobox1.DisplayMemberPath = "ChefSurname";

                        break;
                    case "Приготовление":
                        Tablica.ItemsSource = cookingTableAdapter.GetData();

                        TEXTBOX1.SetValue(HintAssist.HintProperty, "Начало приготовления");
                        TEXTBOX2.SetValue(HintAssist.HintProperty, "Конец приготовления");
                        TEXTBOX3.Visibility = Visibility.Hidden;
                        TEXTBOX4.Visibility = Visibility.Hidden;
                        TEXTBOX5.Visibility = Visibility.Hidden;
                        TEXTBOX6.Visibility = Visibility.Hidden;
                        TEXTBOX7.Visibility = Visibility.Hidden;

                        Combobox1.SetValue(HintAssist.HintProperty, "Фамилия повара");
                        Combobox2.SetValue(HintAssist.HintProperty, "Блюдо");
                        Combobox3.Visibility = Visibility.Hidden;
                        Combobox4.Visibility = Visibility.Hidden;
                        Combobox5.Visibility = Visibility.Hidden;
                        Combobox6.Visibility = Visibility.Hidden;
                        Combobox7.Visibility = Visibility.Hidden;

                        Combobox1.ItemsSource = chefsTableAdapter.GetData();
                        Combobox1.DisplayMemberPath = "ChefSurname";

                        Combobox2.ItemsSource = menutableadapter.GetData();
                        Combobox2.DisplayMemberPath = "ItemName";

                        break;
                    case "Посетители":
                        Tablica.ItemsSource = customersTableAdapter.GetData();

                        TEXTBOX1.SetValue(HintAssist.HintProperty, "Имя посетителя");
                        TEXTBOX2.SetValue(HintAssist.HintProperty, "Фамилия посетителя");
                        TEXTBOX3.SetValue(HintAssist.HintProperty, "Отчество посетителя");
                        TEXTBOX4.Visibility = Visibility.Hidden;
                        TEXTBOX5.Visibility = Visibility.Hidden;
                        TEXTBOX6.Visibility = Visibility.Hidden;
                        TEXTBOX7.Visibility = Visibility.Hidden;

                        Combobox1.Visibility = Visibility.Hidden;
                        Combobox2.Visibility = Visibility.Hidden;
                        Combobox3.Visibility = Visibility.Hidden;
                        Combobox4.Visibility = Visibility.Hidden;
                        Combobox5.Visibility = Visibility.Hidden;
                        Combobox6.Visibility = Visibility.Hidden;
                        Combobox7.Visibility = Visibility.Hidden;



                        break;
                    case "Заказы посетителей":
                        Tablica.ItemsSource = customerOrdersTableAdapter.GetData();

                        TEXTBOX1.Visibility = Visibility.Hidden;
                        TEXTBOX2.Visibility = Visibility.Hidden;
                        TEXTBOX3.Visibility = Visibility.Hidden;
                        TEXTBOX4.Visibility = Visibility.Hidden;
                        TEXTBOX5.Visibility = Visibility.Hidden;
                        TEXTBOX6.Visibility = Visibility.Hidden;
                        TEXTBOX7.Visibility = Visibility.Hidden;

                        Combobox1.SetValue(HintAssist.HintProperty, "Фамилия посетителя");
                        Combobox2.SetValue(HintAssist.HintProperty, "Номер заказа");
                        Combobox3.Visibility = Visibility.Hidden;
                        Combobox4.Visibility = Visibility.Hidden;
                        Combobox5.Visibility = Visibility.Hidden;
                        Combobox6.Visibility = Visibility.Hidden;
                        Combobox7.Visibility = Visibility.Hidden;

                        Combobox1.ItemsSource = customersTableAdapter.GetData();
                        Combobox1.DisplayMemberPath = "CustomerSurame";

                        Combobox2.ItemsSource = customerOrdersTableAdapter.GetData();
                        Combobox2.DisplayMemberPath = "OrderID";

                        break;
                    case "Чеки":
                        Tablica.ItemsSource = checksTableAdapter.GetData();

                        TEXTBOX1.SetValue(HintAssist.HintProperty, "Итоговая цена");
                        TEXTBOX2.Visibility = Visibility.Hidden;
                        TEXTBOX3.Visibility = Visibility.Hidden;
                        TEXTBOX4.Visibility = Visibility.Hidden;
                        TEXTBOX5.Visibility = Visibility.Hidden;
                        TEXTBOX6.Visibility = Visibility.Hidden;
                        TEXTBOX7.Visibility = Visibility.Hidden;

                        Combobox1.SetValue(HintAssist.HintProperty, "Фамилия посетителя");
                        Combobox2.SetValue(HintAssist.HintProperty, "Номер заказа");
                        Combobox3.SetValue(HintAssist.HintProperty, "Блюдо");
                        Combobox4.SetValue(HintAssist.HintProperty, "Способ оплаты");
                        Combobox5.Visibility = Visibility.Hidden;
                        Combobox6.Visibility = Visibility.Hidden;
                        Combobox7.Visibility = Visibility.Hidden;

                        Combobox1.ItemsSource = customersTableAdapter.GetData();
                        Combobox1.DisplayMemberPath = "CustomerSurame";

                        Combobox2.ItemsSource = checksTableAdapter.GetData();
                        Combobox2.DisplayMemberPath = "CustomerID";

                        Combobox3.ItemsSource = menutableadapter.GetData();
                        Combobox3.DisplayMemberPath = "ItemName";

                        Combobox4.ItemsSource = paymentMethodsTableAdapter.GetData();
                        Combobox4.DisplayMemberPath = "NamePayment";

                        break;
                    case "Информация о сотрудниках":
                        Tablica.ItemsSource = employeeInfoTableAdapter.GetData();

                        TEXTBOX1.SetValue(HintAssist.HintProperty, "Начало приготовления");
                        TEXTBOX2.SetValue(HintAssist.HintProperty, "Конец приготовления");
                        TEXTBOX3.Visibility = Visibility.Hidden;
                        TEXTBOX4.Visibility = Visibility.Hidden;
                        TEXTBOX5.Visibility = Visibility.Hidden;
                        TEXTBOX6.Visibility = Visibility.Hidden;
                        TEXTBOX7.Visibility = Visibility.Hidden;

                        Combobox1.SetValue(HintAssist.HintProperty, "Логин сотрудника");
                        Combobox2.Visibility = Visibility.Hidden;
                        Combobox3.Visibility = Visibility.Hidden;
                        Combobox4.Visibility = Visibility.Hidden;
                        Combobox5.Visibility = Visibility.Hidden;
                        Combobox6.Visibility = Visibility.Hidden;
                        Combobox7.Visibility = Visibility.Hidden;

                        Combobox1.ItemsSource = employeeInfoTableAdapter.GetData();
                        Combobox1.DisplayMemberPath = "Username";

                        break;
                }

            }

            private void Add_clc(object sender, RoutedEventArgs e)
            {
                try
                {
                    switch (Tab)
                    {
                        case "Сотрудники":
                            employeesTableAdapter.InsertQueru(TEXTBOX1.Text, TEXTBOX2.Text, Combobox1.SelectedIndex + 1, Convert.ToInt32(TEXTBOX3.Text), TEXTBOX4.Text, Vhod.Hach(TEXTBOX5.Text));
                            Tablica.ItemsSource = employeesTableAdapter.GetData();
                            break;
                        case "Меню":
                            menutableadapter.InsertQuery(TEXTBOX1.Text, float.Parse(TEXTBOX2.Text, CultureInfo.InvariantCulture.NumberFormat));
                            Tablica.ItemsSource = menutableadapter.GetData();
                            break;
                        case "Способ оплаты":
                            paymentMethodsTableAdapter.InsertQuery(TEXTBOX1.Text);
                            Tablica.ItemsSource = paymentMethodsTableAdapter.GetData();
                            break;
                        case "Должности":
                            dolzhnoctiTableAdapter.InsertQuery(TEXTBOX1.Text);
                            Tablica.ItemsSource = dolzhnoctiTableAdapter.GetData();
                            break;
                        case "Заказы":
                            ordersTableAdapter.InsertQuery(TEXTBOX1.Text, Convert.ToInt32(TEXTBOX2.Text), Combobox1.SelectedIndex + 1, Combobox2.SelectedIndex + 1);
                            Tablica.ItemsSource = ordersTableAdapter.GetData();
                            break;
                        case "Повара":
                            chefsTableAdapter.InsertQuery(TEXTBOX1.Text, TEXTBOX2.Text, Combobox1.SelectedIndex + 1);
                            Tablica.ItemsSource = chefsTableAdapter.GetData();
                            break;
                        case "Приготовление":
                            cookingTableAdapter.InsertQuery(Combobox1.SelectedIndex + 1, Combobox2.SelectedIndex + 1, TEXTBOX1.Text, TEXTBOX2.Text);
                            Tablica.ItemsSource = cookingTableAdapter.GetData();
                            break;
                        case "Посетители":
                            customersTableAdapter.InsertQuery(TEXTBOX1.Text, TEXTBOX2.Text, TEXTBOX3.Text);
                            Tablica.ItemsSource = customersTableAdapter.GetData();
                            break;
                        case "Заказы посетителей":
                            customerOrdersTableAdapter.InsertQuery(Combobox1.SelectedIndex + 1, Combobox2.SelectedIndex + 1);
                            Tablica.ItemsSource = customerOrdersTableAdapter.GetData();
                            break;
                        case "Чеки":
                            checksTableAdapter.InsertQuery(Combobox1.SelectedIndex + 1, Combobox2.SelectedIndex + 1, Combobox3.SelectedIndex + 1,
                                float.Parse(TEXTBOX1.Text, CultureInfo.InvariantCulture.NumberFormat), Combobox4.SelectedIndex + 1);
                            Tablica.ItemsSource = checksTableAdapter.GetData();
                            break;
                        case "Информация о сотрудниках":
                            employeeInfoTableAdapter.InsertQuery(Combobox1.SelectedIndex + 1, TEXTBOX1.Text, TEXTBOX2.Text);
                            Tablica.ItemsSource = employeeInfoTableAdapter.GetData();
                            break;
                    }
                } catch (System.FormatException)
                {
                    
                }
            }

            private void fff_clc(object sender, RoutedEventArgs e)
            {

                object id = (Tablica.SelectedItem as DataRowView).Row[0];
            try
            {
                switch (Tab)
                {

                    case "Сотрудники":
                    employeesTableAdapter.UpdateQuery(TEXTBOX1.Text, TEXTBOX2.Text, Combobox1.SelectedIndex + 1, Convert.ToInt32(TEXTBOX3.Text), TEXTBOX4.Text, Vhod.Hach(TEXTBOX5.Text), Convert.ToInt32(id));
                    Tablica.ItemsSource = employeesTableAdapter.GetData();
                    break;
                case "Меню":
                    menutableadapter.UpdateQuery(TEXTBOX1.Text, float.Parse(TEXTBOX2.Text, CultureInfo.InvariantCulture.NumberFormat), Convert.ToInt32(id));
                    Tablica.ItemsSource = menutableadapter.GetData();
                    break;
                case "Способ оплаты":
                    paymentMethodsTableAdapter.UpdateQuery(TEXTBOX1.Text, Convert.ToInt32(id));
                    Tablica.ItemsSource = paymentMethodsTableAdapter.GetData();
                    break;
                case "Должности":
                    dolzhnoctiTableAdapter.UpdateQuery(TEXTBOX1.Text, Convert.ToInt32(id));
                    Tablica.ItemsSource = dolzhnoctiTableAdapter.GetData();
                    break;
                case "Заказы":
                    ordersTableAdapter.UpdateQuery(TEXTBOX1.Text, Convert.ToInt32(TEXTBOX2.Text), Combobox1.SelectedIndex + 1, Combobox2.SelectedIndex + 1, Convert.ToInt32(id));
                    Tablica.ItemsSource = ordersTableAdapter.GetData();
                    break;
                case "Повара":
                    chefsTableAdapter.UpdateQuery(TEXTBOX1.Text, TEXTBOX2.Text, Combobox1.SelectedIndex + 1, Convert.ToInt32(id));
                    Tablica.ItemsSource = chefsTableAdapter.GetData();
                    break;
                case "Приготовление":
                    cookingTableAdapter.UpdateQuery(Combobox1.SelectedIndex + 1, Combobox2.SelectedIndex + 1, TEXTBOX1.Text, TEXTBOX2.Text, Convert.ToInt32(id));
                    Tablica.ItemsSource = cookingTableAdapter.GetData();
                    break;
                case "Посетители":
                    customersTableAdapter.UpdateQuery(TEXTBOX1.Text, TEXTBOX2.Text, TEXTBOX3.Text, Convert.ToInt32(id));
                    Tablica.ItemsSource = customersTableAdapter.GetData();
                    break;
                case "Заказы посетителей":
                    customerOrdersTableAdapter.UpdateQuery(Combobox1.SelectedIndex + 1, Combobox2.SelectedIndex + 1, Convert.ToInt32(id));
                    Tablica.ItemsSource = customerOrdersTableAdapter.GetData();
                    break;
                case "Чеки":
                    checksTableAdapter.UpdateQuery(Combobox1.SelectedIndex + 1, Combobox2.SelectedIndex + 1, Combobox3.SelectedIndex + 1,
                        float.Parse(TEXTBOX1.Text, CultureInfo.InvariantCulture.NumberFormat), Combobox4.SelectedIndex + 1, Convert.ToInt32(id));
                    Tablica.ItemsSource = checksTableAdapter.GetData();
                    break;
                case "Информация о сотрудниках":
                    employeeInfoTableAdapter.UpdateQuery(Combobox1.SelectedIndex + 1, TEXTBOX1.Text, TEXTBOX2.Text, Convert.ToInt32(id));
                    Tablica.ItemsSource = employeeInfoTableAdapter.GetData();
                    break;
                }
            } catch(System.NullReferenceException) { }
            }

        private void Delete_clc(object sender, RoutedEventArgs e)
        {
            if (Tablica.SelectedItem != null) { 
            object id = (Tablica.SelectedItem as DataRowView).Row[0];

            switch (Tab)
            {
                case "Сотрудники":
                    employeesTableAdapter.DeleteQuery(Convert.ToInt32(id));
                    Tablica.ItemsSource = employeesTableAdapter.GetData();
                    break;
                case "Меню":
                    menutableadapter.DeleteQuery(Convert.ToInt32(id));
                    Tablica.ItemsSource = menutableadapter.GetData();
                    break;
                case "Способ оплаты":
                    paymentMethodsTableAdapter.DeleteQuery(Convert.ToInt32(id));
                    Tablica.ItemsSource = paymentMethodsTableAdapter.GetData();
                    break;
                case "Должности":
                    dolzhnoctiTableAdapter.DeleteQuery(Convert.ToInt32(id));
                    Tablica.ItemsSource = dolzhnoctiTableAdapter.GetData();
                    break;
                case "Заказы":
                    ordersTableAdapter.DeleteQuery(Convert.ToInt32(id));
                    Tablica.ItemsSource = ordersTableAdapter.GetData();
                    break;
                case "Повара":
                    chefsTableAdapter.DeleteQuery(Convert.ToInt32(id));
                    Tablica.ItemsSource = chefsTableAdapter.GetData();
                    break;
                case "Приготовление":
                    cookingTableAdapter.DeleteQuery(Convert.ToInt32(id));
                    Tablica.ItemsSource = cookingTableAdapter.GetData();
                    break;
                case "Посетители":
                    customersTableAdapter.DeleteQuery(Convert.ToInt32(id));
                    Tablica.ItemsSource = customersTableAdapter.GetData();
                    break;
                case "Заказы посетителей":
                    customerOrdersTableAdapter.DeleteQuery(Convert.ToInt32(id));
                    Tablica.ItemsSource = customerOrdersTableAdapter.GetData();
                    break;
                case "Чеки":
                    checksTableAdapter.DeleteQuery(Convert.ToInt32(id));
                    Tablica.ItemsSource = checksTableAdapter.GetData();
                    break;
                case "Информация о сотрудниках":
                    employeeInfoTableAdapter.DeleteQuery(Convert.ToInt32(id));
                    Tablica.ItemsSource = employeeInfoTableAdapter.GetData();
                    break;
            }
        }
            }

        private void Tablica_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try {
                switch (Tab)
                {
                    case "Сотрудники":
                        TEXTBOX1.Text = (Tablica.SelectedItem as DataRowView).Row[1].ToString();
                        TEXTBOX2.Text = (Tablica.SelectedItem as DataRowView).Row[2].ToString();
                        TEXTBOX3.Text = (Tablica.SelectedItem as DataRowView).Row[4].ToString();
                        TEXTBOX4.Text = (Tablica.SelectedItem as DataRowView).Row[5].ToString();
                        TEXTBOX5.Text = (Tablica.SelectedItem as DataRowView).Row[6].ToString();

                        Combobox1.SelectedIndex = Convert.ToInt32((Tablica.SelectedItem as DataRowView).Row[3]);
                        break;
                    case "Меню":
                        TEXTBOX1.Text = (Tablica.SelectedItem as DataRowView).Row[1].ToString();
                        TEXTBOX2.Text = (Tablica.SelectedItem as DataRowView).Row[2].ToString();
                        break;
                    case "Способ оплаты":
                        TEXTBOX1.Text = (Tablica.SelectedItem as DataRowView).Row[1].ToString();
                        break;
                    case "Должности":
                        TEXTBOX1.Text = (Tablica.SelectedItem as DataRowView).Row[1].ToString();
                        break;
                    case "Заказы":
                        TEXTBOX1.Text = (Tablica.SelectedItem as DataRowView).Row[1].ToString();
                        TEXTBOX2.Text = (Tablica.SelectedItem as DataRowView).Row[2].ToString();

                        Combobox1.SelectedIndex = Convert.ToInt32((Tablica.SelectedItem as DataRowView).Row[3]);
                        Combobox2.SelectedIndex = Convert.ToInt32((Tablica.SelectedItem as DataRowView).Row[4]);
                        break;
                    case "Повара":
                        TEXTBOX1.Text = (Tablica.SelectedItem as DataRowView).Row[1].ToString();
                        TEXTBOX2.Text = (Tablica.SelectedItem as DataRowView).Row[2].ToString();
                        break;
                    case "Приготовление":
                        TEXTBOX1.Text = (Tablica.SelectedItem as DataRowView).Row[3].ToString();
                        TEXTBOX2.Text = (Tablica.SelectedItem as DataRowView).Row[4].ToString();

                        Combobox1.SelectedIndex = Convert.ToInt32((Tablica.SelectedItem as DataRowView).Row[1]);
                        Combobox2.SelectedIndex = Convert.ToInt32((Tablica.SelectedItem as DataRowView).Row[2]);
                        break;
                    case "Посетители":
                        TEXTBOX1.Text = (Tablica.SelectedItem as DataRowView).Row[1].ToString();
                        TEXTBOX2.Text = (Tablica.SelectedItem as DataRowView).Row[2].ToString();
                        TEXTBOX3.Text = (Tablica.SelectedItem as DataRowView).Row[3].ToString();
                        break;
                    case "Заказы посетителей":
                        Combobox1.SelectedIndex = Convert.ToInt32((Tablica.SelectedItem as DataRowView).Row[1]);
                        Combobox2.SelectedIndex = Convert.ToInt32((Tablica.SelectedItem as DataRowView).Row[2]);
                        break;
                    case "Чеки":
                        TEXTBOX2.Text = (Tablica.SelectedItem as DataRowView).Row[4].ToString();

                        Combobox1.SelectedIndex = Convert.ToInt32((Tablica.SelectedItem as DataRowView).Row[1]);
                        Combobox2.SelectedIndex = Convert.ToInt32((Tablica.SelectedItem as DataRowView).Row[2]);
                        Combobox3.SelectedIndex = Convert.ToInt32((Tablica.SelectedItem as DataRowView).Row[3]);
                        Combobox4.SelectedIndex = Convert.ToInt32((Tablica.SelectedItem as DataRowView).Row[5]);
                        break;
                    case "Информация о сотрудниках":
                        TEXTBOX2.Text = (Tablica.SelectedItem as DataRowView).Row[2].ToString();
                        TEXTBOX3.Text = (Tablica.SelectedItem as DataRowView).Row[3].ToString();
                        Combobox1.SelectedIndex = Convert.ToInt32((Tablica.SelectedItem as DataRowView).Row[1]);
                        break;
                }
            }catch(System.NullReferenceException) { }
            }

        private void Text_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Admin A = new Admin(new List<MegaHitDataSet.EmployeesRow>());
            System.Windows.Controls.TextBox textBox = (System.Windows.Controls.TextBox)sender;
            string inputText = e.Text;

            if ((string)A.CBXTABL.SelectedItem == "Меню")
            {
                if ((string)A.CBXTABL.SelectedItem == "Меню" && textBox.Name == "TEXTBOX2")
                {
                    if (!string.IsNullOrEmpty(inputText) && !char.IsDigit(inputText[0]))
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void TEXTBOX2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(Regex.IsMatch(TEXTBOX2.Text, @"\d"))
            {
                e.Handled = true;
            }
        }
    }
}
