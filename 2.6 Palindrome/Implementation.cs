using System;
using System.Collections.Generic;
using System.Text;

namespace _2._6_Palindrome
{
    class Implementation
    {
        public static bool isLinkedListPalindromeApproachOne(LinkedList<int> supportList)
        {
            LinkedList<int> reversedList = Common.Utilities.reverseInputLinkedList(supportList);

            if (Common.Utilities.areLinkedListEqual (supportList.First, reversedList.First))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
