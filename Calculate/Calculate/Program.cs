//http://www.blackwasp.co.uk/CSharpMethodOverloading.aspx
using System;

namespace Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            double squareMe = 5;
            int squareMeToo = 5;
            Console.WriteLine(Calculate.Square(squareMe));
            Console.WriteLine(Calculate.Square(squareMeToo));

            //http://www.blackwasp.co.uk/CSharpMethodOverloading_2.aspx
            float squareMeThree = 5;
            Console.WriteLine(Calculate.Square(squareMeThree));
        }
    }
}
