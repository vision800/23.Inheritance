using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Chef chef = new Chef();
            chef.makesSpecial();

            //italian chef
            ItalianChef italianChef = new ItalianChef();
            italianChef.makesSpecial();
            italianChef.makePasta();

            Console.ReadLine();
        }
    }
}
