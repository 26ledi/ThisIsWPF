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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Red_Jeans.xaml
    /// </summary>
    public partial class Red_Jeans : Window
    {
        public Red_Jeans()
        {
            InitializeComponent();
        }

        private void ShowRed_Click(object sender, RoutedEventArgs e)
        {

            var showCostum = CostumesKeeper.clothes;
            foreach(var clothe in showCostum) 
            {
                if (clothe is Jeans && clothe.Color.ToLower() == "Red".ToLower())
                {
                    FinalRed.AppendText(clothe.Tissu + " " + clothe.Color + " " + clothe.Size + "\n");
                }

            }
        }
    }
}
