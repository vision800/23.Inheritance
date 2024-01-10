using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Inheritance
{
    internal class Chef
    {
        public static void makesChickem()
        {
            Console.WriteLine("the chef makes chicken");
        }
        public static void makesSalad()
        {
            Console.WriteLine("the chef makes salad");
        }
        public virtual  void makesSpecial()
        {
            Console.WriteLine("the chef makes special dish");
        }
    }
}
 
