using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Testers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * ["MyLinkedList","addAtHead","addAtTail","addAtIndex","get","deleteAtIndex","get"]
[[],[1],[3],[1,2],[1],[1],[1]] 
            */
            //[3,9,20,null,null,15,7]

            TreeNode r = new TreeNode(3, new TreeNode(9, null, null), new TreeNode(20, new TreeNode(15, null, null), new TreeNode(7, null, null)));
            TreeNode.LevelOrder(r);
        }
    }

    public class MyLinkedList
    {
        public Node Head, Tail;
        private int Size;
        /** Initialize your data structure here. */
        public MyLinkedList()
        {
            Head = Tail = null;
            Size = 0;
        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            if (index < 0 || index > Size) return -1;
            if (index == 0) return Head.Data;
            if (index == Size) return Tail.Data;
            Node ptr = Head;
            for (int i = 0; i < index; i++)
            {
                ptr = ptr.Next;
            }
            return ptr.Data;
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            if (Head == null)
            {
                Head = Tail = new Node(val);
            }
            else
            {
                Node newNode = new Node(val);
                newNode.Next = Head;
                Head = newNode;
            }
            Size++;
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            Node newNode = new Node(val);
            if (Tail == null)
            {
                Head = Tail = newNode;
            }
            else
            {
                Node ptr = Head;
                while (ptr.Next != null)
                {
                    ptr = ptr.Next;
                }
                ptr.Next = newNode;
                Tail = newNode;
            }
            Size++;
        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            if (index < 0 || index > Size) return;
            if (index == 0)
                AddAtHead(val);
            if (index == Size)
                AddAtTail(val);
            else
            {
                Node newNode = new Node(val);
                Node ptr = Head;
                for (int i = 0; i < index - 1; i++)
                {
                    ptr = ptr.Next;
                }
                Node temp = ptr.Next;
                ptr.Next = newNode;
                newNode.Next = temp;
            }
            Size++;
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            if (index < 0 || index > Size || Head == null) return;
            if (index == 0)
            {
                if (Size > 1)
                    Head = Head.Next;
                else if (Size == 1)
                    Head = Tail = null;
                else
                    return;
            }

            else if (index == Size)
            {
                Node ptr = Head;
                while (ptr.Next != Tail)
                {
                    ptr = ptr.Next;
                }
                Tail = ptr;
                Tail.Next = null;
            }
            else
            {
                Node ptr = Head;
                for (int i = 0; i < index - 1; i++)
                {
                    ptr = ptr.Next;
                }
                Node temp = ptr.Next;
                if (temp.Next == null)
                    ptr.Next = null;
                else
                {
                    ptr.Next = temp.Next;
                    temp = null;
                }

            }
            Size--;
        }
    }

    public class Node
    {
        public int Data;
        public Node Next;
        public Node(int val)
        {
            Data = val;
        }
    }

    /**
     * Your MyLinkedList object will be instantiated and called as such:
     * MyLinkedList obj = new MyLinkedList();
     * int param_1 = obj.Get(index);
     * obj.AddAtHead(val);
     * obj.AddAtTail(val);
     * obj.AddAtIndex(index,val);
     * obj.DeleteAtIndex(index);
     */

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public static IList<IList<int>> LevelOrder(TreeNode root)
        {
            if (root == null) return null;
            if (root.left == null && root.right == null)
            {
                List<IList<int>> ret = new List<IList<int>>();
                ret.Add(new List<int>(root.val));
                return ret;
            }
            
            Queue<TreeNode> LOT = new Queue<TreeNode>();
            List<IList<int>> output = new List<IList<int>>();
            List<TreeNode> tempList = new List<TreeNode>();
            
            LOT.Enqueue(root);
            while (LOT.Count > 0)
            {
                List<int> intres = new List<int>();
                while (LOT.Count > 0)
                {
                    TreeNode tmp = LOT.Dequeue();
                    if (tmp != null)
                    {
                        intres.Add(tmp.val);
                        tempList.Add(tmp.left);
                        tempList.Add(tmp.right);
                    }
                }
                output.Add(intres);
                tempList.ForEach(x => LOT.Enqueue(x));
                tempList.Clear();
            }
            return output.Where(x => x.Count > 0).ToList(); 
        }
    }
    

}
