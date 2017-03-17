//http://www.blackwasp.co.uk/AbstractClasses_2.aspx
using System;

namespace AbstractClassDemo
{
    class Sphere : ThreeDObject
    {
        public override double SurfaceArea
        {
            get { return 4 * Math.PI * Math.Pow(Height / 2, 2); }
        }

        public override double CalculateVolume()
        {
            return (4 / 3) * Math.PI * Math.Pow(Height / 2, 3);
        }
    }
}
