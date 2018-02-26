using UnityEngine;

namespace Patterns
{
    /// <inheritdoc />
    /// <summary>
    /// This is a lazy hack version of singleton that doesn't really implement the pattern
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class LazySingleton<T> : MonoBehaviour where T : Object
    {
        private static T _instance;

        /// <summary>
        ///     Gets or sets the instance.
        /// </summary>
        /// <value>The instance.</value>
        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    Instance = FindObjectOfType<T>();
                }
                return _instance;
            }
            private set { _instance = value; }
        }
    }
}