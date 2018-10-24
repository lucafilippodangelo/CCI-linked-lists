using System;
using System.Collections.Generic;

namespace _2._1_Remove_Duplicates
{
    public static class Implementation
    {

        public static LinkedList<string> deleteDuplicatesInLinkedListUsingDictionary(LinkedList<string> words)
        {
            Dictionary<string, bool> table = new Dictionary<string, bool>();
            LinkedListNode<String> currentNode = words.First;

            LinkedListNode<String> previous = null;

            while (currentNode != null)
            {
                if (table.ContainsKey(currentNode.Value))
                { 
                    if (previous != null)
                    {
                        words.Remove(currentNode);//LD the connection between modes is keepen automatically
                        currentNode = previous.Next; //LD pointer
                    }
                }
                else
                {
                    table.Add(currentNode.Value, true);
                    previous = currentNode; //LD pointer
                    currentNode = currentNode.Next; //LD pointer
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
