public class Solution {
    public ListNode RemoveElements(ListNode head, int val) {
        ListNode newList = new ListNode();
        ListNode temp = newList;
        while(head != null)
        {
            if(head.val == val)
            {
                temp.next = head.next;
                head = head.next;
            }
            else
            {
                temp.next = head;
                head = head.next;
                temp = temp.next;
            }
        }
        return newList.next;
    }
}