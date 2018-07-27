using System;

namespace _2._1_Remove_Duplicates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] words = { "str_1", "str_2", "str_1", "str_1", "str_3", "str_3", "str_1", "str_4", "str_2" };
            var LinkedList = Implementation.createLinkedList(words);

            Implementation.DeleteDuplicatesInLinkedListUsingDictionary(LinkedList);
            //LD Expected String "str_1, str_2, str_3, str_4"
            
            Implementation.DeleteDuplicatesInLinkedListUsingTwoPointers(LinkedList);

            Console.ReadLine();
        }
    }
}
