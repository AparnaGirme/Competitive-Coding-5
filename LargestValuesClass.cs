/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution
{
    public IList<int> LargestValues(TreeNode root)
    {
        IList<int> result = new List<int>();
        if (root == null)
        {
            return result;
        }

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        { // 9
            int max = Int32.MinValue;
            int size = queue.Count;
            while (size > 0)
            {   //3     
                TreeNode node = queue.Dequeue();
                max = Math.Max(max, node.val);
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
                size--;
            }
            result.Add(max);    //1, 3, 9
        }
        return result;
    }
}