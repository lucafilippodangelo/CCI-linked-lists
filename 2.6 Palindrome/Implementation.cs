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

        //LD 2.6_3 support class
        private class Result
        {
            public LinkedListNode<int> Node;
            public bool result;

            public Result(LinkedListNode<int> node, bool res)
            {
                Node = node;
                result = res;
            }
        }

        //LD 2.6_3 enter method
        public static bool isLinkedListPalindromeApproachThree(LinkedListNode<int> head)
        {
            var size = 0;
            var node = head;

            while (node != null)
            {
                size++;
                node = node.Next;
            }

            var palindrome = IsPalindromeRecurse(head, size);

            return palindrome.result;
        }

        //LD 2.6_3 recursion
        private static Result IsPalindromeRecurse(LinkedListNode<int> head, int length)
        {
            //LD basic check
            if (head == null || length == 0)
            {
                return new Result(null, true);
            }

            //LD we are in th middle of the list, ODD number of nodes
            if (length == 1)
            {
                return new Result(head.Next, true);
            }

            //LD we are in th middle of the list, EVEN number of nodes
            if (length == 2)
            {
                return new Result(head.Next.Next, head.Value == head.Next.Value); //LD return two node on the right and 
            }

            //LD main recursive call, we go down until we get the center of the list
            var res = IsPalindromeRecurse(head.Next, length - 2);

            if (!res.result || res.Node == null)
            {
                return res; // Only "result" member is actually used in the call stack.
            }

            res.result = head.Value == res.Node.Value; //LD the result(boolean) is the comparison between the current "head" and the returned node result from the previous recursive call.
            res.Node = res.Node.Next; //LD then we pass reference to the the next node of the node returned bu the previous recursive call

            return res;
        }

        //LD 2.6_4 
        /// <summary>
        /// Another recursive approach.
        /// 
        /// We traverse the Linked List to the end while keeping a reference of the first node.
        /// Palindrome check begins when we recurse to the end of the Linked List:
        /// 1) Compare the two nodes (one from start and one from the back)
        /// 2) Advance the "front" node because by recursing back we get the node before "back"
        /// 3) Return isPalindrome
        /// </summary>
        /// <param name="head">First node of the Linked List</param>
        /// <returns></returns>
        private bool isLinkedListPalindromeApproachFour(LinkedListNode<int> head)
        {
            return (head == null) || (head.Next == null) || IsPalindromeFourRecurse(ref head, head.Next);
        }

        private bool IsPalindromeFourRecurse(ref LinkedListNode<int> front, LinkedListNode<int> back)
        {
            bool isPalindrome = true;

            if (back.Next != null)
                isPalindrome = IsPalindromeFourRecurse(ref front, back.Next); 

            //LD I got at the end of the list

            //LD "x &= y" equal to "x = x & y" where "The & operator performs a bitwise logical AND operation on integral operands and logical AND on bool operands."
            isPalindrome &= front.Value == back.Value;

            front = front.Next;
            return isPalindrome;
        }

    }
}
