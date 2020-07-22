using System;
using System.Collections.Generic;

namespace MaxDepthOfBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        /// <summary>
        /// Given a binary tree, find its maximum depth.

        ///The maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.
        /// = Count of Level Order Traversal
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;
            if (root.left == null && root.right == null) return 1;
            return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
        }

        /// <summary>
        /// Level Order Traversal Iterative
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static IList<IList<int>> LevelOrder(TreeNode root)
        {
            List<IList<int>> output = new List<IList<int>>();
            /*if (root == null) return output;
                if (root.left == null && root.right == null)
                {
                    List<IList<int>> ret = new List<IList<int>>();
                    ret.Add(new List<int>(root.val));
                    return ret;
                }*/

            Queue<TreeNode> LOT = new Queue<TreeNode>();

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
