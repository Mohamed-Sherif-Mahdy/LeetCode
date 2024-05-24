/*
 * @lc app=leetcode id=206 lang=csharp
 *
 * [206] Reverse Linked List
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
ListNode ints;
public ListNode ReverseList(ListNode head) {
        ListNode pre=null;

        while(head!=null){
        var nxt=head.next;
        head.next=pre;
        pre=head;
        head=nxt;
        }
        return pre;

    }
}
// @lc code=end

