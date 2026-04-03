using UnityEngine;

namespace FunFact.Utils
{
    public static class ComponentUtils
    {
        public static bool TryGetComponentInParent<T>(this Component c, out T component) => (component = c.GetComponentInParent<T>()) != null;
        public static bool TryGetComponentInChildren<T>(this Component c, out T component) => (component = c.GetComponentInChildren<T>()) != null;
        public static bool TryGetComponentInParent<T>(this GameObject go, out T component) => (component = go.GetComponentInParent<T>()) != null;
        public static bool TryGetComponentInChildren<T>(this GameObject go, out T component) => (component = go.GetComponentInChildren<T>()) != null;
    }
}
