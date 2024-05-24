public class Solution {
ListNode nodes=new();
ListNode pointer=nodes;
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        while(list1!=null && list2!=null){
            if(list1.val<=list2.val){
                pointer.next=list1;
                list1=list1.next;
            }
            else{
                pointer.next=list2;
                list2=list2.next;
            }
            pointer=pointer.next;
           


        }
         if(list1==null & list2!=null) pointer.next=list2;
         else if(list2==null & list1!=null) pointer.next=list1;

       

       return nodes.next;
    }
}