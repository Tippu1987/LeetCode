using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxHeightOfNarayTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node(1, new List<Node>());
            Node node2 = new Node(2);
            Node node3 = new Node(3, new List<Node>());
            Node node4 = new Node(4);
            Node node5 = new Node(5);
            Node node6 = new Node(6);

            root.children.Add(node3);
            root.children.Add(node2);
            root.children.Add(node4);
            node3.children.Add(node5);
            node3.children.Add(node6);

            Console.WriteLine(MaxDepth(root));
        }

        public static int MaxDepth(Node root)
        {
            if (root == null) return 0;
            if (root.children == null || root.children.Count == 0) return 1;
            int maxHeight = 1;
            foreach (var child in root.children)
                maxHeight = Math.Max(maxHeight, 1 + MaxDepth(child));
            return maxHeight;
        }
    }

    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }
}
