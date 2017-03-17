//http://www.blackwasp.co.uk/Interfaces.aspx
using System;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //http://www.blackwasp.co.uk/Interfaces_3.aspx
            //Cat tabby = new Cat();
            //tabby.AttackSpeed = 10;

            //Fish bubbles = new Fish();
            //bubbles.FleeSpeed = 12;

            //tabby.Purr();
            //tabby.Attack(bubbles);

            //Polymorphism techniques declare variable using an interface as type
            IPredator tabby = new Cat();
            tabby.AttackSpeed = 10;

            IPrey bubbles = new Fish();
            bubbles.FleeSpeed = 12;

            //tabby.Purr();     //Predators interface does not contain Purr method
            tabby.Attack(bubbles);

            //Implementing multiple interfaces
            IPredator shark = new Fish();
            shark.AttackSpeed = 30;

            IPrey ray = new Fish();
            ray.FleeSpeed = 15;

            shark.Attack(ray);

            //Explicit Interface Implementation
            //Cat c = new Cat();        //invalid
            //c.AttackSpeed = 30;       //invalid

            //http://www.blackwasp.co.uk/Interfaces_4.aspx
            //Interface Inheritance
            Fish nemo = new Fish();
            IAnimal animal = nemo;
            IPredator predator = nemo;
            IPrey prey = nemo;
            predator.AttackSpeed = 5;
            prey.FleeSpeed = 10;
            predator.Attack(prey);
            nemo.AttackSpeed = predator.AttackSpeed;
            nemo.Attack(prey);
        }
    }
}