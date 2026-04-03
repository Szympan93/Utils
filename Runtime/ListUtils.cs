using System.Collections;
using System.Collections.Generic;

namespace FunFact.Utils
{
    public static class ListUtils
    {
        public static void RemoveAtSwapBack(this IList list, int i)
        {
            list[i] = list[^1];
            list.RemoveAt(list.Count - 1);
        }
        
        public static void RemoveAtSwapBack<T>(this IList<T> list, int i)
        {
            list[i] = list[^1];
            list.RemoveAt(list.Count - 1);
        }
        
        public static bool RemoveSwapBack(this IList list, object i)
        {
            var index = list.IndexOf(i);
            if (index < 0) return false;
            list.RemoveAtSwapBack(index);
            return true;
        }
        
        public static bool RemoveSwapBack<T>(this IList<T> list, T i)
        {
            var index = list.IndexOf(i);
            if (index < 0) return false;
            list.RemoveAtSwapBack(index);
            return true;
        }
    }
}
