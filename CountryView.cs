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
            foreach (string color in DisplayCountry.Colors)
            {
                switch (color)
                {
                    case "green": { Console.ForegroundColor = ConsoleColor.Green; break; }
                    case "red": { Console.ForegroundColor = ConsoleColor.Red; break; }
                    case "yellow": {Console.ForegroundColor = ConsoleColor.Yellow; break; }
                    case "blue": {Console.ForegroundColor = ConsoleColor.Blue; break; }
                    case "white": {Console.ForegroundColor = ConsoleColor.White; break; }
                    case "black": {Console.ForegroundColor = ConsoleColor.Black; break; }
                    case "dark blue": {Console.ForegroundColor = ConsoleColor.DarkBlue; break; }
                } //stretch goal didn't work as intended, but I thought it was fun nonetheless. 
            }

        }
    }
}
