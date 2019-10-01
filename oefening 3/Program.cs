using System;

namespace oefening_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new SMUtils.Menu();

            menu.AddOption('1', "Say Hello", () =>
            {
                Console.WriteLine("Hello World");
            });
        }
    }
}
