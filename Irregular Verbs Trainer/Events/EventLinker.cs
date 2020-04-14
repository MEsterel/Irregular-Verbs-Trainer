using System;

namespace IVT.Events
{
    public static class EventLinker
    {
        public static event EventHandler ScoreUpdate;

        public static event EventHandler TimerModeTimeOver;

        public static event EventHandler TimerModeTimerStarted;

        public static event EventHandler TimerModeTimerStopped;

        /// <summary>
        /// Raise Score Stats updated event
        /// </summary>
        /// <param name="totalVerbs"></param>
        /// <param name="wonVerbs"></param>
        /// <param name="lostVerbs"></param>
        /// <param name="lastMistakesNumber">Indicate -1 if N/A (e.G reset)</param>
        /// <param name="remainingChances">Indicate -1 if N/A (e.G reset)</param>
        public static void RaiseScoreUpdate(int points, int totalVerbs, int wonVerbs, int lostVerbs, int addedPoints, int lastMistakesNumber, int remainingChances)
        {
            ScoreUpdate?.Invoke(null, new ScoreUpdateEventArgs(points, totalVerbs, wonVerbs, lostVerbs, addedPoints, lastMistakesNumber, remainingChances));
        }

        public static void RaiseTimerModeTimeOver(TimeSpan remainingTime, int interval = 1000)
        {
            TimerModeTimeOver?.Invoke(null, new TimerModeTimerEventArgs(remainingTime));
        }

        public static void RaiseTimerModeTimerStarted(TimeSpan remainingTime, int interval = 1000)
        {
            TimerModeTimerStarted?.Invoke(null, new TimerModeTimerEventArgs(remainingTime));
        }

        public static void RaiseTimerModeTimerStopped(TimeSpan remainingTime, int interval = 1000)
        {
            TimerModeTimerStopped?.Invoke(null, new TimerModeTimerEventArgs(remainingTime));
        }
    }
}