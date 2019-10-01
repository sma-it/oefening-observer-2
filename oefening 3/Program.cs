using System;
using System.Collections.Generic;

namespace oefening_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal> animals = new List<IAnimal>();

            var menu = new SMUtils.Menu();

            menu.AddOption('1', "Buy Dog", () =>
            {
                Console.WriteLine("You bought a dog");
                animals.Add(new Dog());
            });

            menu.AddOption('2', "Buy Cat", () =>
            {
                Console.WriteLine("You bought a cat");
                animals.Add(new Cat());
            });

            menu.AddOption('3', "Spook Animal", () =>
            {
                var Random = new Random();
                var randomAnimal = Random.Next(animals.Count);
                animals[randomAnimal].MakeSound();
            });

            menu.Start();
        }
    }
}
