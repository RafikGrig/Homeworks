using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RollingDie
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 50; ++i)
            {
                var z = new Zar(5);
                z.ShowList();
                z.TwoFour += Show_Message;
                z.More20 += Show_Message;
                z.IsTwoFour();
                z.IsMore20();
                Thread.Sleep(1000);
            }
            
        }

        private static void Show_Message(string message)
        {
            Console.WriteLine(message);
        }
    }
}
