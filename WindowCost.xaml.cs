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
    /// Interaction logic for WindowCost.xaml
    /// </summary>
    public partial class WindowCost : Window
    {
        public WindowCost()
        {
            InitializeComponent();
        }

        private void Bttn_ShowCost_Click(object sender, RoutedEventArgs e)
        {
            var showCostum = CostumesKeeper.clothes;
            foreach(var clothe in showCostum) 
            {
               Cstm.AppendText(clothe.Tissu + " "+clothe.Color + " "+ clothe.Size +"\n");
            }
            
        }
    }
}
