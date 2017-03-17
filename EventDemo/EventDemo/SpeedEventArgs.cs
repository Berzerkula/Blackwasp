//http://www.blackwasp.co.uk/CSharpEvents_3.aspx
using System;

namespace EventDemo
{
    public class SpeedEventArgs : EventArgs
    {
        private int _excessSpeed;

        public int ExcessSpeed
        {
            get
            {
                return _excessSpeed;
            }

            set
            {
                _excessSpeed = value;
            }
        }
    }
}