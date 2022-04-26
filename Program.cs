using System;

namespace MmGuideAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalList listOfAnimals = new AnimalList();
            DoubleList listOfNumbers = new DoubleList();
            listOfNumbers.DoSomething(2.5);
            listOfAnimals.DoSomething(new Animal());
        }
    }
}
