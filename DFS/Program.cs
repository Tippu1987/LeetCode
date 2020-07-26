using System;
using System.Collections;
using System.Collections.Generic;

namespace DFS
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node(1, new Node(2, new Node(4, new Node(8, null, null), new Node(9, null, null)), new Node(5, null, null)),
                new Node(3, new Node(6, new Node(10, null, null), null), new Node(7, new Node(11, null, null), null)));
            //DoDFS(root, 10);
            Queue<Node> dfsq = new Queue<Node>();
            dfsq.Enqueue(root);
            DoBFT(root, dfsq);

        }

        static void DoDFT(Node root)
        {
            if (root == null) return;
            if (root.left == null && root.right == null)
            {
                Console.Write($"{root.value}->");
                return;
            }
            Console.Write($"{root.value}->");
            DoDFT(root.left);
            DoDFT(root.right);
        }

        static void DoDFS(Node root, int search)
        {
            if (root == null) return;
            if (root.left == null && root.right == null)
            {
                if (root.value == search) Console.WriteLine(root.value);
            }
            else
            {
                DoDFS(root.left, search);
                DoDFS(root.right, search);
            }
        }
        static void DoBFT(Node root, Queue<Node> nq)
        {
            if (nq.Count == 0 || root == null) return;
            root = nq.Dequeue();
            Console.Write($"{root.value}->");
            if (root.left != null) nq.Enqueue(root.left);
            if (root.right != null) nq.Enqueue(root.right);
            DoBFT(root, nq);
        }
    }

    class Node
    {
        public int value;
        public Node left;
        public Node right;
        public Node(int val, Node lft, Node right)
        {
            value = val;
            left = lft;
            this.right = right;
        }
    }
}
