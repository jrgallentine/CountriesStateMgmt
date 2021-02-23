using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountriesRevisited.Models
{
    public class Country
    {
        public string Name { get; set; }
        public List<string> Language { get; set;}
        public string Greeting { get; set; }
        public string Description { get; set;}
        public List<string> Colors { get; set; }

        public Country() 
        {
            
        }
        public Country(string Name, List<string> Language, string Greeting, List<string> Colors, string Description)
        {
            this.Name = Name;
            this.Language = Language;
            this.Greeting = Greeting;
            this.Colors = Colors;
            this.Description = Description;
        }

    }

}
