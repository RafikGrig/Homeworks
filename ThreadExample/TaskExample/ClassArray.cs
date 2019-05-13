using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskExample
{
    public class ClassArray
    {

        public int[] MyArray { get; set; }
        public readonly int len;
        //variables for saving sums of array parts
        public int SumFirst { get; set; }
        public int SumSecond { get; set; }

        // constuctor, create and initialize array
        // for easy, array initialize here (we can initialize in some method)
        public ClassArray()
        {
            Console.WriteLine("Please enter size of array");
            if(int.TryParse(Console.ReadLine(),out len))
            {
                MyArray = new int[len];
            }
            for (int i = 0; i < len; i++)
            {
                MyArray[i] = 1;
            }
        }        

        //indexator
        public int this[int index]
        {
            get
            {
                return MyArray[index];
            }
            set
            {
                MyArray[index] = value;
            }
        }

    }
}
