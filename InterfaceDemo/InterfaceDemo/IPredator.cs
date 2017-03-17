//http://www.blackwasp.co.uk/Interfaces_2.aspx
using System;

namespace InterfaceDemo
{
    //interface IPredator
    //http://www.blackwasp.co.uk/Interfaces_4.aspx
    //Interface Inheritance
    interface IPredator : IAnimal
    {
        int AttackSpeed { get; set; }

        void Attack(IPrey prey);
    }
}
