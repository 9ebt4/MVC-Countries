using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    public class CountryView
    {
        //Properties
        public Country DisplayCountry { get; set; }
        //Constructor
        public CountryView(Country _displayCountry) 
        {
            DisplayCountry = _displayCountry;
        }
        //Methods
        public void Display()
        {
            Console.Write($"Name: {DisplayCountry.Name}\nContinent: {DisplayCountry.Continent}\nFlag Colors: ");
            
            foreach (string flagColor in DisplayCountry.Colors)
            {
                Console.ForegroundColor = Enum.Parse<ConsoleColor>(flagColor);
                Console.Write($"{flagColor} ");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            
        }

    }
}
