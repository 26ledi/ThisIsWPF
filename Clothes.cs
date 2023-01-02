using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp1
{
    public abstract class Clothes 
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Tissu { get; set; }
    }
}
