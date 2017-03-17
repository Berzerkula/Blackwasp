//http://www.blackwasp.co.uk/CSharpConstructors.aspx
using System;

namespace ClassTest
{
    public class Triangle
    {
        private int _height;
        private int _baseLength;

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new OverflowException();
                }

                _height = value;
            }
        }

        public int BaseLength
        {
            get
            {
                return _baseLength;
            }
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new OverflowException();
                }

                _baseLength = value;
            }
        }

        public double Area
        {
            get
            {
                return _height * _baseLength * 0.5;
            }
        }

        //Constructor
        public Triangle(int height, int baseLength)
        {
            Console.WriteLine("Triangle constructor executed");

            this.Height = height;
            this.BaseLength = baseLength;
        }

        //Finalizer
        ~Triangle()
        {
            Console.WriteLine("Triangle finalizer executed");
        }
    }
}