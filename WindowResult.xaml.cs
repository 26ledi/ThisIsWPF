using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
using WpfApp1;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for WindowResult.xaml
    /// </summary>
    public partial class WindowResult : Window
    {
        public WindowResult()
        {
            InitializeComponent();
        }
        List<Clothes> clothes = new List<Clothes>();
        public bool Verify(List<Clothes>T) 
        {
            return T.Count > 0;
        }
        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {

            if (RadioSkirt.IsChecked == true)
            {
                var balmain = new Skirt();
                balmain.Tissu = TextBoxTissu.Text;
                balmain.Size = TextBoxSize.Text;
                balmain.Color = TextBoxColor.Text;
                clothes.Add(balmain);

            }
            else if (RadioJeans.IsChecked == true)
            {
                var dior = new Jeans();
                dior.Tissu = TextBoxTissu.Text;
                dior.Size = TextBoxSize.Text;
                dior.Color = TextBoxColor.Text;
                clothes.Add(dior);
            }
            else if (BlazerRadio.IsChecked == true)
            {
                var louisVuitton = new Blazer();
                louisVuitton.Tissu = TextBoxTissu.Text;
                louisVuitton.Size = TextBoxSize.Text;
                louisVuitton.Color = TextBoxColor.Text;
                clothes.Add(louisVuitton);
            }

            CostumesKeeper.clothes = clothes;

        }

        
        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            TextBoxTissu.Clear();
            TextBoxSize.Clear();
            TextBoxColor.Clear();
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            var window = new MainWindow();
            window.Show();
        }
    }
}
