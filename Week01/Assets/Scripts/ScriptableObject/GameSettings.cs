using System;
using UnityEngine;

namespace ScriptableObject
{
    [CreateAssetMenu(fileName = "GameSettings", menuName = "Settings/GameSettings")]
    public class GameSettings : UnityEngine.ScriptableObject
    {
        public Settings.Player PlayerSettings;
        public Settings.Player PlayerSettings2;
        public Settings.Enemies EnemySettings;
    }

    public class Settings
    {
        [Serializable]
        public class Player
        {
            public int SomeNumber;
            public float SomeFloat;
            
        }
        
        [Serializable]
        public class Enemies
        {
            public int Health;
        }
    }
}