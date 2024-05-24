/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        ListNode fast=head;
        
        ListNode slow=head;
        while(head!=null){
            fast=fast.next;
           
            if(fast==slow) return true;
            fast=fast.next;
            if(fast==slow) return true;
            slow=slow.next;
            
           
        }
        return false;
        
    }
}