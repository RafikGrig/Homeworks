using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToAcronym_ex2
{
    static class Acronym
    {
        public static string ConvertToAcronym(string phrase)
        {
            string acronym = String.Empty; 
            string temp = String.Empty;

            // find each word of phrase and to add acronym his first letter uppercase
            for (int i = 0; i < phrase.Length; i++)
            {
                if((phrase[i] >= 'a' && phrase[i] <= 'z') || (phrase[i] >= 'A' && phrase[i] <= 'Z'))
                {
                    temp += phrase[i];
                }
                else
                {
                    if(temp.Length != 0)
                    {
                        acronym += Char.ToUpper(temp[0]);
                        temp = String.Empty;
                    }                    
                }
            }
            // add first letter of last word 
            if(temp.Length != 0)
            {
                acronym += Char.ToUpper(temp[0]);
            }
            
            return acronym;
        }
    }
}
