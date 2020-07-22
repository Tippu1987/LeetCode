using System;

namespace Add2Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 17, 18, 5, 4, 6, 1 };
            Console.WriteLine(string.Join(',', ReplaceElements(array)));
        }

        public static int[] ReplaceElements(int[] arr)
        {
            if (arr == null || arr.Length == 0) return null;
            else
            {
                for (int i = arr.Length - 1, j = 0; i > j; i--, j++)
                {
                    int currmax = arr[i], curi = i, curj = j;

                    while (curi > curj)
                    {
                        if (currmax < arr[curi])
                            currmax = arr[curi--];
                    }
                    arr[curj] = currmax;
                }
                arr[arr.Length - 1] = -1;
                return arr;
            }
        }
    }

    
}
