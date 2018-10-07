using System;

namespace _2._5_Sum_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //LD Linked list One, Two and Three creation. List Three is Empty
            int[] n1 = { 7,1,6};
            var l1 = Common.Utilities.createLinkedListFromArrayInt(n1);
            Common.Utilities.displayFullLinkedListInt(l1, "Linked List One: ");

            int[] n2 = { 5,9,2 };
            var l2 = Common.Utilities.createLinkedListFromArrayInt(n2);
            Common.Utilities.displayFullLinkedListInt(l2, "Linked List Two: ");

            int[] n3 = { };
            var sl = Common.Utilities.createLinkedListFromArrayInt(n3); //sl -> "Support List"
            Common.Utilities.displayFullLinkedListInt(sl, "Linked List Three when created: ");

            //LD Call Function
            var result = Implementation.sumTwoLinkedList(l1.First,l2.First,sl,0);
            Common.Utilities.displayFullLinkedListInt(sl, "Result Linked List : ");

            Console.ReadLine();
        }
    }
}
