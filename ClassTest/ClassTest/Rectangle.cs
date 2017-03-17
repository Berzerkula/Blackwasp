//http://www.blackwasp.co.uk/CSharpClassProperties.aspx
using System;

namespace ClassTest
{
    class Rectangle
    {
        private int _width;
        private int _height;

        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new OverflowException();
                }

                _width = value;
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new OverflowException();
                }

                _height = value;
            }
        }

        public int Area
        {
            get
            {
                return Height * Width;
            }
        }

        public int Perimeter
        {
            get
            {
                return 2 * (Height + Width);
            }
        }
    }
}
