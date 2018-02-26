using System;
using UnityEngine;

public static class DebugHelper
{
    public static Action DebugMessage(string message, string color)
    {
        return delegate { Debug.LogFormat("<color={1}>{0}</color>", message, color); };
    }
}