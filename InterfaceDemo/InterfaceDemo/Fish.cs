//http://www.blackwasp.co.uk/Interfaces_2.aspx
using System;

namespace InterfaceDemo
{
    //Implmenting Multiple Interfaces
    class Fish : IPrey, IPredator

    //class Fish : IPrey
    {
        private int _fleeSpeed;

        public int FleeSpeed
        {
            get { return _fleeSpeed; }
            set { _fleeSpeed = value; }
        }

        public void Flee()
        {
            Console.WriteLine("Fish fleeing");
        }

        //Implementing Multiple Interfaces
        private int _attackSpeed;

        public int AttackSpeed
        {
            get { return _attackSpeed; }
            set { _attackSpeed = value; }
        }

        public void Attack(IPrey prey)
        {
            if (_attackSpeed > prey.FleeSpeed)
                Console.WriteLine("Caught prey");
            else
                Console.WriteLine("Prey escaped");
        }

        //http://www.blackwasp.co.uk/Interfaces_4.aspx
        //Interface Inheritance
        private string _name;

        public string Name
        {
            get { return _name; }
            set { Name = value; }
        }
    }
}