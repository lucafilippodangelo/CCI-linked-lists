using System.Collections.Generic;

namespace _2._1_Remove_Duplicates
{
    class Implementation
    {
        #region common methods

        private int _tapB = 0;
        private int _tapC = 0;

        private void Tap(int i)
        {
            if (i == 0)
            {
                _tapB++;
            }
            else
            {
                _tapC++;
            }
        }

        #endregion

        private void DeleteDuplicatesUsingDictionary(LinkedListNode node)
        {
            var table = new Dictionary<int, bool>();
            LinkedListNode previous = null;

            while (node != null)
            {
                if (table.ContainsKey(node.Data))
                {
                    if (previous != null)
                    {
                        previous.Next = node.Next;
                    }
                }
                else
                {
                    table.Add(node.Data, true);
                    previous = node;
                }

                node = node.Next;
            }
        }

    }//LD close Implementation class
}//LD close namespace
