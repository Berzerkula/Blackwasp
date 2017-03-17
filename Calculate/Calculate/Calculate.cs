//http://www.blackwasp.co.uk/CSharpMethodOverloading.aspx
using System;

namespace Calculate
{
    class Calculate
    {
        public static int Square(int number)
        {
            Console.WriteLine("Integer Square calculated");
            return number * number;
        }

        public static double Square(double number)
        {
            Console.WriteLine("Double Square calculated");
            return number * number;
        }
    }
}