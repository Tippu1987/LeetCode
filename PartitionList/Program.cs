using System;
using System.Net.Http.Headers;

namespace PartitionList
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(4);
            head.next.next= new ListNode(3);
            head.next.next.next= new ListNode(2);
            head.next.next.next.next= new ListNode(5);
            head.next.next.next.next = new ListNode(2);
            Console.WriteLine(new Solution().Partition(head, 3).val);
        }
    }


    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class Solution
    {
        public ListNode Partition(ListNode head, int x)
        {
            if (head == null || head.next == null) return head;
            ListNode l = null, r = null, lp = l, rp = r, temp = head;
            while (temp != null)
            {
                if (temp.val < x)
                {
                    if (l == null)
                        l = new ListNode(temp.val);
                    else
                    {
                        l.next = new ListNode(temp.val);
                        l = l.next;
                    }
                }
                else
                {
                    if (r == null)
                        r = new ListNode(temp.val);
                    else
                    {
                        r.next = new ListNode(temp.val);
                        r = r.next;
                    }
                }
                temp = temp.next;
            }
            l.next = rp;
            return lp;

        }
    }
}
