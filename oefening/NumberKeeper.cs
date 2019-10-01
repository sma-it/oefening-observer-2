using System;
using System.Collections.Generic;
using System.Text;

namespace oefening_1
{
    class NumberKeeper : ISubject
    {
        int number;
        List<IObserver> observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void SetNumber(int value)
        {
            number = value;

            Console.WriteLine("The new Number is " + number);
            UpdateObservers(number);
        }

        public void UpdateObservers(int number)
        {
            for(int i = observers.Count -1; i >= 0; i--)
            {
                observers[i].Update(number);
            }
        }
    }
}
