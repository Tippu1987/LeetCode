using System;

namespace HeapImplementation
{
    //Working Max Heap Code
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(stringcomp("1234","12345"));
        }

        public static int stringcomp(string s1, string s2)
        {
            //error check
            if (string.IsNullOrEmpty(s1) && string.IsNullOrEmpty(s2)) return 0; //Adding isnullorempty complexity
            if (string.IsNullOrEmpty(s1)) { if (s2.Length == 0) return 0; }
            if (string.IsNullOrEmpty(s2)) { if (s1.Length == 0) return 0; }


            //Assume the strings are stripped off of 0s in the beginning
            int num1 = 0;
            //for i=0 thru s1 && j=0 thru s2
            for (int i = 0; i < s1.Length; i++)
            {
                num1 = num1 * 10 + (s1[i] - '1' + 1);  //O(s1)
            }
            int num2 = 0;
            for (int i = 0; i < s2.Length; i++)
            {
                num2 = num2 * 10 + (s2[i] - '1' + 1);  //O(S2)
            }


            //O(1) below
            int result = int.MinValue;
            if (num1 < num2)
                result = -1;
            else if (num1 > num2)
                result = 1;
            else
                result = 0;
            //O(Max(s1,s2))
            return result;
        }

    }

    class Heap
    {
        int[] heap = null;
        int size;
        public Heap(int cap)
        {
            heap = new int[cap];
            size = 0;
        }

        public int GetLeftChild(int i) => heap[2 * i + 1];
        public int GetRightChild(int i) => heap[2 * i + 2];
        public int GetParent(int i) => heap[(i - 1) / 2];

        public int GetLeftChildIndex(int i) => 2 * i + 1;
        public int GetRightChildIndex(int i) => 2 * i + 2;
        public int GetParentIndex(int i) => (i - 1) / 2;


        private bool HasLeftChild(int i) => GetLeftChildIndex(i) < heap.Length;
        private bool HasRightChild(int i) => GetRightChildIndex(i) < heap.Length;
        private bool HasBothChilds(int i) => GetRightChildIndex(i) < heap.Length && GetLeftChildIndex(i) < heap.Length;
        private bool HasParent(int i) => GetParentIndex(i) >= 0;

        public void Insert(int element)
        {
            if (size >= heap.Length) return;
            heap[size] = element;
            int i = size;
            while (HasParent(i) && heap[i] > GetParent(i))
            {
                Swap(i, GetParentIndex(i));
                i = GetParentIndex(i);
            }
            size++;
        }

        public int Delete()
        {
            if (size < 0) return int.MaxValue;
            int element = heap[0];
            heap[0] = heap[--size];
            int k = 0;
            while (HasLeftChild(k))
            {
                int largerIndex = GetLeftChildIndex(k);
                if (HasRightChild(k) && heap[largerIndex] < heap[GetRightChildIndex(k)])
                    largerIndex = GetRightChildIndex(k);
                if (heap[k] < heap[largerIndex])
                {
                    Swap(k, largerIndex);
                    k = largerIndex;
                }
                else
                    break;
            }
            return element;
        }

        private void Swap(int i, int j)
        {
            int temp = heap[i];
            heap[i] = heap[j];
            heap[j] = temp;
        }

        public void PrintHeap()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{heap[i]},");
            }
        }

    }


}
