using System;

namespace SymmetricTree
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsSymmetric(TreeNode root)
            {
                if (root.left == null && root.right == null) return true;
                if(root.left == null || root.right == null) return false;
                return Compare(root.left, root.right);
            }

            bool Compare(TreeNode left, TreeNode right)
            {
                if (left == null || right == null) return false;
                if (left == null && right == null) return true;
                if(left.val!=right.val) return false;

                return Compare(left.left, right.right) && Compare(left.right, right.left);
            }

        }
    }
}
