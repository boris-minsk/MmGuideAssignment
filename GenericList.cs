using System;

namespace MmGuideAssignment
{
    /*
     Replace the [AnimalList and DoubleList] lists with a GenericList class with a single DoSomething() method.
    */
    public class GenericList<T>
    {
        public void DoSomething(T param)
        {
            /* I don't like an idea to switch param type to print an appropriate method.
            But DoSomething() method just prints the message based on param type, so I did.
            Or I missed something?
            Boris Sigal */

            if (param is double)
            {
                Console.WriteLine("Foo Number");
            }
            else if (param is Animal)
            {
                Console.WriteLine("Foo Animal");
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }

    public class GenericList
    {
        public void DoSomething<T>(T param)
        {
            if (param is double)
            {
                Console.WriteLine("Foo Number");
            }
            else if (param is Animal)
            {
                Console.WriteLine("Foo Animal");
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
