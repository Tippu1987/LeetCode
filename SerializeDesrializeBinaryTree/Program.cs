using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace SerializeDesrializeBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(5);
            TreeNode node2 = new TreeNode(2);
            TreeNode node3 = new TreeNode(3);
            TreeNode node21 = new TreeNode(2);
            TreeNode node4 = new TreeNode(4);
            TreeNode node31 = new TreeNode(3);
            TreeNode node1 = new TreeNode(1);

            root.left = node2;
            root.right = node3;
            node3.left = node21;
            node3.right = node4;
            node21.left = node31;
            node21.right = node1;

            var serializeOutput = serialize(root);
            Console.WriteLine($"{serializeOutput}");
            var reconstructedroot = deserialize(serializeOutput);
            Console.WriteLine($"{reconstructedroot.val}");


        }

        public static string serialize(TreeNode root)
        {
            //Serializing the Tree using BFS..
            if (root == null) return "null";
            Queue<TreeNode> nodesq = new Queue<TreeNode>();
            List<TreeNode> tempList = new List<TreeNode>();
            string result = string.Empty;
            nodesq.Enqueue(root);
            while (nodesq.Count > 0)
            {
                while (nodesq.Count > 0)
                {
                    TreeNode temp = nodesq.Dequeue();
                    result += temp == null ? "null," : temp.val + ",";
                    if (temp == null)
                        tempList.Add(null);
                    else
                        tempList.Add(temp.left);
                    if (temp != null)
                        tempList.Add(temp.right);
                    else
                        tempList.Add(null);
                }
                if (tempList.Any(x => x != null))
                    tempList.ForEach(x => nodesq.Enqueue(x));
                tempList.Clear();
            }
            return result;
        }

        public static string serializeRecursive(TreeNode root)
        {
            //Does not work
            if (root == null) return "null,";
            return new StringBuilder(root.val + "," + serializeRecursive(root.left) + serializeRecursive(root.right)).ToString();
        }

        //Decodes your encoded data to tree.
        public static TreeNode deserialize(string data)
        {
            if (string.IsNullOrEmpty(data)) return null;
            string[] valuesArray = data.Split(',', StringSplitOptions.RemoveEmptyEntries);
            TreeNode root = valuesArray[0] == "null" ? null : new TreeNode(Convert.ToInt32(valuesArray[0]));
            return Helper(root, 0, valuesArray);
        }
        private static TreeNode Helper(TreeNode node, int index, string[] values)
        {
            if (node == null) return node;
            string nullString = "null";
            int leftIndex = 2 * index + 1;
            int rightIndex = 2 * index + 2;
            if (values[index] != nullString && rightIndex < values.Length)
            {
                node.left = values[leftIndex] != nullString ? new TreeNode(Convert.ToInt32(values[leftIndex])) : null;
                node.right = values[rightIndex] != nullString ? new TreeNode(Convert.ToInt32(values[rightIndex])) : null;
            }
            Helper(node.left, leftIndex, values);
            Helper(node.right, rightIndex, values);
            return node;
        }

        #region LeetCodeWroking Code
        public static string serializeWorking(TreeNode root)
        {
            StringBuilder sb = new StringBuilder();
            DFS(root, sb);
            return sb.ToString();
        }
        private static void DFS(TreeNode x, StringBuilder sb)
        {
            if (x == null)
            {
                sb.Append("null ");
                return;
            }
            sb.Append(Convert.ToInt16(x.val));
            sb.Append(' ');
            DFS(x.left, sb);
            DFS(x.right, sb);
        }

        // Decodes your encoded data to tree.
        public static TreeNode deserializeWorking(String data)
        {
            String[] node = data.Split(" ");
            int[] d = new int[1];
            return DFS(node, d);
        }
        private static TreeNode DFS(String[] node, int[] d)
        {
            if (node[d[0]].Equals("null"))
            {
                d[0]++;
                return null;
            }
            TreeNode x = new TreeNode(Convert.ToInt16(node[d[0]]));
            d[0]++;
            x.left = DFS(node, d);
            x.right = DFS(node, d);
            return x;
        }

        #endregion
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}
