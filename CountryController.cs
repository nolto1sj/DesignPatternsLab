using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLab
{
    public class CountryController
    {
        List<Country> CountryDb;

        public void CountryAction(Country c)
        {
            var action = new CountryView(c);
            action.Display();
        }

        public void WelcomeAction()
        {
            Welcome:
            Console.Clear();
            MakeCountryDb();
            var countryListView = new CountryListView(CountryDb);
            Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list: ");
            countryListView.Display();
            Console.WriteLine("Please select a country by index");
            Selection:
            try
            {
                int selection = int.Parse(Console.ReadLine());
                CountryAction(CountryDb[selection - 1]);
                Console.WriteLine("\nWould you like to learn about another country? (y/n)");
                string input = Console.ReadLine().ToLower();
                while (input != "y" && input != "n")
                {
                    Console.WriteLine("Please select 'y' or 'n'");
                    input = Console.ReadLine().ToLower();
                }
                if (input == "y")
                {
                    goto Welcome;
                }
            }
            catch
            {
                Console.WriteLine($"invalid index. Please select from 1 - {CountryDb.Count} ");
                goto Selection;
            }
        }

        public void MakeCountryDb()
        {
            CountryDb = new List<Country>()
            {
                new Country("Spain", "Europe", new List<string>() {"red", "yellow"}),
                new Country("USA", "North America", new List<string>() {"red", "white", "blue"}),
                new Country("Japan", "Asia", new List<string>() {"red", "white", "purple", "green"}) //just tested if my CountryListView Display functioned as intented.
            };
        }
    }
}
