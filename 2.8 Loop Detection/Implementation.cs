using System;
using System.Collections.Generic;
using System.Text;

namespace _2._8_Loop_Detection
{
    //LD 2.8_1 
    class Implementation
    {
        public static Int64 isListCointainignCicle(LinkedListNode<int> head)
        {
            var slow = head;
            var fast = head;

            // Find meeting point
            while (fast != null && fast.Next != null) //LD we have to go ahead until the very last element in the list
            {
                //LD if "fast" is in the "penultimate" element of the list and "fast.Next.Next" will be "null"
                // we exit from the "while" because there is no loop and the pointers can't meet
                if (fast.Next.Next == null)
                    return 0;

                slow = slow.Next;
                fast = fast.Next.Next;

                if (slow.Value == fast.Value )
                {
                    break;
                }
            }


            /* Move slow to Head. Keep fast at Meeting Point. Each are k steps
            /* from the Loop Start. If they move at the same pace, they must
             * meet at Loop Start. */
            slow = head;
            while (slow != fast)
            {
                slow = slow.Next;
                fast = fast.Next;
            }

            // Both now point to the start of the loop.
            return fast.Value;
        }

    }
}
