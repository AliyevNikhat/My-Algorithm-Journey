public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode prev = null, current = head; 
        while(current != null)
        {
            ListNode temp = current.next; 
            current.next = prev; 
            prev = current; 
            current = temp; 
        } 
        return prev;
    }
}