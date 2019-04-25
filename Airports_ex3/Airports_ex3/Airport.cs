using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airports_ex3
{    
    /// <summary>    
    ///  Class represents an airport      
    /// </summary> 
    public class Airport
    {
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public string Size { get; set; }

        public Airport(){}

        public Airport(string name, string countryCode, string size)
        {
            this.Name = name;
            this.CountryCode = countryCode;
            this.Size = size;                
        }

        public override string ToString()
        {
            return $"Name:{Name}  Country Code:{CountryCode}  Size:{Size}";
        }
    }
}
