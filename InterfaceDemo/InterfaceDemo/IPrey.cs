//http://www.blackwasp.co.uk/Interfaces.aspx
using System;

namespace InterfaceDemo
{
    //interface IPrey
    //http://www.blackwasp.co.uk/Interfaces_4.aspx
    //Interface Inheritance
    interface IPrey : IAnimal
    {
        int FleeSpeed { get; set; }

        void Flee();
    }
}
