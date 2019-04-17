using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileReader;

namespace CarsProgramm
{
    class Program
    {
        private static readonly string fileName = "cars.csv";
        static void Main(string[] args)
        {
            CSVReader reader = new CSVReader();
            reader.OnFileCompleted += Reader_OnFileCompleted;
            var cars = reader.ReadFile(fileName);

            //foreach(var x in cars)
            //{
            //    Console.WriteLine(x.Year + " " + x.Name + " " + x.Manufacturer + " " + x.City);
            //}
        }

        private static void Reader_OnFileCompleted(int linecount, string manufactured)
        {
            Console.WriteLine(linecount + "\t" + manufactured);
        }
    }
}
