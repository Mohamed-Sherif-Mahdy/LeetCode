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
public class Solution {
     List<int> answer=new();
       public IList<int> InorderTraversal(TreeNode root) {
       
        //base case
        if(root is null) return answer;

       

        //traverse
        else{
        InorderTraversal(root.left);
        answer.Add(root.val);
        InorderTraversal(root.right);
        }
        return answer;
    }
}