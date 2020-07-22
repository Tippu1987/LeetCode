 public static ListNode RotateRight(ListNode head, int k)
        {
            if (head == null || head.next == null) return head;
            ListNode ptr = head;
            int len = 0;
            while (ptr != null)
            {
                len++;
                ptr = ptr.next;
            }

            for (int i = 0; i < (k % len); i++)
            {
                head = RotateList(head);
            }
            return head;
        }
        public static ListNode RotateList(ListNode head)
        {
            ListNode ptr = head;
            while (ptr.next.next != null)
            {
                ptr = ptr.next;
            }
            ListNode newHead = ptr.next;
            ptr.next = null;
            newHead.next = head;
            return newHead;
        }

        public static string[] MostCommonWord(string paragraph, string[] banned)
        {
            paragraph = Regex.Replace(paragraph, @"[^a-zA-Z]", " ");
            HashSet<string> bannedwrds = new HashSet<string>(banned?.Select(x=>x.ToLowerInvariant()));
            var countDict = paragraph.Split(' ').GroupBy(x => x.ToLowerInvariant()).ToDictionary(x => x, y => y.Count()).OrderByDescending(x => x.Value);
            int retvalcount = 0;
            foreach (var item in countDict)
            {
                if (!bannedwrds.Contains(item.Key.Key) && !string.IsNullOrEmpty(item.Key.Key))
                {
                    retvalcount = item.Value;
                    break;
                }
            }
            return countDict.Where(x => x.Value == retvalcount && !string.IsNullOrEmpty(x.Key.Key) && !bannedwrds.Contains(x.Key.Key)).Select(x => x.Key.Key).ToArray();
        }

        public static IList<string> TopKFrequent(string[] words, int k)
        {
            if (words == null || words.Length == 0) return words;

            Dictionary<string, int> wordcount = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (wordcount.ContainsKey(word)) wordcount[word]++;
                else wordcount.Add(word, 1);
            }
            return wordcount.OrderByDescending(x => x.Value).ThenBy(x=>x.Key).Take(k).Select(x=>x.Key).ToList();
        }
