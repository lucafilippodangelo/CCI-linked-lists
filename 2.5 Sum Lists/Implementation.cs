using System;
using System.Collections.Generic;
using System.Text;

namespace _2._5_Sum_Lists
{
    class Implementation
    {
        public static LinkedList<int> Partition(LinkedListNode<int> aLinkedListNode, int n)
        {
            //LD create the support linked list
            LinkedList<int> supportLinkedList = new LinkedList<int>();

            while (aLinkedListNode != null)
            {
                if (aLinkedListNode.Value < n)
                {
                    supportLinkedList.AddFirst(aLinkedListNode.Value);
                }
                else
                {
                    supportLinkedList.AddLast(aLinkedListNode.Value);
                }
                aLinkedListNode = aLinkedListNode.Next;
            }
            return supportLinkedList;
        }
    }
}
