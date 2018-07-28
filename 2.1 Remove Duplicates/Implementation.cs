using System;
using System.Collections.Generic;

namespace _2._1_Remove_Duplicates
{
    public static class Implementation
    {
        #region UTILITY METHODS

        public static Dictionary<string, bool> table = new Dictionary<string, bool>();

        public static LinkedList<string> createLinkedListFromArray(string[] words)
        {
            LinkedList<string> sentence = new LinkedList<string>(words);
            return sentence;
        }

        public static void displayFullLinkedList(LinkedList<string> words, string intro)
        {
            Console.WriteLine(intro);
            foreach (string word in words)
            {
                Console.Write("- "+word + " ");
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

        #endregion

        public static LinkedList<string> deleteDuplicatesInLinkedListUsingDictionary(LinkedList<string> words)
        {
            LinkedListNode<String> currentNode = words.First;

            LinkedListNode<String> previous = null;

            while (currentNode != null)
            {
                if (table.ContainsKey(currentNode.Value))
                { 
                    if (previous != null)
                    {
                        //LD the connection between modes is keepen automatically
                        words.Remove(currentNode);
                        currentNode = previous.Next;
                    }
                }
                else
                {
                    table.Add(currentNode.Value, true);
                    previous = currentNode;
                    currentNode = currentNode.Next;
                }
            }
            return words;
        }

        public static LinkedList<string> deleteDuplicatesInLinkedListUsingTwoPointers(LinkedList<string> words)
        {
            LinkedListNode<String> head = words.First;

            LinkedListNode<String> current = null;

            while (current != null)
            {
                LinkedListNode<String> runner = current;
              
                while (runner.Next != null)
                {
                    if (runner.Next.Value == current.Value)
                    {
                        words.Remove(runner.Next);
                    }
                    else
                    {
                        runner = runner.Next;
                    }
                }
                current = current.Next;
            }
            return words;
        }

    }//LD close Implementation class
}//LD close namespace
