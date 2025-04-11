public class Solution {
    public ListNode MiddleNode(ListNode head) {
        double LinkedListCount = 0;
            ListNode temp = head;
            while(temp != null)
            {
                LinkedListCount++;
                temp = temp.next;
            }
            ListNode temp2 = head;
            
            double middle = Math.Ceiling(LinkedListCount / 2.0);
            System.Console.WriteLine(middle);
            while(middle > 1)
            {
                middle--;
                temp2 = temp2.next;
            }
            head = temp2;
            if(LinkedListCount %2 == 0)
            {
                return(head.next);
            }
            else
            {
                return(head);
            }
    }
}