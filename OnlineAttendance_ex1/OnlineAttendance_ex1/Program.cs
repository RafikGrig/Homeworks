using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAttendance_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter name");
            string name = Console.ReadLine();

            // check username
            Action<string> act;
            if(name.Equals("Jack") || name.Equals("Steven") || name.Equals("Mathew"))
            {
                act = Banned;
            }
            else
            {
                act = Username;
            }

            // to answer user 
            Answer(name, act);
        }

        static void Answer(string name, Action<string> a)
        {
            a(name);
        }

        static void Username(string name)
        {
            Console.WriteLine($"Welcome {name}");
        }
        
        static void Banned(string name)
        {
            Console.WriteLine($"{name}, you are BANNED!!!");
        }
    }
}
