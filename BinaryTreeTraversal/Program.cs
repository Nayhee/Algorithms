using System;
using System.Collections.Generic;

namespace BinaryTreeTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> InorderTraversal(TreeNode root)
            {
                List<int> answer = new List<int>();
                Stack<int> myStack = new Stack<int>();
                while(root != null || myStack.Count != 0)
                {
                    while(root != null)
                    {
                        myStack.Push(root.val);
                        root = root.left;
                    };
                    root.val = myStack.Pop();
                    answer.Add(root.val);
                    root = root.right;
                }
                return answer;
            }
        }
    }



    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left=null, TreeNode right=null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
