//http://www.blackwasp.co.uk/AbstractClasses.aspx
using System;

namespace AbstractClassDemo
{
    abstract class ThreeDObject
    {
        /*
        public abstract int ReadWriteProperty { get; set; }
        public abstract int ReadOnlyProperty { get; }
        public abstract int WriteOnlyProperty { set; }
        */

        public abstract double SurfaceArea { get; }

        public abstract double CalculateVolume();

        private double _height;

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public double CalculateVolumeToAreaRatio()
        {
            return CalculateVolume() / SurfaceArea;
        }
    }
}
