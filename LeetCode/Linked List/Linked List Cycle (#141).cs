public class Solution {
    public bool HasCycle(ListNode head) {
        if(head == null)
        {
            return false;
        }
        HashSet<ListNode> current = new HashSet<ListNode>();
        ListNode temp = head;
        while(temp != null)
        {
            if(current.Contains(temp))
            {
                return true;
            }
            current.Add(temp);
            temp = temp.next;
        }
        return false;
    }
}