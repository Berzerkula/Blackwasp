//http://www.blackwasp.co.uk/ConstructorOverloading.aspx
using System;

namespace ConstructorOverloading
{
    class Rectangle
    {
        private int _height;
        private int _width;

        public int Height
        {
            get { return _height; }
        }

        public int Width
        {
            get { return _width; }
        }

        public Rectangle(int height, int width)
        {
            if (height <= 0) throw new ArgumentException("height");
            if (width <= 0) throw new ArgumentException("width");

            _height = height;
            _width = width;

            Console.WriteLine("Rectangle Constructor Called");
        }

        /*
        public Rectangle(int size)
        {
            if (size <= 0) throw new ArgumentException("height");

            _height = _width = size;

            Console.WriteLine("Square Constructor Called");
        }
        */

        //Constructor calling syntax
        public Rectangle(int size) : this(size, size)
        {
            Console.WriteLine("Square Constructor Called");
        }
    }
}