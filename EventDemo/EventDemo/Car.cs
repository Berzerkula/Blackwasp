//http://www.blackwasp.co.uk/CSharpEvents.aspx
using System;

namespace EventDemo
{
    //public delegate void SpeedLimitExceededEventHandler(object source, EventArgs e);
    public delegate void SpeedLimitExceededEventHandler(object source, SpeedEventArgs e);

    public class Car
    {
        private int _speed = 0;
        private int _safetySpeed = 70;

        public int Speed
        {
            get
            {
                return _speed;
            }
        }

        public void Accelerate(int mph)
        {
            int oldSpeed = _speed;
            _speed += mph;

            if (oldSpeed <= _safetySpeed && _speed > _safetySpeed)
            //OnSpeedLimitExceeded(new EventArgs());
            {
                SpeedEventArgs e = new EventDemo.SpeedEventArgs();
                e.ExcessSpeed = _speed - _safetySpeed;
                OnSpeedLimitExceeded(e);
            }
        }

        public event SpeedLimitExceededEventHandler SpeedLimitExceeded;

        //public virtual void OnSpeedLimitExceeded(EventArgs e)
        public virtual void OnSpeedLimitExceeded(SpeedEventArgs e)
        {
            if (SpeedLimitExceeded != null)
            {
                SpeedLimitExceeded(this, e);
            }
        }
    }
}
