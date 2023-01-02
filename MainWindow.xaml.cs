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


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {
            var window = new WindowResult();
            window.Show();
        }

        private void Button_Costume_Click(object sender, RoutedEventArgs e)
        {
            var window = new WindowCost();
            window.Show();
            
        }

        private void Button_Jeans_Click(object sender, RoutedEventArgs e)
        {
            var window = new Red_Jeans();
            window.Show();
        }
    }
}
