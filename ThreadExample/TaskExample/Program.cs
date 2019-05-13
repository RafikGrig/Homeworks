using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskExample
{
    class Program
    {        
        static void Main(string[] args)
        {
            //my object wich contains array
            ClassArray arr = new ClassArray();

            //create 2 threads
            Thread trd1 = new Thread(new ParameterizedThreadStart(SumFirst));
            Thread trd2 = new Thread(new ParameterizedThreadStart(SumSecond));

            //starting threads and giving them object
            trd1.Start(arr);            
            trd2.Start(arr);

            //wait for ending my threads
            trd1.Join();
            //trd2.Join();  not necessary

            //summaring two parts of array and show
            Console.WriteLine(arr.SumFirst + arr.SumSecond);
        }

        //summaring first part of array
        static void SumFirst(object o)
        {            
                ClassArray obj = (ClassArray)o;
                obj.SumFirst = 0;

                for (int i = 0; i < obj.len / 2; i++)
                {
                    obj.SumFirst += obj[i];
                }                         
        }

        //summaring second part of array
        static void SumSecond(object o)
        {           
                ClassArray obj = (ClassArray)o;
                obj.SumSecond = 0;
                for (int i = obj.len / 2; i < obj.len; i++)
                {
                    obj.SumSecond += obj[i];
                }             
        }
    }
}
