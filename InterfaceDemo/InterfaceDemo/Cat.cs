//http://www.blackwasp.co.uk/Interfaces_2.aspx
using System;

namespace InterfaceDemo
{
    class Cat : IPredator
    {
        private int _attackSpeed;

        //public int AttackSpeed
        //Explicit Interface Implementation
        int IPredator.AttackSpeed
        {
            get { return _attackSpeed; }
            set { _attackSpeed = value; }
        }

        //public void Attack(IPrey prey)
        //Explicit Interface Implementation
        void IPredator.Attack(IPrey prey)
        {
            if (_attackSpeed > prey.FleeSpeed)
                Console.WriteLine("Caught prey");
            else
                Console.WriteLine("Prey escaped");
        }

        public void Purr()
        {
            Console.WriteLine("Cat purred");
        }

        ////http://www.blackwasp.co.uk/Interfaces_4.aspx
        //Interface Inheritance
        private string _name;

        public string Name
        {
            get { return _name; }
            set { Name = value; }
        }
    }
}
