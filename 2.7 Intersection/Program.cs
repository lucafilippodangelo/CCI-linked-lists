using System;

namespace _2._7_Intersection
{
    class Program
    {
        static void Main(string[] args)
        {
            //LD Create linked list One
            int[] n1 = { 3,1,5,9,7,2,1 };
            var l1 = Common.Utilities.createLinkedListFromArrayInt(n1);
            //Common.Utilities.displayFullLinkedListInt(l1, "Palindrome Linked List Creation: ");

            //LD //LD Create linked list Two
            int[] n2 = { 4,6,7,2,1 };
            var l2 = Common.Utilities.createLinkedListFromArrayInt(n2);
            //Common.Utilities.displayFullLinkedListInt(l2, "NON Palindrome Linked List Creation: ");

            //LD TESTS -----

            Console.WriteLine("Are Input Lists Intersecting? " + Implementation.areLinkedListsIntersectingApproachOne(l1,l2)); //LD true expected

            Console.ReadLine();
        }
    }
}
