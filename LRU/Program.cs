using System;
using System.Collections.Generic;

namespace LRU
{
    class Program
    {
        static void Main(string[] args)
        {
            LRUCache c = new LRUCache(1);
            c.Put(2,1);
            Console.WriteLine(c.Get(2));
            c.Put(3,2);
            Console.WriteLine(c.Get(2));
            Console.WriteLine(c.Get(3));
        }
    }

    public class LRUCache
    {
        LinkedList<CacheItem> PrList = null;
        Dictionary<int, CacheItem> LRU = null;
        int PrCapacity = 0;
        public LRUCache(int capacity)
        {
            PrCapacity = capacity;
            PrList = new LinkedList<CacheItem>();
            LRU = new Dictionary<int, CacheItem>(capacity);
        }

        public int Get(int key)
        {
            if (LRU.ContainsKey(key))
            {
                var k = LRU[key];
                MoveFront(k);
                return k.number;
            }
            else
                return -1;
        }

        public void Put(int key, int value)
        {
            if (LRU.ContainsKey(key))
            {
                var k = LRU[key];
                k.number = value;
                MoveFront(k);
            }
            else
            {
                var k = new CacheItem(value, key);
                if (LRU.Count >= PrCapacity)
                {
                    LRU.Remove(PrList.Last.Value.key);
                    PrList.RemoveLast();
                }
                PrList.AddFirst(k);
                LRU.Add(key, k);
            }
        }

        private void MoveFront(CacheItem item)
        {
            var cur = PrList.Find(item);
            PrList.Remove(item);
            PrList.AddFirst(cur);
            
        }
    }

    public class CacheItem
    {
        public int number;
        public int key;

        public CacheItem(int num, int key)
        {
            number = num;
            this.key = key;
        }
    }
}
