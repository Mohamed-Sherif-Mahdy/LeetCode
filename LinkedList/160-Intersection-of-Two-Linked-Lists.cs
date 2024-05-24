/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA,
     ListNode headB) {
        int LengthA=GetLength(headA);
        int LengthB=GetLength(headB);
        while(LengthA>LengthB){
            headA=headA.next;
            LengthA--;
        }
        while(LengthB>LengthA){
            headB=headB.next;
            LengthB--;
        }
        while(headA!=headB){
            headA=headA.next;
            headB=headB.next;
        }
        return headA;

    }

    public int GetLength(ListNode head){
        int counter=0;
        while(head!=null){
            counter+=1;
            head=head.next;
        }
        return counter;
    }
}