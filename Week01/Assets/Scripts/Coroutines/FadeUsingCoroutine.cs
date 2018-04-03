using System.Collections;
using UnityEngine;

namespace Coroutines
{
    public class FadeUsingCoroutine : MonoBehaviour
    {
        private Renderer _renderer;
        private bool _fadeOut;
        [Range(1f, 10f)] public float Smoothing;

        private void Start()
        {
            _renderer = GetComponent<Renderer>();
        }

        private void Update()
        {
            if (!Input.GetKeyDown(KeyCode.Alpha1))
                return;
            StopAllCoroutines();
            
            // StartCoroutine([Function]);
            // Ternary operator:
            // bool ? A : B
            
            StartCoroutine(_fadeOut ? FadeOut() : FadeIn());
        }

        /// <summary>
        /// 
        /// </summary>
        private IEnumerator FadeIn()
        {
            for (var f = _renderer.material.color.a; f <= 1; f += 1 / Smoothing * Time.deltaTime)
            {
                var c = _renderer.material.color;
                c.a = f;
                _renderer.material.color = c;
                yield return null;
            }

            _fadeOut = true;
            Debug.Log("Finished fade in!");
        }

        private IEnumerator FadeOut()
        {
            for (var f = _renderer.material.color.a; f >= 0; f -= 1 / Smoothing * Time.deltaTime)
            {
                var c = _renderer.material.color;
                c.a = f;
                _renderer.material.color = c;
                yield return null;
            }

            _fadeOut = false;
            Debug.Log("Finished fade out!");
        }
    }
}