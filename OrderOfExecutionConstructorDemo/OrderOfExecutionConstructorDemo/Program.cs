//http://www.blackwasp.co.uk/ConstructorInheritance.aspx
using System;

namespace OrderOfExecutionConstructorDemo
{
    class Program
    {
        static void Main()
        {
            //MySubclass test = new MySubclass();
            //http://www.blackwasp.co.uk/ConstructorInheritance_2.aspx
            //MySubclass test = new MySubclass(10);

            //Using protect constructors
            //MyBaseClass test = new MyBaseClass();     // Does not compile
            MySubclass test = new MySubclass();
        }
    }
    
    class MyBaseClass
    {
        protected MyBaseClass()
        {
            Console.WriteLine("MyBaseclass constructor called.");
        }

        ~MyBaseClass()
        {
            Console.WriteLine("MyBaseClass destructor called.");
        }

        public MyBaseClass(int aNumber)
        {
            string output;
            output = string.Format("MyBaseClass created with value {0}.", aNumber);
            Console.WriteLine(output);
        }
    }

    class MySubclass : MyBaseClass
    {
        public MySubclass()
        {
            Console.WriteLine("MySubclass constructor called.");
        }

        ~MySubclass()
        {
            Console.WriteLine("MySubclass destructor called.");
        }

        public MySubclass(int startValue) : base(startValue)
        {
            string output;
            output = string.Format("MySubclass created with value {0}.", startValue);
            Console.WriteLine(output);
        }
    }
}
