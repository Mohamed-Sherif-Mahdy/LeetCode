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
    List<int> numbers=new();
    int count=0;
    public int KthSmallest(TreeNode root, int k) {
        
        traverse(root,k);
        return numbers[k-1];
    
       
       }
       public void traverse(TreeNode root,int k){
        if(root is null) return;
        traverse(root.left,k);
        numbers.Add(root.val);
        count+=1;
        if(k==count) return;
        traverse(root.right,k);
        return;
       }
}