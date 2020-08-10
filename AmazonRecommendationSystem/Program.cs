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
            new PairString("item1","item2"),
            new PairString("item3","item4"),
            //new PairString("item5","item6"),
            new PairString("item4","item5")
            };
            Console.WriteLine(MaxItemAssociatoinGroup(input).Count);

        }
        public static List<string> MaxItemAssociatoinGroup(List<PairString> input)
        {
            if (input == null || input.Count == 0) return null;
            List<SortedSet<string>> tempList = new List<SortedSet<string>>();
            //Reversing to read the entire seqence so we do not miss any Associations that appear later.
            input.Reverse();
            foreach (var item in input)
            {
                if(!tempList.Any(x=> x.Contains(item.first) || x.Contains(item.second)))
                    tempList.Add(new SortedSet<string>() { item.first, item.second });
                else
                {
                    var existingSet = tempList.First(x => x.Contains(item.first) || x.Contains(item.second));
                    existingSet.Add(item.first);
                    existingSet.Add(item.second);
                }
            }

            var maxlistAssociation = tempList.OrderByDescending(x => x.Count).ThenBy(x => x).First();
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
}
