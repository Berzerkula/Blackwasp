//http://www.blackwasp.co.uk/Inheritance.aspx
using System;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new MotorVehicle();
            //MotorVehicle car = new MotorVehicle();
            //car.TankSize = 11;
            //Console.WriteLine("Fuel: {0}g", car.FuelRemaining);
            //car.Refuel();
            //Console.WriteLine("Fuel: {0}g", car.FuelRemaining);

            Vehicle bike = new Bicycle();
            //Bicycle bike = new Bicycle();
            //bike.RingBell();

            //car.Indicate(true);
            //bike.Indicate(true);
            IndicateLeft(car);
            IndicateLeft(bike);
        }

        static void IndicateLeft(Vehicle vehicle)
        {
            vehicle.Indicate(true);
        }
    }
}