namespace _110._Balanced_Binary_Tree
{
    internal class Program
    {
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
        
        static public int MaxDepth(TreeNode root) //,int depth = 0)
        {
            return (root != null) ? Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1 : 0;
        }
        static public bool IsBalanced(TreeNode root)
        {
            if (root == null) return true;
            if (Math.Abs(MaxDepth(root.left) - MaxDepth(root.right)) > 1) return false;
            return IsBalanced(root.left) && IsBalanced(root.right);
        }
        static void Main(string[] args)
        {
           ;
        }
    }
}