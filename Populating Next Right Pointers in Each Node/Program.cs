using System;
using System.Collections.Generic;

namespace Populating_Next_Right_Pointers_in_Each_Node
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root1 = new Node(1);
            Node root2 = new Node(2);
            Node root3 = new Node(3);
            Node root4 = new Node(4);
            Node root5 = new Node(5);
            Node root6 = new Node(6);
            Node root7 = new Node(7);
            Node root8 = new Node(8);
            root1.left = root2;
            root1.right = root3;
            root3.right = root6;
            root2.left = root4;
            root2.right = root5;
            root4.left = root7;
            root6.right = root8;
            var x = Connect(root1);
        }

        public static Node Connect(Node root)
        {
            if (root == null) return null;
            if (root.left == null && root.right==null) return root;
            root.left.next = root.right;
            Connect(root.left);
            Connect(root.right);
            Helper(root.left, root.right);
            return root;
        }
        private static void Helper(Node leftptr, Node rightptr)
        {
            if (leftptr == null) return;
            if (leftptr.left != null)
            {
                leftptr.left.next = rightptr;
                return;
            }
            leftptr.next = rightptr;
            leftptr = leftptr.right;
            rightptr = rightptr.left;
            Helper(leftptr, rightptr);
        }
        //private static void Helper(Node leftptr, Node rightptr)
        //{
        //    if (leftptr == null) return;
        //    if (leftptr.left == null)
        //    {
        //        leftptr.next = rightptr;
        //        return;
        //    }
        //    leftptr.next = rightptr;
        //    leftptr = leftptr.right;
        //    rightptr = rightptr.left;
        //    Helper(leftptr, rightptr);
        //}
    }
    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, Node _left, Node _right, Node _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }
}
