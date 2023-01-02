using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Costume:Clothes
    {
        public Clothes Up { get; set; } 
        public Clothes Down { get; set;}
    }
}
