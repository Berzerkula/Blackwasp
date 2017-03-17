using System;

namespace IndexerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray fruit = new IndexerDemo.MyArray(-2, 1);
            fruit[-2] = "Apple";
            fruit[-1] = "Orange";
            fruit[0] = "Banana";
            fruit[1] = "Blackcurrant";
            Console.WriteLine("fruit[-1]: {0}", fruit[-1]);
            Console.WriteLine("fruit[0]: {0}", fruit[0]);

            //Multidimensional indexer
            Console.WriteLine("fruit[-1, 0]): {0}", fruit[-1, 0]);
            Console.WriteLine("fruit[0, 2]): {0}", fruit[0, 2]);

            //No underlying array
            MyArray fruit2 = new IndexerDemo.MyArray(0, 0);
            Console.WriteLine("fruit2[5F]): {0}", fruit2[5.0F]);
        }
    }
}
