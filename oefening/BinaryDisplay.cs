﻿using System;
using System.Collections.Generic;
using System.Text;

namespace oefening
{
    class BinaryDisplay : IObserver
    {
        public void Update(int value)
        {
            Console.WriteLine("New Binary Value: " + Convert.ToString(value, 2));
        }
    }
}
