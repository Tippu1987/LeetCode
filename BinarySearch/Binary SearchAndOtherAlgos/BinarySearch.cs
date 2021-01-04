using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_SearchAndOtherAlgos
{
    public class BinarySearch
    {
        public int DoBinarySearch(int[] arr, int left, int right, int element)
        {
            if (left > right)
                return  -1;

            int mid = left + ((right - left) / 2);
            if (element == arr[mid])
                return arr[mid];
            else
                return (element < arr[mid]) ? DoBinarySearch(arr, 0, mid, element) : DoBinarySearch(arr, mid + 1, right, element);
        }

        public int DoBinarySearchIterative(int[] arr, int left, int right, int element)
        {
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == element)
                    return arr[mid];
                else if (element < arr[mid])
                    right = mid;
                else
                    left = mid + 1;
            }
            return -1;
        }
    }
}
