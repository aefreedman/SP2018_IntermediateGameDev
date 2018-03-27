using UnityEngine;

namespace ScriptableObject
{
    public class ExampleScriptableObjectUser : MonoBehaviour
    {
        public GameSettings GameSettings;

        public void Start()
        {
            Debug.Log(GameSettings.PlayerSettings.SomeFloat.ToString("F1"));
        }
    }
}