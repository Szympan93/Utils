using UnityEngine;

namespace FunFact.Utils
{
    public static class AnimUtils
    {
        public static float DampedLerpT(float time) => 1 - Mathf.Pow(0.5f, time);
    }
}