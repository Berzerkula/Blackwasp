//http://www.blackwasp.co.uk/CSharpDelegates.aspx
using System;

namespace DelegateDemo
{
    class Scoreboard
    {
        // 10 points per target, -2 point per second
        public static int CalculateAdultScore(int seconds, int targets)
        {
            return (targets * 10) - (seconds * 2);
        }

        // 15 points per target, -1 point per second
        public static int CalculateChildScore(int seconds, int targets)
        {
            return (targets * 15) - seconds;
        }

        // Target hit message
        public void TargetHit()
        {
            Console.WriteLine("Target hit!");
        }

        // Points awarded message
        public void PointsAwarded()
        {
            Console.WriteLine("Points awarded!");
        }
    }
}
