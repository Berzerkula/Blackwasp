//http://www.blackwasp.co.uk/CSharpStaticBehaviour.aspx
using System;

namespace ClassTest
{
    class MassCalculator
    {
        private static int _callCount;

        public static int CalculateMass(int density, int volume)
        {
            _callCount++;
            return density * volume;
        }
        public static int CallCount
        {
            get
            {
                return _callCount;
            }
        }
    }
}
