using System;

namespace MmGuideAssignment
{
    public class GenericList<T>
    {
        public void DoSomething(T param)
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
