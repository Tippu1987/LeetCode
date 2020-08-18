using System;
using System.Collections.Generic;
using System.Text;

namespace IsValidBST
{
    public class BSTIterator
    {

        TreeNode root = null;
        int[] nodes = null;
        int curIndex;

        public BSTIterator(TreeNode root)
        {
            this.root = root;
            nodes = GetInorderList(root, new List<int>());
            curIndex = 0;
        }

        /* public int[] FlattenBST(TreeNode root){
             if(root==null) return new int[1];
             Stack<TreeNode> tnodes=new Stack<TreeNode>();
             tnodes.Push(root);
             while(tnodes.Count>0 || root!=null){
                 root=tnodes.Pop();
                 while(root!=null){
                     if(root.left!=null){
                         tnodes.Push(root);
                         root=root.left;
                     }
                     else{
                         nodes[nodes.Length++]=root.val;
                         root=root.right;
                     }
                 }

             }
         }*/

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

        /** @return whether we have a next smallest number */
        public bool HasNext()
        {
            //Verifies if you have an Inorder Successor
            return curIndex < nodes?.Length;
        }
    }
}
