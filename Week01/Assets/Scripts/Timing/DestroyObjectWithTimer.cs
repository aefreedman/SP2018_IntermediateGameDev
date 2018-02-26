namespace Timing
{
    public class DestroyObjectWithTimer : MonoTimer
    {
        public float DestroyTimer = 1;

        private void Start()
        {
            // Inherited from MonoTimer
            // We're replacing the delegate that MonoTimer calls when the timer expires with a call to Destroy()
            StartTimer(DestroyTimer, () => Destroy(gameObject));
        }
    }
}