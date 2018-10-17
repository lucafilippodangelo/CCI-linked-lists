using System;
using System.Collections.Generic;

namespace Common
{
    public class Utilities
    {
        #region UTILITY METHODS

        public static Dictionary<string, bool> table = new Dictionary<string, bool>();

        public static LinkedList<string> createLinkedListFromArray(string[] words)
        {
            LinkedList<string> sentence = new LinkedList<string>(words);
            return sentence;
        }

        public static LinkedList<int> createLinkedListFromArrayInt(int[] numbers)
        {
            LinkedList<int> numbersLinkedList = new LinkedList<int>(numbers);
            return numbersLinkedList;
        }

        public static void displayFullLinkedList(LinkedList<string> words, string intro)
        {
            Console.WriteLine(intro);
            foreach (string word in words)
            {
                Console.Write("- " + word + " ");
                Console.WriteLine();
            }
            Console.WriteLine();

            /*
             * //LD DISPLAY DETAILS ON NODES
            Console.WriteLine("First Node Details:"); Console.WriteLine();
            //LD display properties of the last node
            LinkedListNode<string> mark1 = words.First;
            DisplayLinkedListNode(mark1);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Second Node Details:"); Console.WriteLine();
            LinkedListNode<string> mark2 = mark1.Next;
            DisplayLinkedListNode(mark2);
            */

        }

        public static void displayFullLinkedListInt(LinkedList<int> words, string intro)
        {
            Console.WriteLine(intro);
            foreach (int value in words)
            {
                Console.Write("- " + value + " ");
                Console.WriteLine();
            }
            Console.WriteLine();

        }

        public static void displayLinkedListNode(LinkedListNode<String> lln)
        {
            if (lln.List == null)
                Console.WriteLine("   Node is not linked.");
            else
                Console.WriteLine("   Node belongs to a linked list with {0} elements.", lln.List.Count);

            if (lln.Previous == null)
                Console.WriteLine("   Previous node is null.");
            else
                Console.WriteLine("   Value of previous node: {0}", lln.Previous.Value);

            Console.WriteLine("   Value of current node:  {0}", lln.Value);

            if (lln.Next == null)
                Console.WriteLine("   Next node is null.");
            else
                Console.WriteLine("   Value of next node:     {0}", lln.Next.Value);

            Console.WriteLine();
        }

        public static LinkedList<int> copyLinkedList(LinkedList<int> lList)
        {
            LinkedList<int> supportLinkedListInOutput = new LinkedList<int>();

            //LD I can iterate getting the numeric value and I can inside the for create the node specifying the value of the node I'm goung to create 
            foreach ( int lln in lList)
            {
                supportLinkedListInOutput.AddLast(lln);
            }
            return supportLinkedListInOutput;
        }

        public static LinkedList<int> reverseLinkedList(LinkedList<int> inputLinkedList)
        {
            LinkedList<int> supportLinkedListInOutput = new LinkedList<int>();
            var supportLinkedListInInput = copyLinkedList(inputLinkedList);

            while (supportLinkedListInInput.Count != 0)
            {
                supportLinkedListInOutput.AddLast(supportLinkedListInInput.Last.Value);
                supportLinkedListInInput.RemoveLast();
            }

            return supportLinkedListInOutput;
        }

        public static bool areLinkedListEqual(LinkedListNode<int> l1, LinkedListNode<int> l2)
        {
            while (l1 != null && l2 != null)
            {
                if (l1.Value != l2.Value)
                {
                    return false;
                }
                l1 = l1.Next;
                l2 = l2.Next;
            }
            return true;
        }

        public static int getLinkedListLenght(LinkedList<int> inputLinkedList)
        {
            return inputLinkedList.Count;
        }
        #endregion
    }
}
