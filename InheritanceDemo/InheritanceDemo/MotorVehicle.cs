//http://www.blackwasp.co.uk/Inheritance_2.aspx
using System;

namespace InheritanceDemo
{
    class MotorVehicle : Vehicle
    {
        private float _fuelRemaining;
        private float _tankSize;

        public float FuelRemaining
        {
            get { return _fuelRemaining; }
        }

        public float TankSize
        {
            get { return _tankSize; }
            set { _tankSize = value; }
        }

        public float Refuel()
        {
            float fuelRequired = _tankSize - _fuelRemaining;
            _fuelRemaining = _tankSize;
            return fuelRequired;
        }

        public override void Indicate(bool turningLeft)
        {
            if (turningLeft)
                Console.WriteLine("Flashing left indicator");
            else
                Console.WriteLine("Flashing right indicator");

        }

        //http://www.blackwasp.co.uk/Inheritance_5.aspx
        protected int _speed;
        public int Mpg
        {
            get
            {
                if (_speed == 0)
                    return 0;
                else if (_speed < 20)
                    return 50;
                else if (_speed < 50)
                    return 40;
                else
                    return 35;
            }
        }
    }
}
