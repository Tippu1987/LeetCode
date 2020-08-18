using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsValidBST
{
    public class BSTIterator
    {

        TreeNode root = null;
        int[] nodes = null;
        int curIndex;
        Stack<TreeNode> tnodes = new Stack<TreeNode>();

        public BSTIterator(TreeNode root)
        {
            this.root = root;
            nodes = GetInorderList(root, new List<int>());
            curIndex = 0;
        }

        public void FlattenBST(TreeNode root)
        {
            if (root == null) return;
            InsertLeftNodes(root);
        }

        public void InsertLeftNodes(TreeNode r)
        {
            while (r != null)
            {
                tnodes.Push(r);
                r = r.left;
            }
        }

        public static int[] GetInorderList(TreeNode node, List<int> res)
        {
            if (node == null || res == null) return null;
            if (node.left != null)
                GetInorderList(node.left, res);
            res.Add(node.val);
            if (node.right != null)
                GetInorderList(node.right, res);
            return res.ToArray();
        }



        /** @return the next smallest number */
        public int Next()
        {
            //Give your Inorder Successor
            if (nodes?.Length == 0) return int.MinValue;
            else
                return nodes[curIndex++];
        }

        public int NextUsingStack()
        {
            TreeNode curnode = null;
            //Give your Inorder Successor
            if (tnodes.Any())
            {
                curnode = tnodes.Pop();
                InsertLeftNodes(curnode.right);
            }
            return curnode == null ? int.MinValue : curnode.val;
        }

        /** @return whether we have a next smallest number */
        public bool HasNext()
        {
            //Verifies if you have an Inorder Successor
            return curIndex < nodes?.Length;
        }

        public bool HasNextUsingStack()
        {
            //Verifies if you have an Inorder Successor
            return tnodes.Any();
        }
    }
}
