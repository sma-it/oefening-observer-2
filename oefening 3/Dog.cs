using System;
using System.Collections.Generic;
using System.Text;

namespace oefening_3
{
    class Dog : IAnimal, ISubject
    {
        List<IObserver> observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void MakeSound()
        {
            Console.WriteLine("Woof");
            UpdateObservers();
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void UpdateObservers()
        {
            for(int i = observers.Count - 1; i >= 0; i--)
            {
                observers[i].Update(AnimalType.Dog);
            }
        }
    }
}
