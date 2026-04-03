
using UnityEngine;

namespace FunFact.Utils
{
    public static class Vector4Utils
    {
        public static Vector4 With(this Vector4 v, float? x = null, float? y = null, float? z = null, float? w = null) => new(x ?? v.x, y ?? v.y, z ?? v.z, w ?? v.w);
        
        public static Vector2 To00(this Vector4 v) => new(0  , 0  );
        public static Vector2 To0X(this Vector4 v) => new(0  , v.x);
        public static Vector2 To0Y(this Vector4 v) => new(0  , v.y);
        public static Vector2 To0Z(this Vector4 v) => new(0  , v.z);
        public static Vector2 To0W(this Vector4 v) => new(0  , v.w);
        
        public static Vector2 ToX0(this Vector4 v) => new(v.x, 0  );
        public static Vector2 ToXX(this Vector4 v) => new(v.x, v.x);
        public static Vector2 ToXY(this Vector4 v) => new(v.x, v.y);
        public static Vector2 ToXZ(this Vector4 v) => new(v.x, v.z);
        public static Vector2 ToXW(this Vector4 v) => new(v.x, v.w);
        
        public static Vector2 ToY0(this Vector4 v) => new(v.y, 0  );
        public static Vector2 ToYX(this Vector4 v) => new(v.y, v.x);
        public static Vector2 ToYY(this Vector4 v) => new(v.y, v.y);
        public static Vector2 ToYZ(this Vector4 v) => new(v.y, v.z);
        public static Vector2 ToYW(this Vector4 v) => new(v.y, v.w);
        
        public static Vector2 ToZ0(this Vector4 v) => new(v.z, 0  );
        public static Vector2 ToZX(this Vector4 v) => new(v.z, v.x);
        public static Vector2 ToZY(this Vector4 v) => new(v.z, v.y);
        public static Vector2 ToZZ(this Vector4 v) => new(v.z, v.z);
        public static Vector2 ToZW(this Vector4 v) => new(v.z, v.w);
        
        public static Vector2 ToW0(this Vector4 v) => new(v.w, 0  );
        public static Vector2 ToWX(this Vector4 v) => new(v.w, v.x);
        public static Vector2 ToWY(this Vector4 v) => new(v.w, v.y);
        public static Vector2 ToWZ(this Vector4 v) => new(v.w, v.z);
        public static Vector2 ToWW(this Vector4 v) => new(v.w, v.w);
    }
}
