//http://www.blackwasp.co.uk/CSharpStructures_2.aspx
using System;

namespace StructuresDemo
{
    struct Vector
    {
        private int _x, _y;

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public double CalculateLength()
        {
            //return Math.Sqrt(Math.Pow(_x, 2) + Math.Pow(_y, 2));
            return Math.Sqrt((_x * _x) + (_y * _y));
        }
    }
}
