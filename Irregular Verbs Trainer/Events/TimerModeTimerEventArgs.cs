using System;

namespace IVT.Events
{
    public class TimerModeTimerEventArgs : EventArgs
    {
        public TimerModeTimerEventArgs(TimeSpan remainingTime)
        {
            RemainingTime = remainingTime;
        }

        public TimeSpan RemainingTime { get; private set; }
    }
}