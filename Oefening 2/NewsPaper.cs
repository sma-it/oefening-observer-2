using Oefening_2.PublishStrategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_2
{
    abstract class NewsPaper : IObserver
    {
        private string name;
        IFilter filter;

        public  NewsPaper(string name, IFilter filter)
        {
            this.name = name;
            this.filter = filter;
        }

        public void Update(NewsTypes type, string message)
        {
            if(filter.ShouldPublish(type))
            {
                Console.WriteLine(type.ToString() + " news from " + name + ": " + message);
            }
        }
    }
}
