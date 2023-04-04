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

namespace CaptchaInWpf
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

        public MainWindow(string userFio)
        {
            InitializeComponent();
            Label_UserFio.Content = userFio;
        }
        
        private void WindowOnload(object sender, RoutedEventArgs e)
        {
            productList.ItemsSource = SourceCore.MyBase.Product.ToList();
            List<DataBase.Manufacturer> manufacturerSortList = new List<DataBase.Manufacturer>();
            DataBase.Manufacturer allManufacturer = new DataBase.Manufacturer() { Name = "Все продукты" };
            manufacturerSortList.Add(allManufacturer);
            manufacturerSortList.AddRange(SourceCore.MyBase.Manufacturer.ToList());
            ComboBox_manufacturerSort.ItemsSource = manufacturerSortList;
        }
    }
}

