using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Inheritance
{
    internal class ItalianChef: Chef
    {

        public   void makePasta()
        {
            Console.WriteLine("the chef makes pasta");
        }
        public override void makesSpecial()
        {
            Console.WriteLine("the chef makes italian specials");
        }
    }
}
