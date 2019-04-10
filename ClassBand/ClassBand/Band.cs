using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBand
{
    class Band
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public List<Musician> Musicians { get; set; }
        public Band()
        {
            this.Musicians = new List<Musician>();
        }
        public void AddMusicians()
        {
            Console.WriteLine("Please enter the musician name");
            Musician musician = new Musician();
            musician.Name = Console.ReadLine();
            Console.WriteLine("Please enter the instrument");
            musician.Instrument = Console.ReadLine();
            this.Musicians.Add(musician);
        }
    }
}
