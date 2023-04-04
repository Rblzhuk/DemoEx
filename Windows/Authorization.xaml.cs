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
using System.Timers;

namespace CaptchaInWpf.Windows
{
    /// <summary>
    /// Interaction logic for Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        Timer timer;
        private bool isTimerCouting = false;
        public Authorization()
        {
            InitializeComponent();
            StackPanel_CapchaBlock.Visibility = Visibility.Collapsed;
        }

        private void Button_Login_Click(object sender, RoutedEventArgs e)
        {
            if (!isTimerCouting)
            {
                DataBase.User user = SourceCore.MyBase.User.SingleOrDefault(usr => usr.UserLogin == TextBox_Login.Text && usr.UserPassword == TextBox_Password.Password);
                if (user != null)
                {
                    if (StackPanel_CapchaBlock.Visibility == Visibility.Visible)
                    {
                        if (TextBox_Capcha.Text != TextBox_UserCapcha.Text)
                        {
                            MessageBox.Show("Неверно введена капча");
                            timer = new Timer(10000);
                            timer.Elapsed += StopTimer;
                            timer.Start();
                            isTimerCouting = true;
                        }
                    }
                    else
                    {
                        //MessageBox.Show($"Здравствуйте {user.UserName}");
                        MainWindow mainWindow = new MainWindow($"{user.UserSurname} {user.UserName} {user.UserPatronymic}");
                        mainWindow.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                    if (StackPanel_CapchaBlock.Visibility == Visibility.Visible)
                    {
                        timer = new Timer(10000);
                        timer.Elapsed += StopTimer;
                        timer.Start();
                        isTimerCouting = true;

                    }
                    StackPanel_CapchaBlock.Visibility = Visibility.Visible;
                }
            }
            else
            {
                MessageBox.Show("От неудачной попытки должно пройти 10 секунд");
            }
        }

        private void Button_Registration_Click(object sender, RoutedEventArgs e)
        {
            Windows.Registration reg = new Registration();
            reg.Show();
            this.Close();
        }

        private void Button_GenerateCapcha_Click(object sender, RoutedEventArgs e)
        {
            String allowchar = " ";
            allowchar = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";
            allowchar += "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,y,z";
            allowchar += "1,2,3,4,5,6,7,8,9,0";
            //разделитель
            char[] a = { ',' };
            //расщепление массива по разделителю
            String[] ar = allowchar.Split(a);
            String pwd = "";
            string temp = "";
            Random r = new Random();
            for (int i = 0; i < 6; i++)
            {
                temp = ar[(r.Next(0, ar.Length))];
                pwd += temp;
            }
            TextBox_Capcha.Text = pwd;
        }

        private void StopTimer(object sender, ElapsedEventArgs args)
        {
            timer.Stop();
            isTimerCouting = false;
        }
    }
}
