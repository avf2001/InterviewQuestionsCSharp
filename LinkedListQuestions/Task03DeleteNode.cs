namespace LinkedListQuestions
{
    /*
     * Delete Node
     * 
     * Implement an algorithm to delete a node in the middle
     * (i.e., any node but the first and last node, not necessarily the exact middle) 
     * of a singly linked list, given only access to that node.
     * 
     * EXAMPLE
     * lnput:the node c from the linked list a->b->c->d->e->f
     * Result: nothing is returned, but the new linked list looks like a ->b->d- >e- >f
     * 
     * Cracking the Coding Interview, p. 94, 2.3
     * or
     * https://leetcode.com/problems/delete-node-in-a-linked-list
     */
    public class Task03DeleteNode
    {
        /* 
         * In this problem, you are not given access to the head of the linked list.
         * You only have access to that node. The solution is simply to copy the data 
         * from the next node over to the current node, and then to delete the next node.
         * 
         * Note that this problem cannot be solved if the node to be deleted is the last node in the linked list.
         * That's okay-your interviewer wants you to point that out, and to discuss how to handle this case.
         * You could, for example, consider marking the node as dummy.
         */
        public static void Do()
        {
        }
    }
}
