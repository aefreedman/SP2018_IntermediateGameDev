using UnityEngine;
using UnityEngine.UI;

namespace Timing.Views
{
    [RequireComponent(typeof(Button))]
    public abstract class TimerButton : MonoBehaviour
    {
        [Range(0.1f, 300f)]
        public float InitTime;

        private Button _button;

        private void Start()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(InstantiateTimer);
        }

        protected abstract void InstantiateTimer();

        public void SetTime(float time)
        {
            InitTime = time;
        }
    }
}