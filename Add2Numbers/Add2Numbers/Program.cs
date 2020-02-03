using System;

namespace Add2Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node1 = new Node(2);
            Node node2 = new Node(4);
            Node node3 = new Node(3);

            Node node4 = new Node(5);
            Node node5 = new Node(6);
            Node node6 = new Node(4);

            node1.next = node2;
            node2.next = node3;
            node3.next = null;

            node4.next = node5;
            node5.next = node6;
            node6.next = null;

            Node num1 = node1;
            Node num2 = node4;
            /*while (itr != null)
            {
                Console.Write($"{itr.value}-->");
                itr = itr.next;
            }
            Console.WriteLine();
            itr = node4;
            while (itr != null)
            {
                Console.Write($"{itr.value}-->");
                itr = itr.next;
            }*/
            int carry = 0;
            while(num1!=null || num2 != null)
            {

            }

        }
    }

    public class Node
    {
        public int value;
        public Node next;
        public Node(int val)
        {
            value = val;
        }
    }
}
