using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList<int> lst = new MyLinkedList<int>();

            lst.Add(4);
            lst.Add(41);
            lst.Add(42);
            lst.Add(47);
           lst.ShowNods();

            //foreach (var item in lst)
            //{
            //    Console.WriteLine(item);
            //}
            //IEnumeratorMy<int> tttt = lst.GetEnumerator();
            //bool flag = true;
            //while (flag) {

            //    Console.WriteLine(tttt.Current);
            //    flag = tttt.MoveNext();
            //}
            



        }
    }
}
