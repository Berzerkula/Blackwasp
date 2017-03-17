//http://www.blackwasp.co.uk/Namespaces.aspx
using System;
//using FirstNamespace;
//using SecondNamespace;
using First = FirstNamespace;
using Second = SecondNamespace;

namespace NamespaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test t = new Test();      // Does not compile
            //FirstNamespace.Test t = new FirstNamespace.Test();
            //Test t = new Test();
            First.Test t = new First.Test();
            Second.Test u = new Second.Test();
        }
    }
}

namespace FirstNamespace
{
    class Test
    {
        public void ShowMessage()
        {
            Console.WriteLine("This is the first namespace!");
        }
    }
}

namespace SecondNamespace
{
    class Test
    {
        public void ShowMessage()
        {
            Console.WriteLine("This is the second namespace!");
        }
    }
}

namespace FirstNamespace
{
    class ShorTest
    {
        public void ShowShortMessage()
        {
            Console.WriteLine("First namespace!");
        }
    }
}
