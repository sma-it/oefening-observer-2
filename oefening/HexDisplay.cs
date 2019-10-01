using System;
using System.Collections.Generic;
using System.Text;

namespace oefening
{
    class HexDisplay : IObserver
    {
        public void Update(int value)
        {
            Console.WriteLine("New Hex Value: " + value.ToString("x"));
        }
    }
}
