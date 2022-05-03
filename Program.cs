using System;
using System.Collections.Generic;

namespace MmGuideAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 1");
            // Generic list
            var listOfAnimalsGeneric = new GenericList<Animal>();
            var listOfNumbersGeneric = new GenericList<double>();
            listOfAnimalsGeneric.DoSomething(new Animal());
            listOfNumbersGeneric.DoSomething(2.5);
            // Generic method
            var listOfAnimals = new GenericList();
            var listOfNumbers = new GenericList();
            listOfAnimals.DoSomething<Animal>(new Animal());
            listOfNumbers.DoSomething<double>(2.5);

            Console.WriteLine("Question 2");
            Console.WriteLine("Original list");
            LinkedListReverse<string>.PrintList(new LinkedList<string>(new string[] { "one", "two", "three", "four", "five", "six" }));
            Console.WriteLine("Reversed list");
            LinkedListReverse<string>.BuiltInReverseTest(new LinkedList<string>(new string[] { "one", "two", "three", "four", "five", "six" }));
            LinkedListReverse<string>.ReverseBySwitchingValuesLoopTest(new LinkedList<string>(new string[] { "one", "two", "three", "four", "five", "six" }));
            LinkedListReverse<string>.ReverseByRecursionTest(new LinkedList<string>(new string[] { "one", "two", "three", "four", "five", "six" }));
            LinkedListReverse<string>.ReverseByLoopTest(new LinkedList<string>(new string[] { "one", "two", "three", "four", "five", "six" }));

            Console.WriteLine("Question 3");
            const string str1 = "boris sigal test";
            const string str2 = "test sigal boris";
            Anagram.Test(str1, str2);

            Console.WriteLine("Question 4");
            BinaryTree.TestTree();

            Console.ReadLine();
        }
    }
}
