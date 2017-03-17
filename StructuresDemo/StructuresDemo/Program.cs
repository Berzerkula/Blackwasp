//http://www.blackwasp.co.uk/CSharpStructures.aspx
using System;

namespace StructuresDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v = new Vector();
            Console.WriteLine("X: {0}\tY:{1}", v.X, v.Y);
            Console.WriteLine("Length: {0}", v.CalculateLength());

            v.X = 30;
            v.Y = 40;

            Console.WriteLine("X: {0}\tY: {1}", v.X, v.Y);
            Console.WriteLine("Length: {0}", v.CalculateLength());
        }
    }
}