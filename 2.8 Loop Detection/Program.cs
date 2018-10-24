using System;

namespace _2._8_Loop_Detection
{
    class Program
    {
        static void Main(string[] args)
        {
            //LD Create linked list One
            int[] n1 = { 1, 2, 3, 4, 5, 6 };
            var l1 = Common.Utilities.createLinkedListFromArrayInt(n1);

            //LD Create linked list Two, LOOP with K=3
            int[] n2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var l2 = Common.Utilities.createLinkedListFromArrayInt(n2);
            //LD Create loop;
            int k = 3;
            //LD 2.8_1_loopCreation it's not opossible to creat a loop, because the property is read only. But the implementation works
            //l2.First .Next  = l2.First;

            //LD TESTS -----

            Console.WriteLine("Is l1 containing a Cicle? " + Implementation.isListCointainignCicle(l1.First)); //LD NULL expected
            Console.WriteLine("Is l2 containing a Cicle? " + Implementation.isListCointainignCicle(l2.First)); //LD "4" expected as head of the cicle

            Console.ReadLine();
        }
    }
}
