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

        public void Update(string message)
        {
            Console.WriteLine("Mews from " + name + ": " + message);
        }
    }
}
