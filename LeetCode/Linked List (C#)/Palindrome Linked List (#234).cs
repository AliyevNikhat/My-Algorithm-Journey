public class Solution {
    public bool IsPalindrome(ListNode head) {
            StringBuilder sb = new StringBuilder();
    
        while (head != null)
        {
            sb.Append(head.val);
            head = head.next;
        }

        int left = 0;
        int right = sb.Length - 1;

        while (left < right)
        {
            if (sb[left] != sb[right])
            {
                return false; 
            }
            left++;
            right--;
        }
        
        return true;
    }
}