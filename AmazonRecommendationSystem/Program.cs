using System;
using System.Collections.Generic;
using System.Linq;

namespace AmazonRecommendationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PairString> input = new List<PairString> 
            {
            
            new PairString("item3","item4"),
            //new PairString("item5","item6"),
            new PairString("item4","item5"),
            new PairString("item5","item6"),

            new PairString("item1","item2"),
            new PairString("item7","item1"),
            new PairString("item2","item8")
            };
            //O(n^2) Algorithm
            Console.WriteLine(MaxItemAssociatoinGroup(input).Count);

        }
        public static List<string> MaxItemAssociatoinGroup(List<PairString> input)
        {
            if (input == null || input.Count == 0) return null;
            List<SortedSet<string>> output = new List<SortedSet<string>>();
            foreach (var item in input)
            {
                if (output.Any(x => x.Contains(item.first) || x.Contains(item.second)))
                {
                    //Take the set containing one or two or both items
                    var set1 = output.FirstOrDefault(x => x.Contains(item.first)); //O(n)
                    var set2 = output.FirstOrDefault(x => x.Contains(item.second)); //O(n)
                    if (set1 == null)
                        set2.UnionWith(new SortedSet<string> { item.first, item.second });

                    else if (set2 == null)
                        set1.UnionWith(new SortedSet<string> { item.first, item.second });

                    else if (set1 != set2)
                    {
                        set1.UnionWith(set2);
                        output.Remove(set2);
                    }
                }
                else
                    output.Add(new SortedSet<string>(new List<string>() { item.first, item.second }));
            }
            var maxlistAssociation = output.OrderBy(x => x, new SortedSetComparer<string>()).First();
            return new List<string>(maxlistAssociation);
        }
    }

   public class PairString
    {
        public string first;
        public string second;
        public PairString(string f, string s)
        {
            first = f;
            second = s;
        }
    }

    public class SortedSetComparer<T> : IComparer<SortedSet<T>> where T : IComparable<T>
    {
        public int Compare(SortedSet<T> x, SortedSet<T> y)
        {
            // Null checks
            if (x == null) return y == null ? 0 : 1;
            if (y == null) return -1;

            // First order by Count descending
            var countComparison = x.Count.CompareTo(y.Count);
            if (countComparison != 0) return countComparison * -1;

            // Then order lexically by comparing each item from one
            // set with the corresponding one in the other set
            var lexicalComparison = x.Select((item, index) =>
                x.ElementAt(index).CompareTo(y.ElementAt(index)))
                .FirstOrDefault(result => result != 0);

            return lexicalComparison == 0 ? countComparison : lexicalComparison;
        }
    }
}
