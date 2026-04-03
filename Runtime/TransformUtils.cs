using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

namespace FunFact.Utils
{
    public static class TransformUtils
    {
        public static Transform GetChild(this Transform t, Index index)
        {
            return t.GetChild(index.IsFromEnd ? t.childCount-index.Value : index.Value);
        }
        
        public static IEnumerable<Transform> GetChildren(this Transform t)
        {
            for (var i = 0; i < t.childCount; i++) yield return t.GetChild(i);
        }
        
        public static IEnumerable<Transform> GetChildren(this Transform t, Range range)
        {
            var start = range.Start.IsFromEnd ? t.childCount - range.Start.Value : range.Start.Value;
            var end = range.End.IsFromEnd ? t.childCount - range.End.Value : range.End.Value;
            for (var i = start; i < end; i++) yield return t.GetChild(i);
        }
        
        public static void DestroyAllChildren(this Transform parent)
        {
            if (parent == null) return;
            int childCount = parent.childCount;
            for (int i = childCount - 1; i >= 0; i--) Object.Destroy(parent.GetChild(i).gameObject);
        }
    }
}