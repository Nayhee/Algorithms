using System;
using System.Collections.Generic;
using System.Collections;

namespace ReverseLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode ReverseList(ListNode head)
            {
                ListNode prev = null;
                while(head != null)
                {
                    var next = head.next;
                    head.next = prev;
                    prev = head;
                    head = next;
                }
                return prev;
            }

            var node1 = new ListNode(1);
            var node2 = new ListNode(2);
            var node3 = new ListNode(3);
            var node4 = new ListNode(4);
            var node5 = new ListNode(5);
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;

            var result = ReverseList(node1);
            Console.WriteLine(result.val);
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
