//http://www.blackwasp.co.uk/CSharpEvents.aspx
using System;

namespace EventDemo
{
    class Program
    {

        //static void CarSpeedLimitExceeded(object source, EventArgs e)
        static void CarSpeedLimitExceeded(object source, SpeedEventArgs e)
        {
            Car car = (Car)source;
            //Console.WriteLine("Speed limit exceeded ({0}mph)", car.Speed);
            Console.WriteLine("Speed limit exceeded by {0}mph", e.ExcessSpeed);
        }

        static void Main(string[] args)
        {
            Car car = new Car();
            car.SpeedLimitExceeded +=
                new SpeedLimitExceededEventHandler(CarSpeedLimitExceeded);

            for (int i = 0; i < 3; i++)
            {
                car.Accelerate(30);
                Console.WriteLine("Speed: {0}mph", car.Speed);
            }

            car.SpeedLimitExceeded -=
                new SpeedLimitExceededEventHandler(CarSpeedLimitExceeded);
        }
    }
}
