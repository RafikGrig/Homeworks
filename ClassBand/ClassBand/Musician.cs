using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBand
{
    class Musician
    {
        public string Name { get; set; }
        public string Instrument { get; set; }
        public Musician(string name, string ins)
        {
            this.Name = name;
            this.Instrument = ins;
        }
        public Musician(){}


        
    }
}
