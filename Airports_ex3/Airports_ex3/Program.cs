using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airports_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "ATL US SuperMega PEK CN Mega LAX US Mega ORD US Mega HND JP SuperMega LHR UK Large DEN US Large CDG FR Medium AMS NL Medium MAD ES Medium LAS US Medium HBE EG Small CPT ZA Small CAI EG Medium FRA GE Large HAM GE Medium FCO IT Large VRN IT Small";
            string[] array = txt.Split(' ');

            List<Airport> airports = new List<Airport>();
            for (int i = 0; i < array.Length; i+=3)
            {
                airports.Add(new Airport(array[i], array[i + 1], array[i + 2]));
            }

            List<Airport> SmallAirports = new List<Airport>();
            List<Airport> MediumAirports = new List<Airport>();
            List<Airport> LargeAirports = new List<Airport>();
            List<Airport> MegaAirports = new List<Airport>();
            List<Airport> SuperMegaAirports = new List<Airport>();

            for (int i = 0; i < airports.Count; i++)
            {
                switch(airports[i].Size)
                {
                    case "Small":
                        SmallAirports.Add(airports[i]);
                        break;
                    case "Medium":
                        MediumAirports.Add(airports[i]);
                        break;
                    case "Large":
                        LargeAirports.Add(airports[i]);
                        break;
                    case "Mega":
                        MegaAirports.Add(airports[i]);
                        break;
                    case "SuperMega":
                        SuperMegaAirports.Add(airports[i]);
                        break;
                }
            }

            foreach(var x in MediumAirports)
            {
                Console.WriteLine(x);
            }
        }
    }
}
