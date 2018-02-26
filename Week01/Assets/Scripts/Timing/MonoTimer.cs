using System;
using UnityEngine;

namespace Timing
{
    /// <inheritdoc cref="ITimer" />
    /// <summary>
    /// Each instance of MonoTimer is independent of other MonoTimers
    /// If you need to pause or remove a MonoTimer, you need to find the correct MonoTimer
    /// </summary>
    public class MonoTimer : MonoBehaviour, ITimer
    {
        private float _timer;
        private float _timerInit;
        private bool _timerLoop;
        private Action _onTimerEndDelegate;

        private void Update()
        {
            if (RunTimer()) Destroy(this);
        }

        public bool RunTimer()
        {
            if (_timer <= 0)
            {
                _onTimerEndDelegate();
                if (_timerLoop) ResetTimer();
                return true;
            }
            _timer -= Time.deltaTime;
//            Debug.Log(_timer);
            return false;
        }

        public void StartTimer(float timerLength, Action onTimerEnd, bool loop = false)
        {
            _timerInit = timerLength;
            _timer = timerLength;
            _timerLoop = loop;
            if (onTimerEnd != null)
                _onTimerEndDelegate = onTimerEnd;
        }

        public void ResetTimer()
        {
            _timer = _timerInit;
        }
    }
}