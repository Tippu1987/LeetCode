using System;
using System.Collections.Generic;
using System.Linq;

namespace BTreeConstructionFromInorderPostOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inorder = new int[] { 9, 3, 15, 20, 7 };
            //int[] inorder = new int[] { 4, 8, 2, 5, 1, 6, 3, 7 };
            // int[] postorder = new int[] { 9, 15, 7, 20, 3 };
            int[] postorder = new int[] { 9, 15, 7, 20, 3 };
            var res = TreeNode.BuildTree(inorder, postorder);
            Console.WriteLine(res.val);
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

        public static TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            //     if (inorder == null || postorder == null || inorder.Length == 0 || postorder.Length == 0) return null;
            //     if (inorder.Length == 1) return new TreeNode(inorder[0]);
            //     if (postorder.Length == 1) return new TreeNode(postorder[0]);

            //     List<int> inorderList = inorder.ToList();
            //     List<int> postorderlist = postorder.ToList();

            //     int rootIndex = postorderlist.Count - 1;
            //     TreeNode root = new TreeNode(postorderlist[rootIndex]);

            //     int inorderrootIndex = inorderList.IndexOf(postorderlist[rootIndex]);
            //     List<int> inorderSubList = inorderList.GetRange(0, inorderrootIndex);
            //     List<int> postOrderSubList = postorderlist.GetRange(0, inorderrootIndex);

            //     root.left = BuildTree(inorderSubList.ToArray(), postOrderSubList.ToArray());

            //     inorderSubList = inorderList.GetRange(inorderrootIndex+1, inorderList.Count- (inorderrootIndex + 1));
            //     postOrderSubList = postorderlist.GetRange(inorderrootIndex, postorderlist.Count - inorderrootIndex-1);

            //     root.right = BuildTree(inorderSubList.ToArray(), postOrderSubList.ToArray());
            //     return root;
            return Helper(inorder, postorder, 0, inorder.Length - 1, postorder.Length - 1);

        }

        public static TreeNode BuildTreeFromPreOrder(int[] preorder, int[] inorder)
        {
            if (inorder == null || preorder == null || inorder.Length == 0 || preorder.Length == 0) return null;
            if (inorder.Length == 1) return new TreeNode(inorder[0]);
            if (preorder.Length == 1) return new TreeNode(preorder[0]);

            List<int> inorderList = inorder.ToList();
            List<int> preOrderList = preorder.ToList();

            int rootIndex = 0;
            TreeNode root = new TreeNode(preOrderList[rootIndex]);

            int inorderrootIndex = inorderList.IndexOf(preOrderList[rootIndex]);
            List<int> inorderSubList = inorderList.GetRange(0, inorderrootIndex);
            List<int> preOrderSubList = preOrderList.GetRange(1, preOrderList.Count - 1);

            root.left = BuildTreeFromPreOrder(preOrderSubList.ToArray(), inorderSubList.ToArray());

            inorderSubList = inorderList.GetRange(inorderrootIndex + 1, inorderList.Count - (inorderrootIndex + 1));
            preOrderSubList = preOrderList.GetRange(1 + inorderrootIndex, preOrderList.Count - 1 - inorderrootIndex);

            root.right = BuildTreeFromPreOrder(preOrderSubList.ToArray(), inorderSubList.ToArray());
            return root;

        }

        /// <summary>
        /// Better Implementation as per LeetCode
        /// </summary>
        /// <param name="inorder"></param>
        /// <param name="postorder"></param>
        /// <param name="idxInstart"></param>
        /// <param name="idxInEnd"></param>
        /// <param name="idxPost"></param>
        /// <returns></returns>
        private static TreeNode Helper(int[] inorder, int[] postorder, int idxInstart, int idxInEnd, int idxPost)
        {
            if (idxPost < 0 || idxInstart > idxInEnd)
                return null;

            TreeNode root = new TreeNode(postorder[idxPost]); ;

            int i = idxInstart;

            for (; i < idxInEnd; i++)
                if (inorder[i] == root.val)
                    break;

            root.left = Helper(inorder, postorder, idxInstart, i - 1, idxPost - 1 - (idxInEnd - i)); ;
            root.right = Helper(inorder, postorder, i + 1, idxInEnd, idxPost - 1);

            return root;
        }
    }


}
