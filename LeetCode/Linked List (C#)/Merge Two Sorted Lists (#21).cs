using System;

namespace Problem
{
    class OOP
    {
        static void Main()
        {
            ListNode list1 = new ListNode(1);
            list1.next = new ListNode(2);
            list1.next.next = new ListNode(4);

            ListNode list2 = new ListNode(1);
            list2.next = new ListNode(3);
            list2.next.next = new ListNode(4);

            ListNode MergeTwoSortedList = new ListNode();
            ListNode node = MergeTwoSortedList;
            while(list1 != null && list2 != null)
            {
                if(list1.val < list2.val)
                {
                    node.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    node.next = list2;
                    list2 = list2.next;
                }
                node = node.next;
            }
            if(list1 != null){node.next = list1;}
            if(list2 != null){node.next = list2;}
            ShowInfo(MergeTwoSortedList.next); // return MergeTwoSortedList.next;
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