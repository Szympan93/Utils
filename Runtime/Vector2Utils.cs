using UnityEngine;

namespace FunFact.Utils
{
    public static class Vector2Utils
    {
        public static Vector2 With(this Vector2 v, float? x = null, float? y = null) => new(x ?? v.x, y ?? v.y);
        
        public static Vector2 To00(this Vector2 v) => new(0, 0);
        public static Vector2 To0X(this Vector2 v) => new(0, v.x);
        public static Vector2 To0Y(this Vector2 v) => new(0, v.y);
        
        public static Vector2 ToX0(this Vector2 v) => new(v.x, 0);
        public static Vector2 ToXX(this Vector2 v) => new(v.x, v.x);
        public static Vector2 ToXY(this Vector2 v) => new(v.x, v.y);
        
        public static Vector2 ToY0(this Vector2 v) => new(v.y, 0);
        public static Vector2 ToYX(this Vector2 v) => new(v.y, v.x);
        public static Vector2 ToYY(this Vector2 v) => new(v.y, v.y);
    }
}
