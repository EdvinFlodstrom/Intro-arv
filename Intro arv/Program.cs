using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Cat katt = new Cat(5);
            katt.Act();

            Console.WriteLine();

            Dog hund = new Dog();
            hund.Act();

            Console.WriteLine();
            */

            Zoo mittZoo = new Zoo(3, 3, 2, 3);
            mittZoo.Run();

            Console.ReadLine();
        }
    }
}
