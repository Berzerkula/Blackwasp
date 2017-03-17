//http://www.blackwasp.co.uk/CSharpObjectOriented.aspx
using System;

namespace ClassTest
{
    class Program
    {

        //Method visible to external object
        public void PressHorn()
        {
            Console.WriteLine("Toot toot!");
        }

        static void Main(string[] args)
        {
            //Vehicle car = new ClassTest.Vehicle();
            //Console.WriteLine(car.ToString());
            //Vehicle car = new ClassTest.Vehicle();
            //car.MonitorOilTemperature();
            Rectangle rect = new Rectangle();
            rect.Width = 50;
            rect.Height = 25;

            Rectangle square = new Rectangle();
            square.Width = square.Height = 40;

            Console.WriteLine(rect.Height);
            Console.WriteLine(rect.Width);
            Console.WriteLine(rect.Area);
            Console.WriteLine(rect.Perimeter);
            Console.WriteLine(square.Height);
            Console.WriteLine(square.Width);
            Console.WriteLine(square.Area);
            Console.WriteLine(square.Perimeter);
            //rect.Height = 125;

            Triangle triangle = new Triangle(5,8);

            Console.WriteLine("Height:\t{0}", triangle.Height);
            Console.WriteLine("Base:\t{0}", triangle.BaseLength);
            Console.WriteLine("Area:\t{0}", triangle.Area);

            int density = 50;
            int volume = 100;
            int volume2 = 180;

            int mass1 = MassCalculator.CalculateMass(density, volume);
            int mass2 = MassCalculator.CalculateMass(density, volume2);
            int calls = MassCalculator.CallCount;



            Console.WriteLine("Mass1: {0}", mass1);
            Console.WriteLine("Mass2: {0}", mass2);
            Console.WriteLine("Calls: {0}", calls);
        }
    }
}