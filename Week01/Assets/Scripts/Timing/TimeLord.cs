using System.Collections.Generic;
using Patterns;

namespace Timing
{
    public class TimeLord : LazySingleton<TimeLord>
    {
        private List<ITimer> _timers;
        private List<ITimer> _completedTimers;

        // TimeLord should probably not be a singleton: if you want groups of timers, you'll want multiple TimeLords
        // TimeLord could be a normal C# class, and any object that needs to use timers can make it's own instance of TimeLord
        // However, because TimeLord is a MonoBehavior, you can pause all timers in the list by deactivating the script
        // (or adding state to the script)
        
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

            // You can't remove objects from a list while iterating over the list
            // so you remove them after you're done
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