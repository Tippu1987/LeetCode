using System;

namespace SumRootToLeaf
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(4);
            TreeNode node9 = new TreeNode(9);
            TreeNode node0 = new TreeNode(0);
            TreeNode node5 = new TreeNode(5);
            TreeNode node1 = new TreeNode(1);

            root.left = node9;
            root.right = node0;
            node9.left = node5;
            node9.right = node1;



            Solution s = new Solution();
            Console.WriteLine(s.SumNumbers(root));
        }

        public class Solution
        {
            int result = 0;
            public int SumNumbers(TreeNode root)
            {
                if (root == null) return 0;
                if (root.left == null && root.right == null) return root.val;
                Calculate(root, 0);
                return result;
            }
            public void Calculate(TreeNode node, int Sum)
            {
                if (node != null)
                {
                    Sum = Sum * 10 + node.val;
                    if (node.left == null && node.right == null)
                        result += Sum;
                    Calculate(node.left, Sum);
                    Calculate(node.right, Sum);
                }
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
}
