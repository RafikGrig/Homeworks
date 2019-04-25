using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToAcronym_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = " Compl``emen*tary me1tal-oxide sem!iconductor  "; // for testing "bad" phrase
            Console.WriteLine(Acronym.ConvertToAcronym(phrase));
        }
    }
}
