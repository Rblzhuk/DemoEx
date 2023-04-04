using System;
using System.Collections.Generic;
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

namespace CaptchaInWpf.Windows
{
    /// <summary>
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {

        public Registration()
        {
            InitializeComponent();
            DataContext = this;
            ComboBox_Role.ItemsSource = SourceCore.MyBase.Role.ToList();
            ComboBox_Role.SelectedIndex = 0;
        }
        

        private void Button_BackToLogin_Click(object sender, RoutedEventArgs e)
        {
            Windows.Authorization authorization = new Authorization();
            authorization.Show();
            this.Close();
        }

        private void Button_Registration_Click(object sender, RoutedEventArgs e)
        {
            if (IsDataValid())
            {
                DataBase.User user = new DataBase.User()
                {
                    UserLogin = TextBox_Login.Text,
                    UserPassword = TextBox_Password.Password,
                    UserName=TextBox_Name.Text,
                    UserSurname=TextBox_Surname.Text,
                    UserPatronymic = TextBox_Patronymic.Text,
                    UserRole = ComboBox_Role.SelectedIndex,
                };
                SourceCore.MyBase.User.Add(user);
                SourceCore.MyBase.SaveChanges();

                Windows.Authorization authorization = new Authorization();
                authorization.Show();
                this.Close();
            }
        }

        private bool IsDataValid()
        {
            Regex regex;
            const string pat_login = "^[A-Za-z]{5,20}$";
            const string pat_password = "^[A-Za-z0-9]{5,20}$";
            const string pat_name = "^[A-Za-z]{5,20}$";
            const string pat_surname = "^[A-Za-z]{5,20}$";
            const string pat_patronymic = "^[A-Za-z]{0,20}$";

            regex = new Regex(pat_login);
            if (!regex.IsMatch(TextBox_Login.Text))
            {
                MessageBox.Show("Логин имеет неверный формат");
                return false;
            }
            regex = new Regex(pat_password);
            if (!regex.IsMatch(TextBox_Password.Password))
            {
                MessageBox.Show("Пароль имеет неверный формат");
                return false;
            }
            if (TextBox_Password.Password != TextBox_RepeatPassword.Password)
            {
                MessageBox.Show("Пароли не совпадают");
                return false;
            }
            regex = new Regex(pat_name);
            if (!regex.IsMatch(TextBox_Name.Text))
            {
                MessageBox.Show("Имя имеет неверный формат");
                return false;
            }
            regex = new Regex(pat_surname);
            if (!regex.IsMatch(TextBox_Surname.Text))
            {
                MessageBox.Show("Фамилия имеет неверный формат");
                return false;
            }
            regex = new Regex(pat_patronymic);
            if (!regex.IsMatch(TextBox_Patronymic.Text))
            {
                MessageBox.Show("Отчество имеет неверный формат");
                return false;
            }

            MessageBox.Show("Регистрация успешно завершена");

            return true;
        }
    }
}
