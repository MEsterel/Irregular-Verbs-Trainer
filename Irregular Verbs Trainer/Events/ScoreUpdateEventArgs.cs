using System;

namespace IVT.Events
{
    public class ScoreUpdateEventArgs : EventArgs
    {
        public ScoreUpdateEventArgs(int points, int totalVerbs, int wonVerbs, int lostVerbs, int addedPoints, int lastMistakesNumber, int remainingChances)
        {
            Points = points;
            TotalVerbs = totalVerbs;
            WonVerbs = wonVerbs;
            LostVerbs = lostVerbs;
            LastMistakesNumber = lastMistakesNumber;
            AddedPoints = addedPoints;
            RemainingChances = remainingChances;
        }

        public int AddedPoints { get; private set; }
        public int LastMistakesNumber { get; private set; }
        public int LostVerbs { get; private set; }
        public int Points { get; private set; }
        public int RemainingChances { get; private set; }
        public int TotalVerbs { get; private set; }
        public int WonVerbs { get; private set; }
    }
}