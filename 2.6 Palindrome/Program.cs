using System;

namespace _2._6_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            //LD Create a palindrome Linked list
            int[] n1 = { 0,1,2,1,0 };
            var l1 = Common.Utilities.createLinkedListFromArrayInt(n1);
            Common.Utilities.displayFullLinkedListInt(l1, "Palindrome Linked List Creation: ");

            //LD Create a NON palindrome Linked list
            int[] n2 = { 0, 6, 2, 1, 0 };
            var l2 = Common.Utilities.createLinkedListFromArrayInt(n2);
            Common.Utilities.displayFullLinkedListInt(l2, "NON Palindrome Linked List Creation: ");

            Console.WriteLine("Is Link List One Palindrome? "+Implementation .isLinkedListPalindromeApproachOne (l1)); //LD true expected
            Console.WriteLine("Is Link List Two Palindrome? " + Implementation.isLinkedListPalindromeApproachOne(l2)); //LD false expected

            Console.ReadLine();
        }
    }
}
