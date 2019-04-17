using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollingDie
{
    public class Zar
    {
        public delegate void ZarDel(string message);

        public event ZarDel More20;

        public event ZarDel TwoFour;

        public List<int> ZarList { get; set; } = new List<int>();

        public Zar(int count)
        {
            Random rd = new Random();
            for(int i = 0; i < count; ++i)
            {
                ZarList.Add(rd.Next(1, 7));
            }
        }

        public Zar() { }

        public void ShowList()
        {
            for (int i = 0; i < this.ZarList.Count; ++i)
            {
                Console.Write(this.ZarList[i] + "\t");
            }
            Console.WriteLine();
        }

        public void IsTwoFour()
        {
            int countOfFours = 0;
            for (int i = 0; i < this.ZarList.Count; ++i)
            {
                if(this.ZarList[i] == 4)
                {
                    ++countOfFours;
                }
            }
            if(countOfFours == 2)
            {
                TwoFour("Only two fours there are in row");
            }
        }
        public void IsMore20()
        {
            int sum = 0;
            for (int i = 0; i < this.ZarList.Count; ++i)
            {
                sum += this.ZarList[i];
            }
            if(sum >= 20)
            {
                More20("Sum of numbers more or equals 20");
            }
        }
    }
}
