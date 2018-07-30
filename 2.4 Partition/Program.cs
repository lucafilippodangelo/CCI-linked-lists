using System;

namespace _2._4_Partition
{
    class Program
    {
        static void Main(string[] args)
        {
            //LD Linked list creation
            int[] numbers = {3,7,4,8,1,9 };
            var LinkedList = Common.Utilities.createLinkedListFromArrayInt(numbers);
            Common.Utilities.displayFullLinkedListInt(LinkedList, "Linked List: ");

            var LinkedListProcessed = Implemenation.Partition(LinkedList.First, 8);
            Common.Utilities.displayFullLinkedListInt(LinkedListProcessed, "Linked List Processed, expected 1,4,7,3,8,9: ");

            Console.ReadLine ();
        }
    }
}
