using System;

namespace Symmetric_Tree
{
    class Program
    {
        /// <summary>
        /// Given a binary tree, check whether it is a mirror of itself (ie, symmetric around its center).
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null) return true;
            return AreSymmetric(root.left, root.right);
        }
        public bool AreSymmetric(TreeNode left, TreeNode right)
        {
            if (left == null && right == null) return true;
            if (left == null || right == null) return false;
            return (left.val == right.val) && AreSymmetric(left.right, right.left) && AreSymmetric(left.left, right.right);
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
}
