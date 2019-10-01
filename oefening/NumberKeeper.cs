using System;
using System.Collections.Generic;
using System.Text;

namespace oefening_1
{
    class NumberKeeper
    {
        int number;

        public void SetNumber(int value)
        {
            number = value;

            Console.WriteLine("The new Number is " + number);
        }
    }
}
