using JetBrains.Annotations;
using UnityEngine;

namespace Timing.Views
{   
    public class InstantiateMonoTimerButton : TimerButton
    {
        private void InstantiateMonoTimer(float time)
        {
            DebugHelper.DebugMessage("Timer start!", "green")(); // You need the extra () because DebugMessage returns a delegate (a function)

            gameObject.AddComponent<MonoTimer>().StartTimer(time, DebugHelper.DebugMessage("Timer end!", "red"));
        }

        protected override void InstantiateTimer()
        {
            InstantiateMonoTimer(InitTime);
        }
    }
}