using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBand
{
    class Program       
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose \nAdd, \nAnnounce, \nQuit, \nNoun");
            var action = Console.ReadLine();
            Actions myaction = (Actions)Enum.Parse(typeof(Actions),action);

            

            switch (myaction)
            {
                case Actions.Add:
                    break;
                case Actions.Announce:
                    break;
                case Actions.Quit:
                    break;
                case Actions.Noun:
                    break;
                default:
                    break;
            }

            Console.WriteLine("Please enter the name of the venue");
            Venue venue = new Venue();
            venue.Name = Console.ReadLine();
            Band band = new Band();
            Console.WriteLine("Please enter the name of the band");
            band.Name = Console.ReadLine();
            Console.WriteLine("Please enter the name of band genre");
            band.Genre = Console.ReadLine();
            band.AddMusicians();
            //venue.AddBand();

        }
    }
}
