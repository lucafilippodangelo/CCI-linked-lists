using System;
using System.Collections.Generic;
using System.Text;

namespace _2._7_Intersection
{
    class Implementation
    {
        //LD 2.7_1 are input linked lists intersecting
        public static bool areLinkedListsIntersectingApproachOne(LinkedList<int> l1, LinkedList<int> l2)
        {
            //LD 1) compare the tails, if they are different(by reference, not by value), return immediately.There is not intersection
            if (l1.Last.Value  != l2.Last.Value)
                return false;


            //LD 2) set two pointers at start of linked lists and advance by the difference in lenghts.
            /* Set pointers to the start of each linked list. */
            LinkedListNode<int> shorter = l1.Count < l2.Count ? l1.First : l2.First;
            LinkedListNode<int> longer = l1.Count < l2.Count ? l2.First : l1.First;

            // Advance the pointer for the longer linked list by the difference in lengths. 
            longer = getProcessingStartNodeInLongerList(longer, Math.Abs(l1.Count - l2.Count ));


            //LD 3) traverse the two linked lists until the pointers are the same and then collision
            bool result = false;
            while (result==false)
            {
                if (shorter.Value == longer.Value)
                    result = true;

                shorter = shorter.Next;
                longer = longer.Next;
            }

            return result;
        }

        #region Support Classes
        
        public class TailAndSize
        {
            public LinkedListNode<int> tail;
            public int size;

            public TailAndSize(LinkedListNode<int> tail, int size)
            {
                this.tail = tail;
                this.size = size;
            }
        }

        public static LinkedListNode<int> getProcessingStartNodeInLongerList(LinkedListNode<int> head, int k)
        {
            LinkedListNode<int> current = head;
            while (k > 0 && current != null)
            {
                current = current.Next;
                k--;
            }
            return current;
        }

        #endregion
    }
}
