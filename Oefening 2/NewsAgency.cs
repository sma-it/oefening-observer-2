using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_2
{
    class NewsAgency : ISubject
    {
        List<IObserver> observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void PublishEconomicNews(string message)
        {
            UpdateObservers(NewsTypes.Economic, message);
        }

        public void PublishPoliticalNews(string message)
        {
            UpdateObservers(NewsTypes.Political, message);
        }

        public void PublishTechNews(string message)
        {
            UpdateObservers(NewsTypes.Tech, message);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void UpdateObservers(NewsTypes type, string message)
        {
            for (int i = observers.Count - 1; i >= 0; i--)
            {
                observers[i].Update(type, message);
            }
        }
    }
}
