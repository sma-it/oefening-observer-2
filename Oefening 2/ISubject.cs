using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_2
{
    interface ISubject
    {
        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void UpdateObservers(NewsTypes type, string message);
    }
}
