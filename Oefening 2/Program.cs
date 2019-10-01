using System;

namespace Oefening_2
{
    class Program
    {
        static void Main(string[] args)
        {
            NewsAgency Belga = new NewsAgency();

            NewsPaper Standaard = new NewsPaper("Standaard");
            NewsPaper NYTimes = new NewsPaper("New York Times");

            var menu = new SMUtils.Menu();
            menu.AddOption('1', "Add Economic News", () =>
            {
                Console.WriteLine("Type your News Message:");
                var message = Console.ReadLine();
                Belga.PublishEconomicNews(message);
            });

            menu.AddOption('2', "Add Political News", () =>
            {
                Console.WriteLine("Type your News Message:");
                var message = Console.ReadLine();
                Belga.PublishPoliticalNews(message);
            });

            menu.AddOption('3', "Add Tech News", () =>
            {
                Console.WriteLine("Type your News Message:");
                var message = Console.ReadLine();
                Belga.PublishTechNews(message);
            });

            menu.Start();
        }
    }
}
