using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace NaryTreePreOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node(44, new List<Node>());
            Node node2 = new Node(2);
            Node node3 = new Node(3, new List<Node>());
            Node node4 = new Node(4);
            Node node5 = new Node(5);
            Node node6 = new Node(6);

            //node3.children.Add(node5);
            //node3.children.Add(node6);

            //root.children.Add(node3);
            //root.children.Add(node2);
            //root.children.Add(node4);

            var x = LevelOrder(root);


        }

        //Accepted Solution by Pavan...
        public static IList<int> Preorder(Node root)
        {
            if (root == null) return new List<int>();
            if (root.children.Count == 0) return new List<int>() { root.val };
            Stack<Node> stak = new Stack<Node>();
            stak.Push(root);
            List<int> result = new List<int>();
            while (stak.Count > 0)
            {
                Node temp = stak.Pop();
                if (temp != null)
                {
                    result.Add(temp.val);
                    if (temp.children != null && temp.children.Count > 0)
                    {
                        foreach (var x in temp.children.Reverse())
                            stak.Push(x);
                    }
                }
            }
            return result;
        }

        public static IList<int> PreorderRecursive(Node root)
        {
            if (root == null) return new List<int>();
            if (root.children == null || root.children.Count == 0) return new List<int>() { root.val };
            List<int> result = new List<int>();
            result.Add(root.val);
            foreach (var item in root.children)
                result.AddRange(PreorderRecursive(item));
            return result;
        }

        //Working Code both Iterative & Recursive
        public static IList<int> PostOrder(Node root)
        {
            if (root == null) return new List<int>();
            if (root.children.Count == 0) return new List<int> { root.val };
            Stack<Node> stak = new Stack<Node>();
            List<int> result = new List<int>();
            stak.Push(root);
            while (stak.Count > 0)
            {
                Node temp = stak.Pop();
                if(temp!=null)
                {
                    result.Add(temp.val);
                    if(temp.children!=null)
                        foreach (var item in temp.children)
                            stak.Push(item);
                }
            }
            result.Reverse();
            return result;

        }

        public static IList<int> PostOrderRecursive(Node root)
        {
            if (root == null) return new List<int>();
            if (root.children == null || root.children.Count == 0) return new List<int> { root.val };
            List<int> res = new List<int>();
            if (root.children != null)
                foreach (var item in root.children)
                    res.AddRange(PostOrderRecursive(item));
            res.Add(root.val);
            return res;

        }

        public static IList<IList<int>> LevelOrder(Node root)
        {
            List<IList<int>> result = new List<IList<int>>();
            if (root == null) return result;
            if (root.children == null || root.children.Count == 0)
            {
                result.Add(new List<int> { root.val });
                return result;
            }
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                List<int> templist = new List<int>();
                List<Node> childs = new List<Node>();
                while (q.Count > 0)
                {
                    var tmp = q.Dequeue();
                    if (tmp != null)
                    {
                        templist.Add(tmp.val);
                        if (tmp.children != null) childs.AddRange(tmp.children);
                    }
                }
                result.Add(templist);
                childs.ForEach(x => q.Enqueue(x));
            }
            return result;
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
