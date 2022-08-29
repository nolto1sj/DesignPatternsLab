using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLab
{
    public class CountryView
    {
        public Country DisplayCountry { get; set; }

        public CountryView(Country displayCountry)
        {
            DisplayCountry = displayCountry;
        }

        public void Display()
        {
            Console.WriteLine("\nName: " + DisplayCountry.Name + ".");
            Console.WriteLine("Continent: " + DisplayCountry.Continent + ".");
            Console.Write("Colors: ");
            foreach (string color in DisplayCountry.Colors)
            {
                if (color.Equals(DisplayCountry.Colors.LastOrDefault()))
                {
                    Console.Write($"and {color}. ");
                }
                else if (DisplayCountry.Colors.Count == 2)
                {
                    Console.Write($"{color} ");
                }
                else
                {
                    Console.Write($"{color}, ");
                }
            }

        }
    }
}
