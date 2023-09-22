using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Intro_arv
{
    internal class Cat
    {
        private int age;
        public Cat(int _age)
        {
            age = _age;
        }
        public void Act()
        {
            Console.Write("Mjau");
            for (int i = 1; i < age; i++)
            {
                Console.Write(", mjau");
            }
        }

    }
}
