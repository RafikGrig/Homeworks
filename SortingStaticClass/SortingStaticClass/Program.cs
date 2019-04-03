using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace SortingStaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============================================================");
            Console.Write("Please enter the size of an array that you want to sort: ");
            int len = int.Parse(Console.ReadLine());
            int[] array = ArrayRandomGeneration(len);
            ShowArray(array);
            Console.WriteLine("1. Insertion sort\n2. Bubble sort\n3. Merge sort\n4. All");
            Console.Write("Select which algorithm you want to perform: ");        
            string sortnumber = Console.ReadLine();            
            int[] copyarray1 = new int[len];
            int[] copyarray2 = new int[len];
            int[] copyarray3 = new int[len];
            for (int i = 0; i < len; i++)
            {
                copyarray1[i] = array[i];
                copyarray2[i] = array[i];
                copyarray3[i] = array[i];
            }
            if(sortnumber.Length==1)
            {
                switch(sortnumber[0])
                {
                    case '1':
                        TimeSpan ins = SortingArray.InsertionSort(copyarray1);                        
                        Console.WriteLine("Insertion sort" + "\ttime=" + ins);
                        ShowArray(copyarray1);
                        break;
                    case '2':                        
                        TimeSpan b = SortingArray.BubbleSort(copyarray2);                        
                        Console.WriteLine("Bubble sort" + "\ttime=" + b);                    
                        ShowArray(copyarray2);
                        break;
                    case '3':
                        Stopwatch stopWatchMer = new Stopwatch();
                        stopWatchMer.Start();
                        SortingArray.MergeSort(copyarray3,0,copyarray3.Length-1);
                        stopWatchMer.Stop();
                        TimeSpan m = stopWatchMer.Elapsed;
                        Console.WriteLine("Merge sort" + "\ttime=" + m);
                        ShowArray(copyarray3);
                        break;
                    case '4':                        
                        TimeSpan insTS = SortingArray.InsertionSort(copyarray1);
                        TimeSpan bubTS = SortingArray.BubbleSort(copyarray2);
                        Stopwatch sW = new Stopwatch();
                        sW.Start();
                        SortingArray.MergeSort(copyarray3, 0, copyarray3.Length - 1);
                        sW.Stop();
                        TimeSpan merTS = sW.Elapsed;

                        if (insTS == Min(insTS, bubTS, merTS))
                            Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Insertion sort" + "\ttime=" + insTS);
                        ShowArray(copyarray1);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (bubTS == Min(insTS, bubTS, merTS))
                            Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Bubble sort" + "\ttime=" + bubTS);
                        ShowArray(copyarray2);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (merTS == Min(insTS, bubTS, merTS))
                            Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Merge sort" + "\ttime=" + merTS);
                        ShowArray(copyarray3);
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    default:
                        Console.WriteLine("not corect input number");
                        break;
                }
            }
            else
            {
                if (sortnumber[1]=='-')
                {
                    for (int i = sortnumber[0]-48; i <= sortnumber[2]-48; i++)
                    {                        
                        switch(i)
                        {
                            case 1:
                                SortingArray.InsertionSort(copyarray1);
                                Console.WriteLine("Insertion sort");
                                ShowArray(copyarray1);
                                break;
                            case 2:
                                SortingArray.BubbleSort(copyarray2);
                                Console.WriteLine("Bubble sort");
                                ShowArray(copyarray2);
                                break;
                            case 3:
                                SortingArray.MergeSort(copyarray3, 0, copyarray3.Length - 1);
                                Console.WriteLine("Merge sort");
                                ShowArray(copyarray3);
                                break;                          
                            default:
                                Console.WriteLine("not corect input number");
                                break;
                        }
                    }
                }
                else
                {
                    for(int i=0; i  <sortnumber.Length; i++)
                    {
                        if (sortnumber[i] >= '1' && sortnumber[i] <= '3')
                        {
                            switch (sortnumber[i])
                            {
                                case '1':
                                    SortingArray.InsertionSort(copyarray1);
                                    Console.WriteLine("Insertion sort");
                                    ShowArray(copyarray1);
                                    break;
                                case '2':
                                    SortingArray.BubbleSort(copyarray2);
                                    Console.WriteLine("Bubble sort");
                                    ShowArray(copyarray2);
                                    break;
                                case '3':
                                    SortingArray.MergeSort(copyarray3, 0, copyarray3.Length - 1);
                                    Console.WriteLine("Merge sort");
                                    ShowArray(copyarray3);
                                    break;
                            }                     
                        }
                        else continue;
                    }
                }
            }       
        }
        static int[] ArrayRandomGeneration(int len)
        {
            Random rd = new Random();
            int[] array = new int[len];
            for (int i = 0; i < len; i++)
                array[i] = rd.Next(-50, 51);
            return array;
        }
        static void ShowArray(int[] a)
        {
            foreach (int x in a)
                Console.Write(x + "  ");
            Console.WriteLine();
        }        
        static TimeSpan Min(params TimeSpan[] t)
        {
            TimeSpan min = t[0];
            for(int i = 1; i<t.Length; i++)
            {
                if (t[i] < min)
                    min = t[i];
            }
            return min;
        }
    }
    static class SortingArray
    {
        static private void Swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }
        static public TimeSpan BubbleSort(int[] arr)
        {
            // GC.Collect();
            Stopwatch stopWatchBub = new Stopwatch();
            stopWatchBub.Start();
            int len = arr.Length;                        
            for (int i = 0; i < len - 1; i++)
            {
                bool b = true;
                for (int k = 0; k < len - 1 - i; k++)
                {
                    if (arr[k] > arr[k + 1])
                    {
                        Swap(ref arr[k], ref arr[k + 1]);
                        b = false;
                    }
                }
                if (b == true) break;
            }
            stopWatchBub.Stop();
            TimeSpan ts = stopWatchBub.Elapsed;
            return  ts;
            // long a = GC.GetTotalMemory(false);
            // Console.WriteLine(a);
        }
        static public TimeSpan InsertionSort(int[] arr)
        {
            //GC.Collect();
            //long a1 = GC.GetTotalMemory(false);
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int len = arr.Length;            
            for(int i=1;i<len;i++)
            {
                for(int j=i-1;j>-1;j--)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(ref arr[j], ref arr[j + 1]);                        
                    }
                    else break;
                }
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            return ts;
            //long a2 = GC.GetTotalMemory(false);
            //Console.WriteLine(a2-a1);
        }
        static public void MergeSort(int[] a, int first, int last)
        {
            if (first < last)
            {
                int mid = (first + last) / 2;
                MergeSort(a, first, mid);
                MergeSort(a, mid + 1, last);
                Merge(a, first, mid, last);
            }
        }
        static private void Merge(int[] a, int first, int mid, int last)
        {
            int first1 = first;
            int last1 = mid;
            int first2 = mid + 1;
            int last2 = last;
            int[] t = new int[a.Length];
            int i = first1;
            for (; first1 <= last1 && first2 <= last2; i++)
            {
                if (a[first1] < a[first2])
                {
                    t[i] = a[first1];
                    first1++;
                }
                else
                {
                    t[i] = a[first2];
                    first2++;
                }
            }
            for (; first1 <= last1; ++first1, ++i)
            {
                t[i] = a[first1];
            }
            for (; first2 <= last2; ++first2, ++i)
            {
                t[i] = a[first2];
            }
            for (int k = first; k <= last; k++)
                a[k] = t[k];
        }
    }
}
