using System.Collections.Generic;

namespace LinkedListQuestions
{
    /*
     * Loop Detection
     * 
     * Given a circular linked list, implement an algorithm that returns the node at the beginning of the loop.
     * DEFINITION
     * Circular linked list: A (corrupt) linked list in which a node's next pointer points to an earlier node, 
     * so as to make a loop in the linked list.
     * EXAMPLE
     * Input: A -> B -> C - > D -> E -> C [the same C as earlier]
     * Output: C
     * 
     * Cracking the Coding Interview, p. 95, 2.8
     * or
     * https://leetcode.com/problems/linked-list-cycle
     */
    public class Task08LoopDetection
    {
        public bool Do1(ListNode head)
        {
            if (head?.next == null) return head != null && head == head.next;

            var slow = head;
            var fast = head.next;

            while (slow.next != null && fast.next?.next != null)
            {
                if (slow == fast)
                {
                    return true;
                }

                slow = slow.next;
                fast = fast.next.next;
            }

            return false;
        }

        public bool Do2(ListNode head)
        {
            var current = head;
            var visited = new HashSet<ListNode>();

            while (current != null)
            {
                if (!visited.Add(current))
                    return true;

                current = current.next;
            }

            return false;
        }
    }
}
