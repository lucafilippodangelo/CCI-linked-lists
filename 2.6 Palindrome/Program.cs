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

            // ---
            //LD Create a palindrome Linked list

            int[] n3 = { 0, 1, 2, 2, 1, 0 };
            var l3 = Common.Utilities.createLinkedListFromArrayInt(n3);
            Common.Utilities.displayFullLinkedListInt(l3, "Palindrome Linked List Creation: ");

            //LD Create a palindrome Linked list
            int[] n4 = { 0, 1, 2, 7, 2, 1, 0 };
            var l4 = Common.Utilities.createLinkedListFromArrayInt(n4);
            Common.Utilities.displayFullLinkedListInt(l4, "Palindrome Linked List Creation: ");

            //LD Create a palindrome Linked list
            int[] n5 = { 0, 1, 2, 7, 7, 1, 0 };
            var l5 = Common.Utilities.createLinkedListFromArrayInt(n5);
            Common.Utilities.displayFullLinkedListInt(l5, "Palindrome Linked List Creation: ");

            //LD test Implementation ONE
            Console.WriteLine("Implementation ONE List ONE is palindrome? "+Implementation .isLinkedListPalindromeApproachOne (l1)); //LD true expected
            Console.WriteLine("Implementation ONE List TWO is palindrome? " + Implementation.isLinkedListPalindromeApproachOne(l2)); //LD false expected

            //LD test Implementation ONE
            Console.WriteLine("Implementation TWO List ONE is palindrome? " + Implementation.isLinkedListPalindromeApproachTwo(l1)); //LD true expected
            Console.WriteLine("Implementation TWO List TWO is palindrome? " + Implementation.isLinkedListPalindromeApproachTwo(l2)); //LD false expected
            Console.WriteLine("Implementation TWO List THREE is palindrome? " + Implementation.isLinkedListPalindromeApproachTwo(l3)); //LD true expected
            Console.WriteLine("Implementation TWO List FOUR is palindrome? " + Implementation.isLinkedListPalindromeApproachTwo(l4)); //LD true expected
            Console.WriteLine("Implementation TWO List FIVE is palindrome? " + Implementation.isLinkedListPalindromeApproachTwo(l5)); //LD false expected


            Console.ReadLine();
        }
    }
}
