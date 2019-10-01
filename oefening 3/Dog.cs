using System;
using System.Collections.Generic;
using System.Text;

namespace oefening_3
{
    class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Woof");
        }
    }
}
