using UnityEngine;

namespace Coroutines
{
    /// <inheritdoc />
    /// <summary>
    /// 
    /// </summary>
    public class FadeUsingUpdate : MonoBehaviour
    {
        private Renderer _renderer;
        private bool _fadeOut;

        private void Start()
        {
            _renderer = GetComponent<Renderer>();
        }

        private void Update()
        {
            if (!Input.GetKeyDown(KeyCode.Alpha1))
                return;
            if (_fadeOut)
                FadeOut();
            else
                FadeIn();
        }

        /// <summary>
        /// 
        /// </summary>
        private void FadeIn()
        {
            for (var f = 0f; f <= 1; f += 0.1f)
            {
                var c = _renderer.material.color;
                c.a = f;
                _renderer.material.color = c;
            }

            _fadeOut = true;
        }

        private void FadeOut()
        {
            for (var f = 1f; f >= 0; f -= 0.1f)
            {
                var c = _renderer.material.color;
                c.a = f;
                _renderer.material.color = c;
            }

            _fadeOut = false;
        }
    }
}