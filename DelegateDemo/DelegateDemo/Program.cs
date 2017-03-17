//http://www.blackwasp.co.uk/CSharpDelegates.aspx
using System;

namespace DelegateDemo
{
    class Program
    {
        delegate int CalculateScore(int seconds, int targets);
        delegate void ShowStatus();

        static void Main(string[] args)
        {
            /*CalculateScore getScore;
            int time = 60;
            int targets = 20;

            getScore = new CalculateScore(Scoreboard.CalculateAdultScore);
            Console.WriteLine("Adult score: {0}", getScore(time, targets));

            getScore = new CalculateScore(Scoreboard.CalculateChildScore);
            Console.WriteLine("Child score: {0}", getScore(time, targets));

            getScore = null;*/

            //http://www.blackwasp.co.uk/CSharpDelegates_2.aspx
            //Referencing multiple methods

            Scoreboard board = new DelegateDemo.Scoreboard();

            ShowStatus points = new ShowStatus(board.PointsAwarded);
            ShowStatus hit = new ShowStatus(board.TargetHit);

            ShowStatus display = points;
            display += hit;

            display();

            display -= points;
            points = null;
        }
    }
}
