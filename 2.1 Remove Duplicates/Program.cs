using System;

namespace _2._1_Remove_Duplicates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] words = { "str_1", "str_2", "str_1", "str_1", "str_3", "str_3", "str_1", "str_4", "str_2" };
            
            var LinkedList = Common.Utilities.createLinkedListFromArray(words);
            Common.Utilities.displayFullLinkedList(LinkedList, "Linked List:");

            Implementation.deleteDuplicatesInLinkedListUsingDictionary(LinkedList);
            //LD Expected String "str_1, str_2, str_3, str_4"
            Common.Utilities.displayFullLinkedList(LinkedList, "Linked List Approach One:");

            Implementation.deleteDuplicatesInLinkedListUsingTwoPointers(LinkedList);
            //LD Expected String "str_1, str_2, str_3, str_4"
            Common.Utilities.displayFullLinkedList(LinkedList, "Linked List Approach Two:");

            Console.ReadLine();
        }
    }
}
