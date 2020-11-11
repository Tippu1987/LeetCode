using System;
using System.Collections.Generic;

namespace Add2Nums2
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode(5);
            ListNode l2 = new ListNode(5);
            var x = new Solution().AddTwoNumbers(l1, l2);
            Console.WriteLine(x.val);
        }
    }

    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            //l1=7->2 && l2=5->6
            if (l1 == null || l2 == null) return null;
            var s1 = new Stack<int>();
            var s2 = new Stack<int>();
            ListNode t1 = l1, t2 = l2;
            while (t1 != null || t2 != null)
            {
                if (t1 != null)
                {
                    s1.Push(t1.val);
                    t1 = t1.next;
                }
                if (t2 != null)
                {
                    s2.Push(t2.val);
                    t2 = t2.next;
                }
            }
            int num1 = 0, num2 = 0, carry = 0;
            ListNode k = null;
            while (s1.Count > 0 || s2.Count > 0 || carry>0)
            {

                if (s1.Count > 0)
                    num1 = s1.Pop();
                if (s2.Count > 0)
                    num2 = s2.Pop();
                int sum = (num1 + num2 + carry);
                carry = sum / 10;
                sum %= 10;

                var x = new ListNode(sum);
                x.next =k;
                k = x;
                num1 = num2 = 0;
            }
            return k;
        }

        private ListNode calcsum(ListNode a, ListNode b)
        {
            if (a == null && b == null) return new ListNode(0);
            var sum = a.val + b.val;
            if (sum >= 10)
            {
                var res = new ListNode(sum % 10);
                var k = new ListNode(calcsum(a, b).val + 1);
                k.next = res;
                return k;
            }
            else
            {
                var res = new ListNode(sum);
                return res;
            }
        }

        private int getlen(ListNode l)
        {
            int len = 0;
            ListNode tmp = l;
            while (tmp != null)
            {
                len++;
                tmp = tmp.next;
            }
            return len;
        }
        private ListNode advanceptr(ListNode l, int k)
        {
            ListNode tmp = l;
            while (k > 0)
            {
                tmp = tmp.next;
                k--;
            }
            return tmp;
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
}
