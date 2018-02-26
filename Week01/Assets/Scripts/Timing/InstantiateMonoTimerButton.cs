using JetBrains.Annotations;
using UnityEngine;

namespace Timing
{   
    public class InstantiateMonoTimerButton : MonoBehaviour
    {
        [UsedImplicitly] // Rider thing
        public void InstantiateMonoTimer(float time)
        {
            DebugHelper.DebugMessage("Timer start!", "green")(); // You need the extra () because DebugMessage returns a delegate (a function)

            gameObject.AddComponent<MonoTimer>().StartTimer(time, DebugHelper.DebugMessage("Timer end!", "red"));
        }
    }
}