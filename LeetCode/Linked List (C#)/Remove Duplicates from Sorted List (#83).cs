using System;

namespace Problem
{
    class OOP
    {
        static void Main()
        {
            ListNode head = new ListNode(1); //1,1,2,3,3
            head.next = new ListNode(1);
            head.next.next = new ListNode(2);
            head.next.next.next = new ListNode(3);
            head.next.next.next.next = new ListNode(3);

            if(head == null) {System.Console.WriteLine("null");} // return null;
            ListNode RemoveDuplicates = new ListNode();
            ListNode temp = RemoveDuplicates;
            while(head.next != null)
            {
                if(head.val != head.next.val)
                {
                   temp.next = head;
                   temp = temp.next;
                }
                head = head.next;
            }
            temp.next = head;
            ShowInfo(RemoveDuplicates.next);  // return RemoveDuplicates.next;            
        }
        public static void ShowInfo(ListNode temp)
        {
            
            while(temp != null)
            {
                System.Console.Write($"{temp.val} ---> ");
                temp = temp.next;
            } 
            System.Console.WriteLine("NULL");
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}