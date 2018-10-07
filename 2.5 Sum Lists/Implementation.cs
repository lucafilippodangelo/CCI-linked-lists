using System;
using System.Collections.Generic;
using System.Text;

namespace _2._5_Sum_Lists
{
    class Implementation
    {
        public static LinkedList<int> sumTwoLinkedList(LinkedListNode<int> l1Node, LinkedListNode<int> l2Node, LinkedList<int> supportList, int carry)
        {
        //LD if l1 or l2 are empty then return
        if (l1Node == null && l2Node == null && carry==0)
            {return null; }

            //LD sum all needed for the current value
            int currentValue = carry;
            currentValue += l1Node.Value;
            currentValue += l2Node.Value;

            //LD create a node for the current value
            LinkedListNode<int> result = new LinkedListNode<int>(currentValue % 10); //second digit of the number. We will carry the 

            //LD add the node to the support list
            supportList.AddLast(result);

            //LD RECURSIVE CALL for next nodes and carry
            if (l1Node.Next != null || l1Node.Next != null)
            {
                sumTwoLinkedList(l1Node.Next, l2Node.Next, supportList, currentValue >= 10 ? 1 : 0);
            }

            //LD return whe no more nodes
            return supportList;

        }
    }
}
