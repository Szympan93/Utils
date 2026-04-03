using UnityEngine;

namespace FunFact.Utils
{
    public static class Vector3Utils
    {
        public static Vector3 With(this Vector3 v, float? x = null, float? y = null, float? z = null) => new(x ?? v.x, y ?? v.y, z ?? v.z);
        
        public static Vector2 To00(this Vector3 v) => new(0, 0);
        public static Vector2 To0X(this Vector3 v) => new(0, v.x);
        public static Vector2 To0Y(this Vector3 v) => new(0, v.y);
        public static Vector2 To0Z(this Vector3 v) => new(0, v.z);
        
        public static Vector2 ToX0(this Vector3 v) => new(v.x, 0);
        public static Vector2 ToXX(this Vector3 v) => new(v.x, v.x);
        public static Vector2 ToXY(this Vector3 v) => new(v.x, v.y);
        public static Vector2 ToXZ(this Vector3 v) => new(v.x, v.z);
        
        public static Vector2 ToY0(this Vector3 v) => new(v.y, 0);
        public static Vector2 ToYX(this Vector3 v) => new(v.y, v.x);
        public static Vector2 ToYY(this Vector3 v) => new(v.y, v.y);
        public static Vector2 ToYZ(this Vector3 v) => new(v.y, v.z);
        
        public static Vector2 ToZ0(this Vector3 v) => new(v.z, 0);
        public static Vector2 ToZX(this Vector3 v) => new(v.z, v.x);
        public static Vector2 ToZY(this Vector3 v) => new(v.z, v.y);
        public static Vector2 ToZZ(this Vector3 v) => new(v.z, v.z);
    }
}
