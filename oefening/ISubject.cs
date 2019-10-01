using System;
using System.Collections.Generic;
using System.Text;

namespace oefening_1
{
    interface ISubject
    {
        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void UpdateObservers(int number);
    }
}
