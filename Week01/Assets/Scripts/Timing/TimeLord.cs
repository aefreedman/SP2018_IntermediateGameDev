using System.Collections.Generic;
using Patterns;

namespace Timing
{
    public class TimeLord : LazySingleton<TimeLord>
    {
        private List<ITimer> _timers;
        private List<ITimer> _completedTimers;


        private void Start()
        {
            _timers = new List<ITimer>();
            _completedTimers = new List<ITimer>();
        }

        private void Update()
        {
            foreach (var timer in _timers)
            {
                if (timer.RunTimer())
                    _completedTimers.Add(timer);
            }

            foreach (var timer in _completedTimers)
            {
                _timers.Remove(timer);
            }

            _completedTimers = new List<ITimer>();
        }

        public void AddTimer(ITimer timer)
        {
            _timers.Add(timer);
        }
    }
}