using System;

namespace _2._1_Remove_Duplicates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] words = { "the", "fox", "jumped", "over", "the", "dog", "the", "ole", "fox" };
            var LinkedList = Implementation.createLinkedList(words);

            Implementation.DeleteDuplicatesInLinkedListUsingDictionary(LinkedList);

            Console.ReadLine();
        }
    }
}
