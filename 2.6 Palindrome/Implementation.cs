using System;
using System.Collections.Generic;
using System.Text;

namespace _2._6_Palindrome
{
    class Implementation
    {
        //LD 2.6_1 this is the iterative approach
        public static bool isLinkedListPalindromeApproachOne(LinkedList<int> supportList)
        {
            LinkedList<int> reversedList = Common.Utilities.reverseLinkedList(supportList);

            //LD once we are comparing reversed linked list it is enoutgh to compare the first half of the list, 
            // because the first half of the normal list has to match the first half of the reversed list.  
            if (Common.Utilities.areLinkedListEqual (supportList.First, reversedList.First))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //LD 2.6_2 stack approach with slow/fast runner. A bit complext and too much if
        public static bool isLinkedListPalindromeApproachTwo(LinkedList<int> supportList)
        {
            LinkedListNode<int> slow = supportList.First;
            LinkedListNode<int> fast = supportList.First;

            Stack<int> aStack = new Stack<int>();

            //LD push first part of the list in the stack
            // We check that current fast is not null and that the next position in the list is not null.
            // if condition OK then proceed
            while (fast!=null && fast.Next != null)  
            {
                //LD insert in stack
                aStack.Push(slow.Value);

                //LS STEP TWO advance. We just advance if the next position. We will get "slow" ready for comparison(not odd)
                if (fast.Next.Next == null)
                    {
                       fast = null;
                    }
                else
                    {
                       //LD advance fast only if we are tot already at the end of the list
                       fast = fast.Next.Next;
                    }
                slow = slow.Next;
            }

            //LD if odd we skip the element after the middle element, because after the previour while, the pointer is in the (count/2) element number
            if ((supportList.Count % 2) != 0)
            {
                //LD then is an odd list
                slow = slow.Next;
            }

            //LD now We compare the stack and the second part of the list. We can see that we do just a full iteration of the list, tacking as reference the "slow" runner. 
            while (slow != null )
            {
                if (!( aStack.Pop().Equals(slow.Value)))
                {
                    return false;
                }
                slow = slow.Next;
            }
            return true;
        }

        //LD 2.6_3 
    }
}
