using System;

namespace Timing
{
    /// <summary>
    /// An interface is a contract that allows you to assume that a class that implements the interface will have a set of predefined members
    /// "Every timer should have these basic functions"
    /// </summary>
    public interface ITimer
    {
        void StartTimer(float timerLength, Action onTimerEnd, bool loop = false);
        /// <summary>
        /// Returns true if timer is over
        /// </summary>
        bool RunTimer();
        void ResetTimer();
    }
}