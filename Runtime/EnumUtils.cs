using System;

namespace FunFact.Utils
{
    public static class EnumUtils
    {
        private static long ToLong<T>(this T value)  where T : Enum => Convert.ToInt64(Convert.ChangeType(value, Enum.GetUnderlyingType(typeof(T))));
        private static T FromLong<T>(long value) where T : Enum => (T)Convert.ChangeType(value, Enum.GetUnderlyingType(typeof(T)));
        public static T With<T>(this T value, T added) where T : Enum => FromLong<T>(value.ToLong() | added.ToLong());
        public static T Without<T>(this T value, T removed) where T : Enum => FromLong<T>(value.ToLong() & ~removed.ToLong());
    
        public static T With<T>(this T value, params T[] added) where T : Enum
        {
            var val = value.ToLong();
            for (int i = 0; i < added.Length; i++) val |= added[i].ToLong();
            return FromLong<T>(val);
        }
    
        public static T Without<T>(this T value, params T[] removed) where T : Enum
        {
            var val = value.ToLong();
            for (int i = 0; i < removed.Length; i++) val &= ~removed[i].ToLong();
            return FromLong<T>(val);
        }
    
        public static bool Has<T>(this T value, T flag) where T : Enum
        {
            var flagLong = flag.ToLong();
            return (value.ToLong() & flagLong) == flagLong;
        }
    
        public static bool HasAll<T>(this T value, params T[] flags) where T : Enum
        {
            var valLong = value.ToLong();
            for (int i = 0; i < flags.Length; i++)
            {
                var flagVal = flags[i].ToLong();
                if ((valLong & flagVal) != flagVal) return false;
            }
            return true;
        }
    
        public static bool HasAny<T>(this T value, params T[] flags) where T : Enum
        {
            var valLong = value.ToLong();
            for (int i = 0; i < flags.Length; i++)
            {
                var flagVal = flags[i].ToLong();
                if ((valLong & flagVal) == flagVal) return true;
            }
            return false;
        }
    }
}