using System;

namespace Binary_SearchAndOtherAlgos
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 0, 2, 3, 4, 10, 40, 44 };
            var bs = new BinarySearch();
            Console.WriteLine(bs.DoBinarySearchIterative(arr, 0, arr.Length,10));
        }
       
    }
}
