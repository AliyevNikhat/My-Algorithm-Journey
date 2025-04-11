public class Solution {
    public int GetDecimalValue(ListNode head) {
        ListNode temp = head;
        string input = "";
        while(temp != null)
        {
            input += (temp.val).ToString();
            temp = temp.next;
        }
        int ConvertBinaryNumber = Convert.ToInt32(input, 2);
        return ConvertBinaryNumber;
    }
}