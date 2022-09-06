using System;

namespace LinkedListCycle
{
    class Program
    {
        static void Main(string[] args)
        {
            bool HasCycle(ListNode head)
            {
                if (head == null || head.next = null) return false;

                ListNode first = head;
                ListNode second = head.next;

                while(first != second)
                {
                    if (first == null || second == null || first.next == null || second.next == null)
                    {
                        return false;
                    }
                    else
                    {
                        first = first.next;
                        second = second.next.next;
                    }
                }
                return true;
            }
        }
    }
}
