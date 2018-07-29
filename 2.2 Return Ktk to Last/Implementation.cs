using System;
using System.Collections.Generic;
using System.Text;

namespace _2._2_Return_Ktk_to_Last
{
    public static class Implementation
    {
        public static int kElemToReturn = 0;
        static private int reversalCountFronTheEnd = 0;


        //LD the method gets in input the ead of the linked list. 
        // then recursively visit the all list
        // then when at the end, increment the static variable "Count"
        public static void recursiveListVisit(LinkedListNode<string> aLinkedListNode)
        {
            if (aLinkedListNode.Next != null)
            {
                //LD we get at the end of the list. Recursion stops when no more "Next" nodes.
                 recursiveListVisit(aLinkedListNode.Next);
            }

            // when no next node we increment "reversalCountFronTheEnd" and check if equal "kElemToReturn"
            reversalCountFronTheEnd++;
            if (reversalCountFronTheEnd == kElemToReturn)
            {
                Console.WriteLine("Value: " + aLinkedListNode.Value );
                return;
            }
        }//LD method end


        public static LinkedListNode<string> NthToLastIterative(LinkedListNode<string> head, int n)
        {
            var p1 = head;
            var p2 = head;

            if (n <= 0) return null;

            // Move p2 n nodes into the list.  Keep n1 in the same position.
            for (var i = 0; i < n - 1; i++)
            {
                if (p2 == null)
                {
                    return null; // Error: list is too small.
                }
                p2 = p2.Next;
            }
            if (p2 == null)
            { // Another error check.
                return null;
            }

            // Move them at the same pace.  When p2 hits the end,
            // p1 will be at the right element.
            while (p2.Next != null)
            {
                p1 = p1.Next;
                p2 = p2.Next;
            }
            return p1;
        }



    }//LD class end
}
