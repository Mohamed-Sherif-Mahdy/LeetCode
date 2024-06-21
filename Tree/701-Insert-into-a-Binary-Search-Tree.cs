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
    public TreeNode InsertIntoBST(TreeNode root, int val) {
                if(root is null) 
        return new TreeNode(val);
        TreeNode head=root;
        while(head is not null){
        if(head.val<val){
            if(head.right is null)
            {
                head.right = new TreeNode(val);
                return root;
            }
            else
            head=head.right;
        }
        else if(head.val>val){
            if(head.left is null)
            {
                head.left = new TreeNode(val);
                return root;
            }
            else
            head=head.left;
        }
        else return root;
        
        }

        return root;
    }
}