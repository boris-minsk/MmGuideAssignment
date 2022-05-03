// https://www.codeproject.com/Articles/27742/How-To-Reverse-a-Linked-List-3-Different-Ways

using System;
using System.Collections.Generic;
using System.Linq;

namespace MmGuideAssignment
{
    public static class LinkedListReverse<T>
    {
        public static void ReverseBySwitchingValuesLoop(LinkedList<T> linkedList)
        {
            LinkedListNode<T>  firstNode = linkedList.First;
            LinkedListNode<T> lastNode = linkedList.Last;
            int numberOfRun = linkedList.Count / 2;

            T tempValue; 

            for (int i = 0; i < numberOfRun; i++)
            {
                tempValue = firstNode.Value;
                firstNode.Value = lastNode.Value;
                lastNode.Value = tempValue;

                firstNode = firstNode.Next;
                lastNode = lastNode.Previous;
            }
        }

        public static void ReverseByLoop(LinkedList<T> list)
        {
            if (list == null || list.First.Next == null) return;

            var head = list.First;

            while (head.Next != null)
            {
                list.AddBefore(head, new LinkedListNode<T>(list.Last.Value));
                list.Remove(list.Last);
            }
        }

        public static void ReverseByRecursion(LinkedListNode<T> head)
        {
            if (head == null || head.Next == null) return; 

            head.List.AddBefore(head, new LinkedListNode<T>(head.List.Last.Value));
            head.List.Remove(head.List.Last);

            ReverseByRecursion(head);
        }

        public static void BuiltInReverseTest(LinkedList<string> list)
        {       
            list = new LinkedList<string>(list.Reverse());
            PrintList(list);
        }

        public static void ReverseBySwitchingValuesLoopTest(LinkedList<string> list)
        {
            LinkedListReverse<string>.ReverseBySwitchingValuesLoop(list);
            PrintList(list);
        }

        public static void ReverseByRecursionTest(LinkedList<string> list)
        {           
            LinkedListReverse<string>.ReverseByRecursion(list?.First);
            PrintList(list);
        }

        public static void ReverseByLoopTest(LinkedList<string> list)
        {
            LinkedListReverse<string>.ReverseByLoop(list);
            PrintList(list);
        }

        public static void PrintList(LinkedList<string> list)
        {
            if (list == null || list.Count == 0) return;
            foreach (string s in list)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
        }
    }
}
