using System;
using System.Collections.Generic;

namespace oefening_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal> animals = new List<IAnimal>();
            Person catLover = new Person("Tom");
            Person dogLover = new Person("Jerry");
            Person animalLover = new Person("Terry");

            var menu = new SMUtils.Menu();

            menu.AddOption('1', "Buy Dog", () =>
            {
                Console.WriteLine("You bought a dog");
                var animal = new Dog();
                animal.AddObserver(dogLover);
                animal.AddObserver(animalLover);
                animals.Add(animal);
            });

            menu.AddOption('2', "Buy Cat", () =>
            {
                Console.WriteLine("You bought a cat");
                var animal = new Cat();
                animal.AddObserver(catLover);
                animal.AddObserver(animalLover);
                animals.Add(animal);
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
