using System;

namespace HeapImplementation
{
    //Working Max Heap Code
    class Program
    {
        static void Main(string[] args)
        {
            Heap h = new Heap(50);
            h.Insert(7);
            h.Insert(2);
            h.Insert(1);
            h.Insert(25);
            h.Insert(3);
            h.Insert(17);
            h.Insert(36);
            h.Insert(19);
            h.Insert(100);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(h.Delete());
            h.PrintHeap();
            Console.WriteLine("-----------------------------------");
            Console.Write(h.Delete());
            Console.WriteLine("-----------------------------------");
            h.PrintHeap();
            Console.WriteLine("-----------------------------------");
            Console.Write(h.Delete());
            Console.WriteLine("-----------------------------------");
            h.PrintHeap();
            Console.Write(h.Delete());
            Console.WriteLine("-----------------------------------");
            h.PrintHeap();
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
