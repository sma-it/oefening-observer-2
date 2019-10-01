using System;

namespace oefening_1
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberKeeper nKeeper = new NumberKeeper();
            HexDisplay hexDisplay = new HexDisplay();
            BinaryDisplay binaryDisplay = new BinaryDisplay();

            var menu = new SMUtils.Menu();
            menu.AddOption('1', "Enter Number", () => {
                try
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    nKeeper.SetNumber(number);
                } catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            });

            menu.Start();
        }
    }
}
