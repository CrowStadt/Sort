using System;
using System.Collections;

namespace Skinwalkers
{
    static class Program
    {
        static int get_biggest_num(ArrayList arr)
        {
            int biggest_num = 0;
            foreach(int num in arr)
            {
                if(biggest_num < num)
                {
                    biggest_num = num;
                }
            }
            return biggest_num;
        }
        static ArrayList sort(ArrayList arr, ArrayList sortarr)
        { 
            sortarr.Add(get_biggest_num(arr));
            arr.Remove(get_biggest_num(arr));
            if(arr.Count == 0)
            {
                return sortarr;
            }
            else
            {
                return sort(arr, sortarr);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Gar gar gar!");
            ArrayList Arr = new ArrayList() { 2, 2, 4, 7, 2, 7, 10, 9 };
            Console.WriteLine(get_biggest_num(Arr));
            ArrayList SortedArray = new ArrayList();
            SortedArray = sort(Arr, SortedArray);
            Console.WriteLine("Sorting Time");
            foreach(int UwU in SortedArray)
            {
                Console.WriteLine(UwU);
            }
        }
    }
}
