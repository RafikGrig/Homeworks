using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAttendance_ex1_WithFuncDel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();

            Func<string, string> func;

            if(name.Equals("Jack") || name.Equals("Steven") || name.Equals("Mathew"))
            {
                func = Banned;
            }
            else
            {
                func = Username;
            }

            Answer(name, func);
        }

        static void Answer(string name, Func<string,string> f)
        {
            Console.WriteLine(f(name)); 
        }

        static string Username(string name)
        {
            return $"Welcome {name}";
        }

        static string Banned(string name)
        {
            return $"{name}, you are Banned!!!";
        }
    }
}
