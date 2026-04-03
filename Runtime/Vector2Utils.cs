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
        
        public static Vector3 To000(this Vector2 v) => new(0  , 0  , 0  );
        public static Vector3 To00X(this Vector2 v) => new(0  , 0  , v.x);
        public static Vector3 To00Y(this Vector2 v) => new(0  , 0  , v.y);
        
        public static Vector3 To0X0(this Vector2 v) => new(0  , v.x, 0  );
        public static Vector3 To0XX(this Vector2 v) => new(0  , v.x, v.x);
        public static Vector3 To0XY(this Vector2 v) => new(0  , v.x, v.y);
        
        public static Vector3 To0Y0(this Vector2 v) => new(0  , v.y, 0  );
        public static Vector3 To0YX(this Vector2 v) => new(0  , v.y, v.x);
        public static Vector3 To0YY(this Vector2 v) => new(0  , v.y, v.y);
        
        public static Vector3 ToX00(this Vector2 v) => new(v.x, 0  , 0  );
        public static Vector3 ToX0X(this Vector2 v) => new(v.x, 0  , v.x);
        public static Vector3 ToX0Y(this Vector2 v) => new(v.x, 0  , v.y);
        
        public static Vector3 ToXX0(this Vector2 v) => new(v.x, v.x, 0  );
        public static Vector3 ToXXX(this Vector2 v) => new(v.x, v.x, v.x);
        public static Vector3 ToXXY(this Vector2 v) => new(v.x, v.x, v.y);
        
        public static Vector3 ToXY0(this Vector2 v) => new(v.x, v.y, 0  );
        public static Vector3 ToXYX(this Vector2 v) => new(v.x, v.y, v.x);
        public static Vector3 ToXYY(this Vector2 v) => new(v.x, v.y, v.y);
        
        public static Vector3 ToY00(this Vector2 v) => new(v.y, 0  , 0  );
        public static Vector3 ToY0X(this Vector2 v) => new(v.y, 0  , v.x);
        public static Vector3 ToY0Y(this Vector2 v) => new(v.y, 0  , v.y);
        
        public static Vector3 ToYX0(this Vector2 v) => new(v.y, v.x, 0  );
        public static Vector3 ToYXX(this Vector2 v) => new(v.y, v.x, v.x);
        public static Vector3 ToYXY(this Vector2 v) => new(v.y, v.x, v.y);
        
        public static Vector3 ToYY0(this Vector2 v) => new(v.y, v.y, 0  );
        public static Vector3 ToYYX(this Vector2 v) => new(v.y, v.y, v.x);
        public static Vector3 ToYYY(this Vector2 v) => new(v.y, v.y, v.y);
    }
}
