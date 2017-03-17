//http://www.blackwasp.co.uk/AbstractClasses_2.aspx
using System;

namespace AbstractClassDemo
{
    class Cube : ThreeDObject
    {
        public override double SurfaceArea
        {
            get { return Math.Pow(Height, 2) * 6; }
        }

        public override double CalculateVolume()
        {
            return Math.Pow(Height, 3);
        }
    }
}
