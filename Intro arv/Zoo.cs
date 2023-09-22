using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_arv
{
    internal class Zoo
    {
        private int cat;
        private int dog;
        private int catAge;
        private int ko;
        public Zoo(int _Cat, int _catAge, int _Dog, int _Ko)
        {
            cat = _Cat;
            dog = _Dog;
            catAge = _catAge;
            ko = _Ko;
        }
        public void Run()
        {
            Cat katt = new Cat(catAge);
            Dog hund = new Dog();
            Ko kossa = new Ko(3);

            for (int i = 0; i < cat; i++)
            {
                katt.Act();
                Console.WriteLine();
            }

            for (int i = 0; i < dog; i++)
            {
                hund.Act();
            }

            for (int i = 0; i < ko; i++)
            {
                kossa.Act();
                Console.WriteLine();
            }
        }
    }
}
