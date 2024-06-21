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
    public TreeNode DeleteNode(TreeNode root, int key) {
        if(root is null) return null;
        else if(root.val<key)
        root.right=DeleteNode(root.right,key);
        else if(root.val>key)
        root.left=DeleteNode(root.left,key);
        else{
            if(root.right==null)
            return root.left;
            if(root.left==null)
            return root.right;
            else{
                TreeNode curr=root.right;
                while(curr.left is not null){
                    curr=curr.left;
                }
                root.val=curr.val;
                root.right = DeleteNode(root.right,root.val);

            }
        }
            return root;

    }
}