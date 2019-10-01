using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening_2
{
    class NewsPaper : IObserver
    {
        private string name;

        public  NewsPaper(string name)
        {
            this.name = name;
        }

        public void Update(NewsTypes type, string message)
        {
            Console.WriteLine(type.ToString() +  " news from " + name + ": " + message);
        }
    }
}
