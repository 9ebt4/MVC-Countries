using Circle;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    internal class CountryController
    {
        public List<Country> CountriesDB = new List<Country>()
        {
            new Country("Russia", "Europe and Asia",new List<string> {"White","Blue","Red"} ),
             new Country("Canada", "North America",new List<string> {"Red","White"} ),
              new Country("China", "Asia",new List<string> {"Red","Yellow"} ),
               new Country("Brazil", "South America",new List<string> {"Green","Yellow","Blue"} ),
                new Country("Australia", "Oceania",new List<string> {"Red","White","Blue"} ),
                 new Country("India", "Asia",new List<string> {"DarkYellow","White","DarkGreen"} ),
                 new Country("Argentina", "South America",new List<string> {"Blue","White"} ),
                 new Country("Kazakhstan", "Asia",new List<string> {"Blue","Yellow"} ),
                 new Country("Algeria", "Africa",new List<string> {"Green","White","Red"} ),
        };
        public void CountryAction(Country c)
        {
            CountryView cv = new CountryView(c);
            cv.Display();
        }


        public void WelcomeAction()
        {
            Console.WriteLine("Hello, welcome to the country app.Please select a country from the following list:");
            bool runProgram = true;
            while (runProgram)
            {
                CountryListView clv = new CountryListView(CountriesDB);
                clv.Display();
                int result = Validator.IntValidator(1,CountriesDB.Count);
                Console.Clear();
                CountryAction(CountriesDB[result-1]);
                runProgram=Validator.GetContinue($"\n\nWould you like to view more countries?");
            }
            
        }
    }
}
