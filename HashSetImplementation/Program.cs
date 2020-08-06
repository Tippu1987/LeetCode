using System;
using System.Collections.Generic;
using System.Linq;

namespace HashSetImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            //          ["MyHashSet","add","add","contains","contains","add","contains","remove","contains"]
            //[[],[1],[2],[1],[3],[2],[2],[2],[2]]
            var myhash = new MyHashSet();
            myhash.Contains(72);
            myhash.Remove(91);
            myhash.Add(48);
            myhash.Add(41);
            myhash.Contains(96);
            myhash.Remove(87);
            myhash.Contains(48);
        }
    }

    public class MyHashSet
    {
        private List<int>[] Buckets;
        private int bucketSize = 7919;

        /** Initialize your data structure here. */
        public MyHashSet()
        {
            Buckets = new List<int>[bucketSize];

            for (int i = 0; i < bucketSize; i++)
            {
                Buckets[i] = new List<int>();
            }
        }

        public void Add(int key)
        {
            int index = getHash(key);
            if (!Contains(key))
                Buckets[index].Add(key);
        }

        public void Remove(int key)
        {
            int index = getHash(key);
            Buckets[index].Remove(key);

        }

        /** Returns true if this set contains the specified element */
        public bool Contains(int key)
        {
            int index = getHash(key);
            return Buckets[index].Contains(key);
        }

        private int getHash(int val)
        {
            if (val >= 0)
            {
                return val % bucketSize;
            }
            return -1;
        }
    }
}
