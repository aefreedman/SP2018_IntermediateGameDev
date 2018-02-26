using Instantiation;
using UnityEngine;

namespace Timing.Views
{
    public class InstantiatePrefabTimerButton : TimerButton
    {
        public GameObject Prefab;
        [Range(0, 100f)] public float InstantiationRange;

        private void InstantiateSharpTimer(float time)
        {
            DebugHelper.DebugMessage("Timer start!", "green")(); // You need the extra () because DebugMessage returns a delegate (a function)
            var newTimer = new SharpTimer();

            // Time to do some fun stuff with lambda expressions
            newTimer.StartTimer(time, () =>
            {
                Instantiator.RandomRangeInstantiate(Prefab, -Vector3.one * InstantiationRange / 2, Vector3.one * InstantiationRange / 2);
                DebugHelper.DebugMessage("New prefab!", "cyan");
            });
            TimeLord.Instance.AddTimer(newTimer);
        }

        protected override void InstantiateTimer()
        {
            InstantiateSharpTimer(InitTime);
        }
    }
}