using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Merge2SortedLinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode MergeTwoLists(ListNode head1, ListNode head2)
            {
                if (head1 == null) return head2;
                if(head2 == null) return head1;
                
                //NOT WORKING!!!    

                List<ListNode> nodeList = new List<ListNode>();

                while(head1 != null)
                {
                    nodeList.Add(head1);
                    head1 = head1.next;
                }

                while(head2 != null)
                {
                    nodeList.Add(head2);
                    head2 = head2.next;
                }

                nodeList.Sort();

                Console.WriteLine(nodeList);

                ListNode finalHead = new ListNode();

                for (int i = 0; i <= nodeList.Count; i++)
                {
                    finalHead = nodeList[i];
                    finalHead.next = nodeList[i + 1];
                }

                return finalHead;
            }

            

            ListNode node1 = new ListNode(3);
            ListNode node2 = new ListNode(2);
            ListNode node3 = new ListNode(1);
            node1.next = node2;
            node2.next = node3;

            ListNode node5 = new ListNode(5);
            ListNode node6 = new ListNode(4);
            ListNode node7 = new ListNode(9); ;
            node5.next = node6;
            node6.next = node7;

            Console.WriteLine(MergeTwoLists(node1, node5));
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
