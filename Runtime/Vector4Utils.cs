
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
        
        public static Vector3 To000(this Vector4 v) => new(0  , 0  , 0  );
        public static Vector3 To00X(this Vector4 v) => new(0  , 0  , v.x);
        public static Vector3 To00Y(this Vector4 v) => new(0  , 0  , v.y);
        public static Vector3 To00Z(this Vector4 v) => new(0  , 0  , v.z);
        public static Vector3 To00W(this Vector4 v) => new(0  , 0  , v.w);
        
        public static Vector3 To0X0(this Vector4 v) => new(0  , v.x, 0  );
        public static Vector3 To0XX(this Vector4 v) => new(0  , v.x, v.x);
        public static Vector3 To0XY(this Vector4 v) => new(0  , v.x, v.y);
        public static Vector3 To0XZ(this Vector4 v) => new(0  , v.x, v.z);
        public static Vector3 To0XW(this Vector4 v) => new(0  , v.x, v.w);
        
        public static Vector3 To0Y0(this Vector4 v) => new(0  , v.y, 0  );
        public static Vector3 To0YX(this Vector4 v) => new(0  , v.y, v.x);
        public static Vector3 To0YY(this Vector4 v) => new(0  , v.y, v.y);
        public static Vector3 To0YZ(this Vector4 v) => new(0  , v.y, v.z);
        public static Vector3 To0YW(this Vector4 v) => new(0  , v.y, v.w);
        
        public static Vector3 To0Z0(this Vector4 v) => new(0  , v.z, 0  );
        public static Vector3 To0ZX(this Vector4 v) => new(0  , v.z, v.x);
        public static Vector3 To0ZY(this Vector4 v) => new(0  , v.z, v.y);
        public static Vector3 To0ZZ(this Vector4 v) => new(0  , v.z, v.z);
        public static Vector3 To0ZW(this Vector4 v) => new(0  , v.z, v.w);
        
        public static Vector3 To0W0(this Vector4 v) => new(0  , v.w, 0  );
        public static Vector3 To0WX(this Vector4 v) => new(0  , v.w, v.x);
        public static Vector3 To0WY(this Vector4 v) => new(0  , v.w, v.y);
        public static Vector3 To0WZ(this Vector4 v) => new(0  , v.w, v.z);
        public static Vector3 To0WW(this Vector4 v) => new(0  , v.w, v.w);
        
        public static Vector3 ToX00(this Vector4 v) => new(v.x, 0  , 0  );
        public static Vector3 ToX0X(this Vector4 v) => new(v.x, 0  , v.x);
        public static Vector3 ToX0Y(this Vector4 v) => new(v.x, 0  , v.y);
        public static Vector3 ToX0Z(this Vector4 v) => new(v.x, 0  , v.z);
        public static Vector3 ToX0W(this Vector4 v) => new(v.x, 0  , v.w);
        
        public static Vector3 ToXX0(this Vector4 v) => new(v.x, v.x, 0  );
        public static Vector3 ToXXX(this Vector4 v) => new(v.x, v.x, v.x);
        public static Vector3 ToXXY(this Vector4 v) => new(v.x, v.x, v.y);
        public static Vector3 ToXXZ(this Vector4 v) => new(v.x, v.x, v.z);
        public static Vector3 ToXXW(this Vector4 v) => new(v.x, v.x, v.w);
        
        public static Vector3 ToXY0(this Vector4 v) => new(v.x, v.y, 0  );
        public static Vector3 ToXYX(this Vector4 v) => new(v.x, v.y, v.x);
        public static Vector3 ToXYY(this Vector4 v) => new(v.x, v.y, v.y);
        public static Vector3 ToXYZ(this Vector4 v) => new(v.x, v.y, v.z);
        public static Vector3 ToXYW(this Vector4 v) => new(v.x, v.y, v.w);
        
        public static Vector3 ToXZ0(this Vector4 v) => new(v.x, v.z, 0  );
        public static Vector3 ToXZX(this Vector4 v) => new(v.x, v.z, v.x);
        public static Vector3 ToXZY(this Vector4 v) => new(v.x, v.z, v.y);
        public static Vector3 ToXZZ(this Vector4 v) => new(v.x, v.z, v.z);
        public static Vector3 ToXZW(this Vector4 v) => new(v.x, v.z, v.w);
        
        public static Vector3 ToXW0(this Vector4 v) => new(v.x, v.w, 0  );
        public static Vector3 ToXWX(this Vector4 v) => new(v.x, v.w, v.x);
        public static Vector3 ToXWY(this Vector4 v) => new(v.x, v.w, v.y);
        public static Vector3 ToXWZ(this Vector4 v) => new(v.x, v.w, v.z);
        public static Vector3 ToXWW(this Vector4 v) => new(v.x, v.w, v.w);
        
        public static Vector3 ToY00(this Vector4 v) => new(v.y, 0  , 0  );
        public static Vector3 ToY0X(this Vector4 v) => new(v.y, 0  , v.x);
        public static Vector3 ToY0Y(this Vector4 v) => new(v.y, 0  , v.y);
        public static Vector3 ToY0Z(this Vector4 v) => new(v.y, 0  , v.z);
        public static Vector3 ToY0W(this Vector4 v) => new(v.y, 0  , v.w);
        
        public static Vector3 ToYX0(this Vector4 v) => new(v.y, v.x, 0  );
        public static Vector3 ToYXX(this Vector4 v) => new(v.y, v.x, v.x);
        public static Vector3 ToYXY(this Vector4 v) => new(v.y, v.x, v.y);
        public static Vector3 ToYXZ(this Vector4 v) => new(v.y, v.x, v.z);
        public static Vector3 ToYXW(this Vector4 v) => new(v.y, v.x, v.w);
        
        public static Vector3 ToYY0(this Vector4 v) => new(v.y, v.y, 0  );
        public static Vector3 ToYYX(this Vector4 v) => new(v.y, v.y, v.x);
        public static Vector3 ToYYY(this Vector4 v) => new(v.y, v.y, v.y);
        public static Vector3 ToYYZ(this Vector4 v) => new(v.y, v.y, v.z);
        public static Vector3 ToYYW(this Vector4 v) => new(v.y, v.y, v.w);
        
        public static Vector3 ToYZ0(this Vector4 v) => new(v.y, v.z, 0  );
        public static Vector3 ToYZX(this Vector4 v) => new(v.y, v.z, v.x);
        public static Vector3 ToYZY(this Vector4 v) => new(v.y, v.z, v.y);
        public static Vector3 ToYZZ(this Vector4 v) => new(v.y, v.z, v.z);
        public static Vector3 ToYZW(this Vector4 v) => new(v.y, v.z, v.w);
        
        public static Vector3 ToYW0(this Vector4 v) => new(v.y, v.w, 0  );
        public static Vector3 ToYWX(this Vector4 v) => new(v.y, v.w, v.x);
        public static Vector3 ToYWY(this Vector4 v) => new(v.y, v.w, v.y);
        public static Vector3 ToYWZ(this Vector4 v) => new(v.y, v.w, v.z);
        public static Vector3 ToYWW(this Vector4 v) => new(v.y, v.w, v.w);
        
        public static Vector3 ToZ00(this Vector4 v) => new(v.z, 0  , 0  );
        public static Vector3 ToZ0X(this Vector4 v) => new(v.z, 0  , v.x);
        public static Vector3 ToZ0Y(this Vector4 v) => new(v.z, 0  , v.y);
        public static Vector3 ToZ0Z(this Vector4 v) => new(v.z, 0  , v.z);
        public static Vector3 ToZ0W(this Vector4 v) => new(v.z, 0  , v.w);
        
        public static Vector3 ToZX0(this Vector4 v) => new(v.z, v.x, 0  );
        public static Vector3 ToZXX(this Vector4 v) => new(v.z, v.x, v.x);
        public static Vector3 ToZXY(this Vector4 v) => new(v.z, v.x, v.y);
        public static Vector3 ToZXZ(this Vector4 v) => new(v.z, v.x, v.z);
        public static Vector3 ToZXW(this Vector4 v) => new(v.z, v.x, v.w);
        
        public static Vector3 ToZY0(this Vector4 v) => new(v.z, v.y, 0  );
        public static Vector3 ToZYX(this Vector4 v) => new(v.z, v.y, v.x);
        public static Vector3 ToZYY(this Vector4 v) => new(v.z, v.y, v.y);
        public static Vector3 ToZYZ(this Vector4 v) => new(v.z, v.y, v.z);
        public static Vector3 ToZYW(this Vector4 v) => new(v.z, v.y, v.w);
        
        public static Vector3 ToZZ0(this Vector4 v) => new(v.z, v.z, 0  );
        public static Vector3 ToZZX(this Vector4 v) => new(v.z, v.z, v.x);
        public static Vector3 ToZZY(this Vector4 v) => new(v.z, v.z, v.y);
        public static Vector3 ToZZZ(this Vector4 v) => new(v.z, v.z, v.z);
        public static Vector3 ToZZW(this Vector4 v) => new(v.z, v.z, v.w);
        
        public static Vector3 ToZW0(this Vector4 v) => new(v.z, v.w, 0  );
        public static Vector3 ToZWX(this Vector4 v) => new(v.z, v.w, v.x);
        public static Vector3 ToZWY(this Vector4 v) => new(v.z, v.w, v.y);
        public static Vector3 ToZWZ(this Vector4 v) => new(v.z, v.w, v.z);
        public static Vector3 ToZWW(this Vector4 v) => new(v.z, v.w, v.w);
        
        public static Vector3 ToW00(this Vector4 v) => new(v.w, 0  , 0  );
        public static Vector3 ToW0X(this Vector4 v) => new(v.w, 0  , v.x);
        public static Vector3 ToW0Y(this Vector4 v) => new(v.w, 0  , v.y);
        public static Vector3 ToW0Z(this Vector4 v) => new(v.w, 0  , v.z);
        public static Vector3 ToW0W(this Vector4 v) => new(v.w, 0  , v.w);
        
        public static Vector3 ToWX0(this Vector4 v) => new(v.w, v.x, 0  );
        public static Vector3 ToWXX(this Vector4 v) => new(v.w, v.x, v.x);
        public static Vector3 ToWXY(this Vector4 v) => new(v.w, v.x, v.y);
        public static Vector3 ToWXZ(this Vector4 v) => new(v.w, v.x, v.z);
        public static Vector3 ToWXW(this Vector4 v) => new(v.w, v.x, v.w);
        
        public static Vector3 ToWY0(this Vector4 v) => new(v.w, v.y, 0  );
        public static Vector3 ToWYX(this Vector4 v) => new(v.w, v.y, v.x);
        public static Vector3 ToWYY(this Vector4 v) => new(v.w, v.y, v.y);
        public static Vector3 ToWYZ(this Vector4 v) => new(v.w, v.y, v.z);
        public static Vector3 ToWYW(this Vector4 v) => new(v.w, v.y, v.w);
        
        public static Vector3 ToWZ0(this Vector4 v) => new(v.w, v.z, 0  );
        public static Vector3 ToWZX(this Vector4 v) => new(v.w, v.z, v.x);
        public static Vector3 ToWZY(this Vector4 v) => new(v.w, v.z, v.y);
        public static Vector3 ToWZZ(this Vector4 v) => new(v.w, v.z, v.z);
        public static Vector3 ToWZW(this Vector4 v) => new(v.w, v.z, v.w);
        
        public static Vector3 ToWW0(this Vector4 v) => new(v.w, v.w, 0  );
        public static Vector3 ToWWX(this Vector4 v) => new(v.w, v.w, v.x);
        public static Vector3 ToWWY(this Vector4 v) => new(v.w, v.w, v.y);
        public static Vector3 ToWWZ(this Vector4 v) => new(v.w, v.w, v.z);
        public static Vector3 ToWWW(this Vector4 v) => new(v.w, v.w, v.w);
    }
}
