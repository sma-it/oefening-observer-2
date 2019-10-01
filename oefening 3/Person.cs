using System;
using System.Collections.Generic;
using System.Text;

namespace oefening_3
{
    class Person : IObserver
    {
        string name;

        public Person(string name)
        {
            this.name = name;
        }

        public void Update(AnimalType type, string name)
        {
            Console.WriteLine(this.name + " heard " + name + " make a sound");
        }
    }
}
