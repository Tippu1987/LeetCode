using System;
using System.Collections.Generic;

namespace IsValidBST
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode();
            Console.Write(IsValidBST(root));
        }

        public static bool IsValidBST(TreeNode root)
        {
            int[] resultArray = GetInorderList(root, new List<int>());
            if (resultArray.Length > 1)
            {
                for (int i = 0; i + 1 < resultArray.Length; i++)
                {
                    if (resultArray[i] > resultArray[i + 1])
                        return false;
                }
            }
            return true;
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
    }

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
    }
}
