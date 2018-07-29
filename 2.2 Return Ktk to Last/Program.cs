using System;
using System.Collections.Generic;

namespace _2._2_Return_Ktk_to_Last
{
    class Program
    {
        static void Main(string[] args)
        {
            //LD Linked list creation
            string[] words = { "S1", "S2", "S3", "S4", "S5" };
            var LinkedList = Common.Utilities.createLinkedListFromArray(words);
            Common.Utilities.displayFullLinkedList(LinkedList, "Linked List 2.2:");
            

            //LD Approach one - recursive
            Implementation.kElemToReturn = 3; //LD expected "S3"
            Implementation.recursiveListVisit(LinkedList.First);

            //LD Approach one - recursive
            LinkedListNode<string> ooo = Implementation.NthToLastIterative(LinkedList.First,3);//LD expected "S3"
            Console.WriteLine("Returned Value: " + ooo.Value);

            Console.ReadLine();
        }
    }
}
