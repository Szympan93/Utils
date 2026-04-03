
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
        
        public static Vector4 To0000(this Vector4 v) => new(0  , 0  , 0  , 0  );
        public static Vector4 To000X(this Vector4 v) => new(0  , 0  , 0  , v.x);
        public static Vector4 To000Y(this Vector4 v) => new(0  , 0  , 0  , v.y);
        public static Vector4 To000Z(this Vector4 v) => new(0  , 0  , 0  , v.z);
        public static Vector4 To000W(this Vector4 v) => new(0  , 0  , 0  , v.w);
        
        public static Vector4 To00X0(this Vector4 v) => new(0  , 0  , v.x, 0  );
        public static Vector4 To00XX(this Vector4 v) => new(0  , 0  , v.x, v.x);
        public static Vector4 To00XY(this Vector4 v) => new(0  , 0  , v.x, v.y);
        public static Vector4 To00XZ(this Vector4 v) => new(0  , 0  , v.x, v.z);
        public static Vector4 To00XW(this Vector4 v) => new(0  , 0  , v.x, v.w);
        
        public static Vector4 To00Y0(this Vector4 v) => new(0  , 0  , v.y, 0  );
        public static Vector4 To00YX(this Vector4 v) => new(0  , 0  , v.y, v.x);
        public static Vector4 To00YY(this Vector4 v) => new(0  , 0  , v.y, v.y);
        public static Vector4 To00YZ(this Vector4 v) => new(0  , 0  , v.y, v.z);
        public static Vector4 To00YW(this Vector4 v) => new(0  , 0  , v.y, v.w);
        
        public static Vector4 To00Z0(this Vector4 v) => new(0  , 0  , v.z, 0  );
        public static Vector4 To00ZX(this Vector4 v) => new(0  , 0  , v.z, v.x);
        public static Vector4 To00ZY(this Vector4 v) => new(0  , 0  , v.z, v.y);
        public static Vector4 To00ZZ(this Vector4 v) => new(0  , 0  , v.z, v.z);
        public static Vector4 To00ZW(this Vector4 v) => new(0  , 0  , v.z, v.w);
        
        public static Vector4 To00W0(this Vector4 v) => new(0  , 0  , v.w, 0  );
        public static Vector4 To00WX(this Vector4 v) => new(0  , 0  , v.w, v.x);
        public static Vector4 To00WY(this Vector4 v) => new(0  , 0  , v.w, v.y);
        public static Vector4 To00WZ(this Vector4 v) => new(0  , 0  , v.w, v.z);
        public static Vector4 To00WW(this Vector4 v) => new(0  , 0  , v.w, v.w);
        
        public static Vector4 To0X00(this Vector4 v) => new(0  , v.x, 0  , 0  );
        public static Vector4 To0X0X(this Vector4 v) => new(0  , v.x, 0  , v.x);
        public static Vector4 To0X0Y(this Vector4 v) => new(0  , v.x, 0  , v.y);
        public static Vector4 To0X0Z(this Vector4 v) => new(0  , v.x, 0  , v.z);
        public static Vector4 To0X0W(this Vector4 v) => new(0  , v.x, 0  , v.w);
        
        public static Vector4 To0XX0(this Vector4 v) => new(0  , v.x, v.x, 0  );
        public static Vector4 To0XXX(this Vector4 v) => new(0  , v.x, v.x, v.x);
        public static Vector4 To0XXY(this Vector4 v) => new(0  , v.x, v.x, v.y);
        public static Vector4 To0XXZ(this Vector4 v) => new(0  , v.x, v.x, v.z);
        public static Vector4 To0XXW(this Vector4 v) => new(0  , v.x, v.x, v.w);
        
        public static Vector4 To0XY0(this Vector4 v) => new(0  , v.x, v.y, 0  );
        public static Vector4 To0XYX(this Vector4 v) => new(0  , v.x, v.y, v.x);
        public static Vector4 To0XYY(this Vector4 v) => new(0  , v.x, v.y, v.y);
        public static Vector4 To0XYZ(this Vector4 v) => new(0  , v.x, v.y, v.z);
        public static Vector4 To0XYW(this Vector4 v) => new(0  , v.x, v.y, v.w);
        
        public static Vector4 To0XZ0(this Vector4 v) => new(0  , v.x, v.z, 0  );
        public static Vector4 To0XZX(this Vector4 v) => new(0  , v.x, v.z, v.x);
        public static Vector4 To0XZY(this Vector4 v) => new(0  , v.x, v.z, v.y);
        public static Vector4 To0XZZ(this Vector4 v) => new(0  , v.x, v.z, v.z);
        public static Vector4 To0XZW(this Vector4 v) => new(0  , v.x, v.z, v.w);
        
        public static Vector4 To0XW0(this Vector4 v) => new(0  , v.x, v.w, 0  );
        public static Vector4 To0XWX(this Vector4 v) => new(0  , v.x, v.w, v.x);
        public static Vector4 To0XWY(this Vector4 v) => new(0  , v.x, v.w, v.y);
        public static Vector4 To0XWZ(this Vector4 v) => new(0  , v.x, v.w, v.z);
        public static Vector4 To0XWW(this Vector4 v) => new(0  , v.x, v.w, v.w);
        
        public static Vector4 To0Y00(this Vector4 v) => new(0  , v.y, 0  , 0  );
        public static Vector4 To0Y0X(this Vector4 v) => new(0  , v.y, 0  , v.x);
        public static Vector4 To0Y0Y(this Vector4 v) => new(0  , v.y, 0  , v.y);
        public static Vector4 To0Y0Z(this Vector4 v) => new(0  , v.y, 0  , v.z);
        public static Vector4 To0Y0W(this Vector4 v) => new(0  , v.y, 0  , v.w);
        
        public static Vector4 To0YX0(this Vector4 v) => new(0  , v.y, v.x, 0  );
        public static Vector4 To0YXX(this Vector4 v) => new(0  , v.y, v.x, v.x);
        public static Vector4 To0YXY(this Vector4 v) => new(0  , v.y, v.x, v.y);
        public static Vector4 To0YXZ(this Vector4 v) => new(0  , v.y, v.x, v.z);
        public static Vector4 To0YXW(this Vector4 v) => new(0  , v.y, v.x, v.w);
        
        public static Vector4 To0YY0(this Vector4 v) => new(0  , v.y, v.y, 0  );
        public static Vector4 To0YYX(this Vector4 v) => new(0  , v.y, v.y, v.x);
        public static Vector4 To0YYY(this Vector4 v) => new(0  , v.y, v.y, v.y);
        public static Vector4 To0YYZ(this Vector4 v) => new(0  , v.y, v.y, v.z);
        public static Vector4 To0YYW(this Vector4 v) => new(0  , v.y, v.y, v.w);
        
        public static Vector4 To0YZ0(this Vector4 v) => new(0  , v.y, v.z, 0  );
        public static Vector4 To0YZX(this Vector4 v) => new(0  , v.y, v.z, v.x);
        public static Vector4 To0YZY(this Vector4 v) => new(0  , v.y, v.z, v.y);
        public static Vector4 To0YZZ(this Vector4 v) => new(0  , v.y, v.z, v.z);
        public static Vector4 To0YZW(this Vector4 v) => new(0  , v.y, v.z, v.w);
        
        public static Vector4 To0YW0(this Vector4 v) => new(0  , v.y, v.w, 0  );
        public static Vector4 To0YWX(this Vector4 v) => new(0  , v.y, v.w, v.x);
        public static Vector4 To0YWY(this Vector4 v) => new(0  , v.y, v.w, v.y);
        public static Vector4 To0YWZ(this Vector4 v) => new(0  , v.y, v.w, v.z);
        public static Vector4 To0YWW(this Vector4 v) => new(0  , v.y, v.w, v.w);
        
        public static Vector4 To0Z00(this Vector4 v) => new(0  , v.z, 0  , 0  );
        public static Vector4 To0Z0X(this Vector4 v) => new(0  , v.z, 0  , v.x);
        public static Vector4 To0Z0Y(this Vector4 v) => new(0  , v.z, 0  , v.y);
        public static Vector4 To0Z0Z(this Vector4 v) => new(0  , v.z, 0  , v.z);
        public static Vector4 To0Z0W(this Vector4 v) => new(0  , v.z, 0  , v.w);
        
        public static Vector4 To0ZX0(this Vector4 v) => new(0  , v.z, v.x, 0  );
        public static Vector4 To0ZXX(this Vector4 v) => new(0  , v.z, v.x, v.x);
        public static Vector4 To0ZXY(this Vector4 v) => new(0  , v.z, v.x, v.y);
        public static Vector4 To0ZXZ(this Vector4 v) => new(0  , v.z, v.x, v.z);
        public static Vector4 To0ZXW(this Vector4 v) => new(0  , v.z, v.x, v.w);
        
        public static Vector4 To0ZY0(this Vector4 v) => new(0  , v.z, v.y, 0  );
        public static Vector4 To0ZYX(this Vector4 v) => new(0  , v.z, v.y, v.x);
        public static Vector4 To0ZYY(this Vector4 v) => new(0  , v.z, v.y, v.y);
        public static Vector4 To0ZYZ(this Vector4 v) => new(0  , v.z, v.y, v.z);
        public static Vector4 To0ZYW(this Vector4 v) => new(0  , v.z, v.y, v.w);
        
        public static Vector4 To0ZZ0(this Vector4 v) => new(0  , v.z, v.z, 0  );
        public static Vector4 To0ZZX(this Vector4 v) => new(0  , v.z, v.z, v.x);
        public static Vector4 To0ZZY(this Vector4 v) => new(0  , v.z, v.z, v.y);
        public static Vector4 To0ZZZ(this Vector4 v) => new(0  , v.z, v.z, v.z);
        public static Vector4 To0ZZW(this Vector4 v) => new(0  , v.z, v.z, v.w);
        
        public static Vector4 To0ZW0(this Vector4 v) => new(0  , v.z, v.w, 0  );
        public static Vector4 To0ZWX(this Vector4 v) => new(0  , v.z, v.w, v.x);
        public static Vector4 To0ZWY(this Vector4 v) => new(0  , v.z, v.w, v.y);
        public static Vector4 To0ZWZ(this Vector4 v) => new(0  , v.z, v.w, v.z);
        public static Vector4 To0ZWW(this Vector4 v) => new(0  , v.z, v.w, v.w);
        
        public static Vector4 To0W00(this Vector4 v) => new(0  , v.w, 0  , 0  );
        public static Vector4 To0W0X(this Vector4 v) => new(0  , v.w, 0  , v.x);
        public static Vector4 To0W0Y(this Vector4 v) => new(0  , v.w, 0  , v.y);
        public static Vector4 To0W0Z(this Vector4 v) => new(0  , v.w, 0  , v.z);
        public static Vector4 To0W0W(this Vector4 v) => new(0  , v.w, 0  , v.w);
        
        public static Vector4 To0WX0(this Vector4 v) => new(0  , v.w, v.x, 0  );
        public static Vector4 To0WXX(this Vector4 v) => new(0  , v.w, v.x, v.x);
        public static Vector4 To0WXY(this Vector4 v) => new(0  , v.w, v.x, v.y);
        public static Vector4 To0WXZ(this Vector4 v) => new(0  , v.w, v.x, v.z);
        public static Vector4 To0WXW(this Vector4 v) => new(0  , v.w, v.x, v.w);
        
        public static Vector4 To0WY0(this Vector4 v) => new(0  , v.w, v.y, 0  );
        public static Vector4 To0WYX(this Vector4 v) => new(0  , v.w, v.y, v.x);
        public static Vector4 To0WYY(this Vector4 v) => new(0  , v.w, v.y, v.y);
        public static Vector4 To0WYZ(this Vector4 v) => new(0  , v.w, v.y, v.z);
        public static Vector4 To0WYW(this Vector4 v) => new(0  , v.w, v.y, v.w);
        
        public static Vector4 To0WZ0(this Vector4 v) => new(0  , v.w, v.z, 0  );
        public static Vector4 To0WZX(this Vector4 v) => new(0  , v.w, v.z, v.x);
        public static Vector4 To0WZY(this Vector4 v) => new(0  , v.w, v.z, v.y);
        public static Vector4 To0WZZ(this Vector4 v) => new(0  , v.w, v.z, v.z);
        public static Vector4 To0WZW(this Vector4 v) => new(0  , v.w, v.z, v.w);
        
        public static Vector4 To0WW0(this Vector4 v) => new(0  , v.w, v.w, 0  );
        public static Vector4 To0WWX(this Vector4 v) => new(0  , v.w, v.w, v.x);
        public static Vector4 To0WWY(this Vector4 v) => new(0  , v.w, v.w, v.y);
        public static Vector4 To0WWZ(this Vector4 v) => new(0  , v.w, v.w, v.z);
        public static Vector4 To0WWW(this Vector4 v) => new(0  , v.w, v.w, v.w);
        
        public static Vector4 ToX000(this Vector4 v) => new(v.x, 0  , 0  , 0  );
        public static Vector4 ToX00X(this Vector4 v) => new(v.x, 0  , 0  , v.x);
        public static Vector4 ToX00Y(this Vector4 v) => new(v.x, 0  , 0  , v.y);
        public static Vector4 ToX00Z(this Vector4 v) => new(v.x, 0  , 0  , v.z);
        public static Vector4 ToX00W(this Vector4 v) => new(v.x, 0  , 0  , v.w);
        
        public static Vector4 ToX0X0(this Vector4 v) => new(v.x, 0  , v.x, 0  );
        public static Vector4 ToX0XX(this Vector4 v) => new(v.x, 0  , v.x, v.x);
        public static Vector4 ToX0XY(this Vector4 v) => new(v.x, 0  , v.x, v.y);
        public static Vector4 ToX0XZ(this Vector4 v) => new(v.x, 0  , v.x, v.z);
        public static Vector4 ToX0XW(this Vector4 v) => new(v.x, 0  , v.x, v.w);
        
        public static Vector4 ToX0Y0(this Vector4 v) => new(v.x, 0  , v.y, 0  );
        public static Vector4 ToX0YX(this Vector4 v) => new(v.x, 0  , v.y, v.x);
        public static Vector4 ToX0YY(this Vector4 v) => new(v.x, 0  , v.y, v.y);
        public static Vector4 ToX0YZ(this Vector4 v) => new(v.x, 0  , v.y, v.z);
        public static Vector4 ToX0YW(this Vector4 v) => new(v.x, 0  , v.y, v.w);
        
        public static Vector4 ToX0Z0(this Vector4 v) => new(v.x, 0  , v.z, 0  );
        public static Vector4 ToX0ZX(this Vector4 v) => new(v.x, 0  , v.z, v.x);
        public static Vector4 ToX0ZY(this Vector4 v) => new(v.x, 0  , v.z, v.y);
        public static Vector4 ToX0ZZ(this Vector4 v) => new(v.x, 0  , v.z, v.z);
        public static Vector4 ToX0ZW(this Vector4 v) => new(v.x, 0  , v.z, v.w);
        
        public static Vector4 ToX0W0(this Vector4 v) => new(v.x, 0  , v.w, 0  );
        public static Vector4 ToX0WX(this Vector4 v) => new(v.x, 0  , v.w, v.x);
        public static Vector4 ToX0WY(this Vector4 v) => new(v.x, 0  , v.w, v.y);
        public static Vector4 ToX0WZ(this Vector4 v) => new(v.x, 0  , v.w, v.z);
        public static Vector4 ToX0WW(this Vector4 v) => new(v.x, 0  , v.w, v.w);
        
        public static Vector4 ToXX00(this Vector4 v) => new(v.x, v.x, 0  , 0  );
        public static Vector4 ToXX0X(this Vector4 v) => new(v.x, v.x, 0  , v.x);
        public static Vector4 ToXX0Y(this Vector4 v) => new(v.x, v.x, 0  , v.y);
        public static Vector4 ToXX0Z(this Vector4 v) => new(v.x, v.x, 0  , v.z);
        public static Vector4 ToXX0W(this Vector4 v) => new(v.x, v.x, 0  , v.w);
        
        public static Vector4 ToXXX0(this Vector4 v) => new(v.x, v.x, v.x, 0  );
        public static Vector4 ToXXXX(this Vector4 v) => new(v.x, v.x, v.x, v.x);
        public static Vector4 ToXXXY(this Vector4 v) => new(v.x, v.x, v.x, v.y);
        public static Vector4 ToXXXZ(this Vector4 v) => new(v.x, v.x, v.x, v.z);
        public static Vector4 ToXXXW(this Vector4 v) => new(v.x, v.x, v.x, v.w);
        
        public static Vector4 ToXXY0(this Vector4 v) => new(v.x, v.x, v.y, 0  );
        public static Vector4 ToXXYX(this Vector4 v) => new(v.x, v.x, v.y, v.x);
        public static Vector4 ToXXYY(this Vector4 v) => new(v.x, v.x, v.y, v.y);
        public static Vector4 ToXXYZ(this Vector4 v) => new(v.x, v.x, v.y, v.z);
        public static Vector4 ToXXYW(this Vector4 v) => new(v.x, v.x, v.y, v.w);
        
        public static Vector4 ToXXZ0(this Vector4 v) => new(v.x, v.x, v.z, 0  );
        public static Vector4 ToXXZX(this Vector4 v) => new(v.x, v.x, v.z, v.x);
        public static Vector4 ToXXZY(this Vector4 v) => new(v.x, v.x, v.z, v.y);
        public static Vector4 ToXXZZ(this Vector4 v) => new(v.x, v.x, v.z, v.z);
        public static Vector4 ToXXZW(this Vector4 v) => new(v.x, v.x, v.z, v.w);
        
        public static Vector4 ToXXW0(this Vector4 v) => new(v.x, v.x, v.w, 0  );
        public static Vector4 ToXXWX(this Vector4 v) => new(v.x, v.x, v.w, v.x);
        public static Vector4 ToXXWY(this Vector4 v) => new(v.x, v.x, v.w, v.y);
        public static Vector4 ToXXWZ(this Vector4 v) => new(v.x, v.x, v.w, v.z);
        public static Vector4 ToXXWW(this Vector4 v) => new(v.x, v.x, v.w, v.w);
        
        public static Vector4 ToXY00(this Vector4 v) => new(v.x, v.y, 0  , 0  );
        public static Vector4 ToXY0X(this Vector4 v) => new(v.x, v.y, 0  , v.x);
        public static Vector4 ToXY0Y(this Vector4 v) => new(v.x, v.y, 0  , v.y);
        public static Vector4 ToXY0Z(this Vector4 v) => new(v.x, v.y, 0  , v.z);
        public static Vector4 ToXY0W(this Vector4 v) => new(v.x, v.y, 0  , v.w);
        
        public static Vector4 ToXYX0(this Vector4 v) => new(v.x, v.y, v.x, 0  );
        public static Vector4 ToXYXX(this Vector4 v) => new(v.x, v.y, v.x, v.x);
        public static Vector4 ToXYXY(this Vector4 v) => new(v.x, v.y, v.x, v.y);
        public static Vector4 ToXYXZ(this Vector4 v) => new(v.x, v.y, v.x, v.z);
        public static Vector4 ToXYXW(this Vector4 v) => new(v.x, v.y, v.x, v.w);
        
        public static Vector4 ToXYY0(this Vector4 v) => new(v.x, v.y, v.y, 0  );
        public static Vector4 ToXYYX(this Vector4 v) => new(v.x, v.y, v.y, v.x);
        public static Vector4 ToXYYY(this Vector4 v) => new(v.x, v.y, v.y, v.y);
        public static Vector4 ToXYYZ(this Vector4 v) => new(v.x, v.y, v.y, v.z);
        public static Vector4 ToXYYW(this Vector4 v) => new(v.x, v.y, v.y, v.w);
        
        public static Vector4 ToXYZ0(this Vector4 v) => new(v.x, v.y, v.z, 0  );
        public static Vector4 ToXYZX(this Vector4 v) => new(v.x, v.y, v.z, v.x);
        public static Vector4 ToXYZY(this Vector4 v) => new(v.x, v.y, v.z, v.y);
        public static Vector4 ToXYZZ(this Vector4 v) => new(v.x, v.y, v.z, v.z);
        public static Vector4 ToXYZW(this Vector4 v) => new(v.x, v.y, v.z, v.w);
        
        public static Vector4 ToXYW0(this Vector4 v) => new(v.x, v.y, v.w, 0  );
        public static Vector4 ToXYWX(this Vector4 v) => new(v.x, v.y, v.w, v.x);
        public static Vector4 ToXYWY(this Vector4 v) => new(v.x, v.y, v.w, v.y);
        public static Vector4 ToXYWZ(this Vector4 v) => new(v.x, v.y, v.w, v.z);
        public static Vector4 ToXYWW(this Vector4 v) => new(v.x, v.y, v.w, v.w);
        
        public static Vector4 ToXZ00(this Vector4 v) => new(v.x, v.z, 0  , 0  );
        public static Vector4 ToXZ0X(this Vector4 v) => new(v.x, v.z, 0  , v.x);
        public static Vector4 ToXZ0Y(this Vector4 v) => new(v.x, v.z, 0  , v.y);
        public static Vector4 ToXZ0Z(this Vector4 v) => new(v.x, v.z, 0  , v.z);
        public static Vector4 ToXZ0W(this Vector4 v) => new(v.x, v.z, 0  , v.w);
        
        public static Vector4 ToXZX0(this Vector4 v) => new(v.x, v.z, v.x, 0  );
        public static Vector4 ToXZXX(this Vector4 v) => new(v.x, v.z, v.x, v.x);
        public static Vector4 ToXZXY(this Vector4 v) => new(v.x, v.z, v.x, v.y);
        public static Vector4 ToXZXZ(this Vector4 v) => new(v.x, v.z, v.x, v.z);
        public static Vector4 ToXZXW(this Vector4 v) => new(v.x, v.z, v.x, v.w);
        
        public static Vector4 ToXZY0(this Vector4 v) => new(v.x, v.z, v.y, 0  );
        public static Vector4 ToXZYX(this Vector4 v) => new(v.x, v.z, v.y, v.x);
        public static Vector4 ToXZYY(this Vector4 v) => new(v.x, v.z, v.y, v.y);
        public static Vector4 ToXZYZ(this Vector4 v) => new(v.x, v.z, v.y, v.z);
        public static Vector4 ToXZYW(this Vector4 v) => new(v.x, v.z, v.y, v.w);
        
        public static Vector4 ToXZZ0(this Vector4 v) => new(v.x, v.z, v.z, 0  );
        public static Vector4 ToXZZX(this Vector4 v) => new(v.x, v.z, v.z, v.x);
        public static Vector4 ToXZZY(this Vector4 v) => new(v.x, v.z, v.z, v.y);
        public static Vector4 ToXZZZ(this Vector4 v) => new(v.x, v.z, v.z, v.z);
        public static Vector4 ToXZZW(this Vector4 v) => new(v.x, v.z, v.z, v.w);
        
        public static Vector4 ToXZW0(this Vector4 v) => new(v.x, v.z, v.w, 0  );
        public static Vector4 ToXZWX(this Vector4 v) => new(v.x, v.z, v.w, v.x);
        public static Vector4 ToXZWY(this Vector4 v) => new(v.x, v.z, v.w, v.y);
        public static Vector4 ToXZWZ(this Vector4 v) => new(v.x, v.z, v.w, v.z);
        public static Vector4 ToXZWW(this Vector4 v) => new(v.x, v.z, v.w, v.w);
        
        public static Vector4 ToXW00(this Vector4 v) => new(v.x, v.w, 0  , 0  );
        public static Vector4 ToXW0X(this Vector4 v) => new(v.x, v.w, 0  , v.x);
        public static Vector4 ToXW0Y(this Vector4 v) => new(v.x, v.w, 0  , v.y);
        public static Vector4 ToXW0Z(this Vector4 v) => new(v.x, v.w, 0  , v.z);
        public static Vector4 ToXW0W(this Vector4 v) => new(v.x, v.w, 0  , v.w);
        
        public static Vector4 ToXWX0(this Vector4 v) => new(v.x, v.w, v.x, 0  );
        public static Vector4 ToXWXX(this Vector4 v) => new(v.x, v.w, v.x, v.x);
        public static Vector4 ToXWXY(this Vector4 v) => new(v.x, v.w, v.x, v.y);
        public static Vector4 ToXWXZ(this Vector4 v) => new(v.x, v.w, v.x, v.z);
        public static Vector4 ToXWXW(this Vector4 v) => new(v.x, v.w, v.x, v.w);
        
        public static Vector4 ToXWY0(this Vector4 v) => new(v.x, v.w, v.y, 0  );
        public static Vector4 ToXWYX(this Vector4 v) => new(v.x, v.w, v.y, v.x);
        public static Vector4 ToXWYY(this Vector4 v) => new(v.x, v.w, v.y, v.y);
        public static Vector4 ToXWYZ(this Vector4 v) => new(v.x, v.w, v.y, v.z);
        public static Vector4 ToXWYW(this Vector4 v) => new(v.x, v.w, v.y, v.w);
        
        public static Vector4 ToXWZ0(this Vector4 v) => new(v.x, v.w, v.z, 0  );
        public static Vector4 ToXWZX(this Vector4 v) => new(v.x, v.w, v.z, v.x);
        public static Vector4 ToXWZY(this Vector4 v) => new(v.x, v.w, v.z, v.y);
        public static Vector4 ToXWZZ(this Vector4 v) => new(v.x, v.w, v.z, v.z);
        public static Vector4 ToXWZW(this Vector4 v) => new(v.x, v.w, v.z, v.w);
        
        public static Vector4 ToXWW0(this Vector4 v) => new(v.x, v.w, v.w, 0  );
        public static Vector4 ToXWWX(this Vector4 v) => new(v.x, v.w, v.w, v.x);
        public static Vector4 ToXWWY(this Vector4 v) => new(v.x, v.w, v.w, v.y);
        public static Vector4 ToXWWZ(this Vector4 v) => new(v.x, v.w, v.w, v.z);
        public static Vector4 ToXWWW(this Vector4 v) => new(v.x, v.w, v.w, v.w);
        
        public static Vector4 ToY000(this Vector4 v) => new(v.y, 0  , 0  , 0  );
        public static Vector4 ToY00X(this Vector4 v) => new(v.y, 0  , 0  , v.x);
        public static Vector4 ToY00Y(this Vector4 v) => new(v.y, 0  , 0  , v.y);
        public static Vector4 ToY00Z(this Vector4 v) => new(v.y, 0  , 0  , v.z);
        public static Vector4 ToY00W(this Vector4 v) => new(v.y, 0  , 0  , v.w);
        
        public static Vector4 ToY0X0(this Vector4 v) => new(v.y, 0  , v.x, 0  );
        public static Vector4 ToY0XX(this Vector4 v) => new(v.y, 0  , v.x, v.x);
        public static Vector4 ToY0XY(this Vector4 v) => new(v.y, 0  , v.x, v.y);
        public static Vector4 ToY0XZ(this Vector4 v) => new(v.y, 0  , v.x, v.z);
        public static Vector4 ToY0XW(this Vector4 v) => new(v.y, 0  , v.x, v.w);
        
        public static Vector4 ToY0Y0(this Vector4 v) => new(v.y, 0  , v.y, 0  );
        public static Vector4 ToY0YX(this Vector4 v) => new(v.y, 0  , v.y, v.x);
        public static Vector4 ToY0YY(this Vector4 v) => new(v.y, 0  , v.y, v.y);
        public static Vector4 ToY0YZ(this Vector4 v) => new(v.y, 0  , v.y, v.z);
        public static Vector4 ToY0YW(this Vector4 v) => new(v.y, 0  , v.y, v.w);
        
        public static Vector4 ToY0Z0(this Vector4 v) => new(v.y, 0  , v.z, 0  );
        public static Vector4 ToY0ZX(this Vector4 v) => new(v.y, 0  , v.z, v.x);
        public static Vector4 ToY0ZY(this Vector4 v) => new(v.y, 0  , v.z, v.y);
        public static Vector4 ToY0ZZ(this Vector4 v) => new(v.y, 0  , v.z, v.z);
        public static Vector4 ToY0ZW(this Vector4 v) => new(v.y, 0  , v.z, v.w);
        
        public static Vector4 ToY0W0(this Vector4 v) => new(v.y, 0  , v.w, 0  );
        public static Vector4 ToY0WX(this Vector4 v) => new(v.y, 0  , v.w, v.x);
        public static Vector4 ToY0WY(this Vector4 v) => new(v.y, 0  , v.w, v.y);
        public static Vector4 ToY0WZ(this Vector4 v) => new(v.y, 0  , v.w, v.z);
        public static Vector4 ToY0WW(this Vector4 v) => new(v.y, 0  , v.w, v.w);
        
        public static Vector4 ToYX00(this Vector4 v) => new(v.y, v.x, 0  , 0  );
        public static Vector4 ToYX0X(this Vector4 v) => new(v.y, v.x, 0  , v.x);
        public static Vector4 ToYX0Y(this Vector4 v) => new(v.y, v.x, 0  , v.y);
        public static Vector4 ToYX0Z(this Vector4 v) => new(v.y, v.x, 0  , v.z);
        public static Vector4 ToYX0W(this Vector4 v) => new(v.y, v.x, 0  , v.w);
        
        public static Vector4 ToYXX0(this Vector4 v) => new(v.y, v.x, v.x, 0  );
        public static Vector4 ToYXXX(this Vector4 v) => new(v.y, v.x, v.x, v.x);
        public static Vector4 ToYXXY(this Vector4 v) => new(v.y, v.x, v.x, v.y);
        public static Vector4 ToYXXZ(this Vector4 v) => new(v.y, v.x, v.x, v.z);
        public static Vector4 ToYXXW(this Vector4 v) => new(v.y, v.x, v.x, v.w);
        
        public static Vector4 ToYXY0(this Vector4 v) => new(v.y, v.x, v.y, 0  );
        public static Vector4 ToYXYX(this Vector4 v) => new(v.y, v.x, v.y, v.x);
        public static Vector4 ToYXYY(this Vector4 v) => new(v.y, v.x, v.y, v.y);
        public static Vector4 ToYXYZ(this Vector4 v) => new(v.y, v.x, v.y, v.z);
        public static Vector4 ToYXYW(this Vector4 v) => new(v.y, v.x, v.y, v.w);
        
        public static Vector4 ToYXZ0(this Vector4 v) => new(v.y, v.x, v.z, 0  );
        public static Vector4 ToYXZX(this Vector4 v) => new(v.y, v.x, v.z, v.x);
        public static Vector4 ToYXZY(this Vector4 v) => new(v.y, v.x, v.z, v.y);
        public static Vector4 ToYXZZ(this Vector4 v) => new(v.y, v.x, v.z, v.z);
        public static Vector4 ToYXZW(this Vector4 v) => new(v.y, v.x, v.z, v.w);
        
        public static Vector4 ToYXW0(this Vector4 v) => new(v.y, v.x, v.w, 0  );
        public static Vector4 ToYXWX(this Vector4 v) => new(v.y, v.x, v.w, v.x);
        public static Vector4 ToYXWY(this Vector4 v) => new(v.y, v.x, v.w, v.y);
        public static Vector4 ToYXWZ(this Vector4 v) => new(v.y, v.x, v.w, v.z);
        public static Vector4 ToYXWW(this Vector4 v) => new(v.y, v.x, v.w, v.w);
        
        public static Vector4 ToYY00(this Vector4 v) => new(v.y, v.y, 0  , 0  );
        public static Vector4 ToYY0X(this Vector4 v) => new(v.y, v.y, 0  , v.x);
        public static Vector4 ToYY0Y(this Vector4 v) => new(v.y, v.y, 0  , v.y);
        public static Vector4 ToYY0Z(this Vector4 v) => new(v.y, v.y, 0  , v.z);
        public static Vector4 ToYY0W(this Vector4 v) => new(v.y, v.y, 0  , v.w);
        
        public static Vector4 ToYYX0(this Vector4 v) => new(v.y, v.y, v.x, 0  );
        public static Vector4 ToYYXX(this Vector4 v) => new(v.y, v.y, v.x, v.x);
        public static Vector4 ToYYXY(this Vector4 v) => new(v.y, v.y, v.x, v.y);
        public static Vector4 ToYYXZ(this Vector4 v) => new(v.y, v.y, v.x, v.z);
        public static Vector4 ToYYXW(this Vector4 v) => new(v.y, v.y, v.x, v.w);
        
        public static Vector4 ToYYY0(this Vector4 v) => new(v.y, v.y, v.y, 0  );
        public static Vector4 ToYYYX(this Vector4 v) => new(v.y, v.y, v.y, v.x);
        public static Vector4 ToYYYY(this Vector4 v) => new(v.y, v.y, v.y, v.y);
        public static Vector4 ToYYYZ(this Vector4 v) => new(v.y, v.y, v.y, v.z);
        public static Vector4 ToYYYW(this Vector4 v) => new(v.y, v.y, v.y, v.w);
        
        public static Vector4 ToYYZ0(this Vector4 v) => new(v.y, v.y, v.z, 0  );
        public static Vector4 ToYYZX(this Vector4 v) => new(v.y, v.y, v.z, v.x);
        public static Vector4 ToYYZY(this Vector4 v) => new(v.y, v.y, v.z, v.y);
        public static Vector4 ToYYZZ(this Vector4 v) => new(v.y, v.y, v.z, v.z);
        public static Vector4 ToYYZW(this Vector4 v) => new(v.y, v.y, v.z, v.w);
        
        public static Vector4 ToYYW0(this Vector4 v) => new(v.y, v.y, v.w, 0  );
        public static Vector4 ToYYWX(this Vector4 v) => new(v.y, v.y, v.w, v.x);
        public static Vector4 ToYYWY(this Vector4 v) => new(v.y, v.y, v.w, v.y);
        public static Vector4 ToYYWZ(this Vector4 v) => new(v.y, v.y, v.w, v.z);
        public static Vector4 ToYYWW(this Vector4 v) => new(v.y, v.y, v.w, v.w);
        
        public static Vector4 ToYZ00(this Vector4 v) => new(v.y, v.z, 0  , 0  );
        public static Vector4 ToYZ0X(this Vector4 v) => new(v.y, v.z, 0  , v.x);
        public static Vector4 ToYZ0Y(this Vector4 v) => new(v.y, v.z, 0  , v.y);
        public static Vector4 ToYZ0Z(this Vector4 v) => new(v.y, v.z, 0  , v.z);
        public static Vector4 ToYZ0W(this Vector4 v) => new(v.y, v.z, 0  , v.w);
        
        public static Vector4 ToYZX0(this Vector4 v) => new(v.y, v.z, v.x, 0  );
        public static Vector4 ToYZXX(this Vector4 v) => new(v.y, v.z, v.x, v.x);
        public static Vector4 ToYZXY(this Vector4 v) => new(v.y, v.z, v.x, v.y);
        public static Vector4 ToYZXZ(this Vector4 v) => new(v.y, v.z, v.x, v.z);
        public static Vector4 ToYZXW(this Vector4 v) => new(v.y, v.z, v.x, v.w);
        
        public static Vector4 ToYZY0(this Vector4 v) => new(v.y, v.z, v.y, 0  );
        public static Vector4 ToYZYX(this Vector4 v) => new(v.y, v.z, v.y, v.x);
        public static Vector4 ToYZYY(this Vector4 v) => new(v.y, v.z, v.y, v.y);
        public static Vector4 ToYZYZ(this Vector4 v) => new(v.y, v.z, v.y, v.z);
        public static Vector4 ToYZYW(this Vector4 v) => new(v.y, v.z, v.y, v.w);
        
        public static Vector4 ToYZZ0(this Vector4 v) => new(v.y, v.z, v.z, 0  );
        public static Vector4 ToYZZX(this Vector4 v) => new(v.y, v.z, v.z, v.x);
        public static Vector4 ToYZZY(this Vector4 v) => new(v.y, v.z, v.z, v.y);
        public static Vector4 ToYZZZ(this Vector4 v) => new(v.y, v.z, v.z, v.z);
        public static Vector4 ToYZZW(this Vector4 v) => new(v.y, v.z, v.z, v.w);
        
        public static Vector4 ToYZW0(this Vector4 v) => new(v.y, v.z, v.w, 0  );
        public static Vector4 ToYZWX(this Vector4 v) => new(v.y, v.z, v.w, v.x);
        public static Vector4 ToYZWY(this Vector4 v) => new(v.y, v.z, v.w, v.y);
        public static Vector4 ToYZWZ(this Vector4 v) => new(v.y, v.z, v.w, v.z);
        public static Vector4 ToYZWW(this Vector4 v) => new(v.y, v.z, v.w, v.w);
        
        public static Vector4 ToYW00(this Vector4 v) => new(v.y, v.w, 0  , 0  );
        public static Vector4 ToYW0X(this Vector4 v) => new(v.y, v.w, 0  , v.x);
        public static Vector4 ToYW0Y(this Vector4 v) => new(v.y, v.w, 0  , v.y);
        public static Vector4 ToYW0Z(this Vector4 v) => new(v.y, v.w, 0  , v.z);
        public static Vector4 ToYW0W(this Vector4 v) => new(v.y, v.w, 0  , v.w);
        
        public static Vector4 ToYWX0(this Vector4 v) => new(v.y, v.w, v.x, 0  );
        public static Vector4 ToYWXX(this Vector4 v) => new(v.y, v.w, v.x, v.x);
        public static Vector4 ToYWXY(this Vector4 v) => new(v.y, v.w, v.x, v.y);
        public static Vector4 ToYWXZ(this Vector4 v) => new(v.y, v.w, v.x, v.z);
        public static Vector4 ToYWXW(this Vector4 v) => new(v.y, v.w, v.x, v.w);
        
        public static Vector4 ToYWY0(this Vector4 v) => new(v.y, v.w, v.y, 0  );
        public static Vector4 ToYWYX(this Vector4 v) => new(v.y, v.w, v.y, v.x);
        public static Vector4 ToYWYY(this Vector4 v) => new(v.y, v.w, v.y, v.y);
        public static Vector4 ToYWYZ(this Vector4 v) => new(v.y, v.w, v.y, v.z);
        public static Vector4 ToYWYW(this Vector4 v) => new(v.y, v.w, v.y, v.w);
        
        public static Vector4 ToYWZ0(this Vector4 v) => new(v.y, v.w, v.z, 0  );
        public static Vector4 ToYWZX(this Vector4 v) => new(v.y, v.w, v.z, v.x);
        public static Vector4 ToYWZY(this Vector4 v) => new(v.y, v.w, v.z, v.y);
        public static Vector4 ToYWZZ(this Vector4 v) => new(v.y, v.w, v.z, v.z);
        public static Vector4 ToYWZW(this Vector4 v) => new(v.y, v.w, v.z, v.w);
        
        public static Vector4 ToYWW0(this Vector4 v) => new(v.y, v.w, v.w, 0  );
        public static Vector4 ToYWWX(this Vector4 v) => new(v.y, v.w, v.w, v.x);
        public static Vector4 ToYWWY(this Vector4 v) => new(v.y, v.w, v.w, v.y);
        public static Vector4 ToYWWZ(this Vector4 v) => new(v.y, v.w, v.w, v.z);
        public static Vector4 ToYWWW(this Vector4 v) => new(v.y, v.w, v.w, v.w);
        
        public static Vector4 ToZ000(this Vector4 v) => new(v.z, 0  , 0  , 0  );
        public static Vector4 ToZ00X(this Vector4 v) => new(v.z, 0  , 0  , v.x);
        public static Vector4 ToZ00Y(this Vector4 v) => new(v.z, 0  , 0  , v.y);
        public static Vector4 ToZ00Z(this Vector4 v) => new(v.z, 0  , 0  , v.z);
        public static Vector4 ToZ00W(this Vector4 v) => new(v.z, 0  , 0  , v.w);
        
        public static Vector4 ToZ0X0(this Vector4 v) => new(v.z, 0  , v.x, 0  );
        public static Vector4 ToZ0XX(this Vector4 v) => new(v.z, 0  , v.x, v.x);
        public static Vector4 ToZ0XY(this Vector4 v) => new(v.z, 0  , v.x, v.y);
        public static Vector4 ToZ0XZ(this Vector4 v) => new(v.z, 0  , v.x, v.z);
        public static Vector4 ToZ0XW(this Vector4 v) => new(v.z, 0  , v.x, v.w);
        
        public static Vector4 ToZ0Y0(this Vector4 v) => new(v.z, 0  , v.y, 0  );
        public static Vector4 ToZ0YX(this Vector4 v) => new(v.z, 0  , v.y, v.x);
        public static Vector4 ToZ0YY(this Vector4 v) => new(v.z, 0  , v.y, v.y);
        public static Vector4 ToZ0YZ(this Vector4 v) => new(v.z, 0  , v.y, v.z);
        public static Vector4 ToZ0YW(this Vector4 v) => new(v.z, 0  , v.y, v.w);
        
        public static Vector4 ToZ0Z0(this Vector4 v) => new(v.z, 0  , v.z, 0  );
        public static Vector4 ToZ0ZX(this Vector4 v) => new(v.z, 0  , v.z, v.x);
        public static Vector4 ToZ0ZY(this Vector4 v) => new(v.z, 0  , v.z, v.y);
        public static Vector4 ToZ0ZZ(this Vector4 v) => new(v.z, 0  , v.z, v.z);
        public static Vector4 ToZ0ZW(this Vector4 v) => new(v.z, 0  , v.z, v.w);
        
        public static Vector4 ToZ0W0(this Vector4 v) => new(v.z, 0  , v.w, 0  );
        public static Vector4 ToZ0WX(this Vector4 v) => new(v.z, 0  , v.w, v.x);
        public static Vector4 ToZ0WY(this Vector4 v) => new(v.z, 0  , v.w, v.y);
        public static Vector4 ToZ0WZ(this Vector4 v) => new(v.z, 0  , v.w, v.z);
        public static Vector4 ToZ0WW(this Vector4 v) => new(v.z, 0  , v.w, v.w);
        
        public static Vector4 ToZX00(this Vector4 v) => new(v.z, v.x, 0  , 0  );
        public static Vector4 ToZX0X(this Vector4 v) => new(v.z, v.x, 0  , v.x);
        public static Vector4 ToZX0Y(this Vector4 v) => new(v.z, v.x, 0  , v.y);
        public static Vector4 ToZX0Z(this Vector4 v) => new(v.z, v.x, 0  , v.z);
        public static Vector4 ToZX0W(this Vector4 v) => new(v.z, v.x, 0  , v.w);
        
        public static Vector4 ToZXX0(this Vector4 v) => new(v.z, v.x, v.x, 0  );
        public static Vector4 ToZXXX(this Vector4 v) => new(v.z, v.x, v.x, v.x);
        public static Vector4 ToZXXY(this Vector4 v) => new(v.z, v.x, v.x, v.y);
        public static Vector4 ToZXXZ(this Vector4 v) => new(v.z, v.x, v.x, v.z);
        public static Vector4 ToZXXW(this Vector4 v) => new(v.z, v.x, v.x, v.w);
        
        public static Vector4 ToZXY0(this Vector4 v) => new(v.z, v.x, v.y, 0  );
        public static Vector4 ToZXYX(this Vector4 v) => new(v.z, v.x, v.y, v.x);
        public static Vector4 ToZXYY(this Vector4 v) => new(v.z, v.x, v.y, v.y);
        public static Vector4 ToZXYZ(this Vector4 v) => new(v.z, v.x, v.y, v.z);
        public static Vector4 ToZXYW(this Vector4 v) => new(v.z, v.x, v.y, v.w);
        
        public static Vector4 ToZXZ0(this Vector4 v) => new(v.z, v.x, v.z, 0  );
        public static Vector4 ToZXZX(this Vector4 v) => new(v.z, v.x, v.z, v.x);
        public static Vector4 ToZXZY(this Vector4 v) => new(v.z, v.x, v.z, v.y);
        public static Vector4 ToZXZZ(this Vector4 v) => new(v.z, v.x, v.z, v.z);
        public static Vector4 ToZXZW(this Vector4 v) => new(v.z, v.x, v.z, v.w);
        
        public static Vector4 ToZXW0(this Vector4 v) => new(v.z, v.x, v.w, 0  );
        public static Vector4 ToZXWX(this Vector4 v) => new(v.z, v.x, v.w, v.x);
        public static Vector4 ToZXWY(this Vector4 v) => new(v.z, v.x, v.w, v.y);
        public static Vector4 ToZXWZ(this Vector4 v) => new(v.z, v.x, v.w, v.z);
        public static Vector4 ToZXWW(this Vector4 v) => new(v.z, v.x, v.w, v.w);
        
        public static Vector4 ToZY00(this Vector4 v) => new(v.z, v.y, 0  , 0  );
        public static Vector4 ToZY0X(this Vector4 v) => new(v.z, v.y, 0  , v.x);
        public static Vector4 ToZY0Y(this Vector4 v) => new(v.z, v.y, 0  , v.y);
        public static Vector4 ToZY0Z(this Vector4 v) => new(v.z, v.y, 0  , v.z);
        public static Vector4 ToZY0W(this Vector4 v) => new(v.z, v.y, 0  , v.w);
        
        public static Vector4 ToZYX0(this Vector4 v) => new(v.z, v.y, v.x, 0  );
        public static Vector4 ToZYXX(this Vector4 v) => new(v.z, v.y, v.x, v.x);
        public static Vector4 ToZYXY(this Vector4 v) => new(v.z, v.y, v.x, v.y);
        public static Vector4 ToZYXZ(this Vector4 v) => new(v.z, v.y, v.x, v.z);
        public static Vector4 ToZYXW(this Vector4 v) => new(v.z, v.y, v.x, v.w);
        
        public static Vector4 ToZYY0(this Vector4 v) => new(v.z, v.y, v.y, 0  );
        public static Vector4 ToZYYX(this Vector4 v) => new(v.z, v.y, v.y, v.x);
        public static Vector4 ToZYYY(this Vector4 v) => new(v.z, v.y, v.y, v.y);
        public static Vector4 ToZYYZ(this Vector4 v) => new(v.z, v.y, v.y, v.z);
        public static Vector4 ToZYYW(this Vector4 v) => new(v.z, v.y, v.y, v.w);
        
        public static Vector4 ToZYZ0(this Vector4 v) => new(v.z, v.y, v.z, 0  );
        public static Vector4 ToZYZX(this Vector4 v) => new(v.z, v.y, v.z, v.x);
        public static Vector4 ToZYZY(this Vector4 v) => new(v.z, v.y, v.z, v.y);
        public static Vector4 ToZYZZ(this Vector4 v) => new(v.z, v.y, v.z, v.z);
        public static Vector4 ToZYZW(this Vector4 v) => new(v.z, v.y, v.z, v.w);
        
        public static Vector4 ToZYW0(this Vector4 v) => new(v.z, v.y, v.w, 0  );
        public static Vector4 ToZYWX(this Vector4 v) => new(v.z, v.y, v.w, v.x);
        public static Vector4 ToZYWY(this Vector4 v) => new(v.z, v.y, v.w, v.y);
        public static Vector4 ToZYWZ(this Vector4 v) => new(v.z, v.y, v.w, v.z);
        public static Vector4 ToZYWW(this Vector4 v) => new(v.z, v.y, v.w, v.w);
        
        public static Vector4 ToZZ00(this Vector4 v) => new(v.z, v.z, 0  , 0  );
        public static Vector4 ToZZ0X(this Vector4 v) => new(v.z, v.z, 0  , v.x);
        public static Vector4 ToZZ0Y(this Vector4 v) => new(v.z, v.z, 0  , v.y);
        public static Vector4 ToZZ0Z(this Vector4 v) => new(v.z, v.z, 0  , v.z);
        public static Vector4 ToZZ0W(this Vector4 v) => new(v.z, v.z, 0  , v.w);
        
        public static Vector4 ToZZX0(this Vector4 v) => new(v.z, v.z, v.x, 0  );
        public static Vector4 ToZZXX(this Vector4 v) => new(v.z, v.z, v.x, v.x);
        public static Vector4 ToZZXY(this Vector4 v) => new(v.z, v.z, v.x, v.y);
        public static Vector4 ToZZXZ(this Vector4 v) => new(v.z, v.z, v.x, v.z);
        public static Vector4 ToZZXW(this Vector4 v) => new(v.z, v.z, v.x, v.w);
        
        public static Vector4 ToZZY0(this Vector4 v) => new(v.z, v.z, v.y, 0  );
        public static Vector4 ToZZYX(this Vector4 v) => new(v.z, v.z, v.y, v.x);
        public static Vector4 ToZZYY(this Vector4 v) => new(v.z, v.z, v.y, v.y);
        public static Vector4 ToZZYZ(this Vector4 v) => new(v.z, v.z, v.y, v.z);
        public static Vector4 ToZZYW(this Vector4 v) => new(v.z, v.z, v.y, v.w);
        
        public static Vector4 ToZZZ0(this Vector4 v) => new(v.z, v.z, v.z, 0  );
        public static Vector4 ToZZZX(this Vector4 v) => new(v.z, v.z, v.z, v.x);
        public static Vector4 ToZZZY(this Vector4 v) => new(v.z, v.z, v.z, v.y);
        public static Vector4 ToZZZZ(this Vector4 v) => new(v.z, v.z, v.z, v.z);
        public static Vector4 ToZZZW(this Vector4 v) => new(v.z, v.z, v.z, v.w);
        
        public static Vector4 ToZZW0(this Vector4 v) => new(v.z, v.z, v.w, 0  );
        public static Vector4 ToZZWX(this Vector4 v) => new(v.z, v.z, v.w, v.x);
        public static Vector4 ToZZWY(this Vector4 v) => new(v.z, v.z, v.w, v.y);
        public static Vector4 ToZZWZ(this Vector4 v) => new(v.z, v.z, v.w, v.z);
        public static Vector4 ToZZWW(this Vector4 v) => new(v.z, v.z, v.w, v.w);
        
        public static Vector4 ToZW00(this Vector4 v) => new(v.z, v.w, 0  , 0  );
        public static Vector4 ToZW0X(this Vector4 v) => new(v.z, v.w, 0  , v.x);
        public static Vector4 ToZW0Y(this Vector4 v) => new(v.z, v.w, 0  , v.y);
        public static Vector4 ToZW0Z(this Vector4 v) => new(v.z, v.w, 0  , v.z);
        public static Vector4 ToZW0W(this Vector4 v) => new(v.z, v.w, 0  , v.w);
        
        public static Vector4 ToZWX0(this Vector4 v) => new(v.z, v.w, v.x, 0  );
        public static Vector4 ToZWXX(this Vector4 v) => new(v.z, v.w, v.x, v.x);
        public static Vector4 ToZWXY(this Vector4 v) => new(v.z, v.w, v.x, v.y);
        public static Vector4 ToZWXZ(this Vector4 v) => new(v.z, v.w, v.x, v.z);
        public static Vector4 ToZWXW(this Vector4 v) => new(v.z, v.w, v.x, v.w);
        
        public static Vector4 ToZWY0(this Vector4 v) => new(v.z, v.w, v.y, 0  );
        public static Vector4 ToZWYX(this Vector4 v) => new(v.z, v.w, v.y, v.x);
        public static Vector4 ToZWYY(this Vector4 v) => new(v.z, v.w, v.y, v.y);
        public static Vector4 ToZWYZ(this Vector4 v) => new(v.z, v.w, v.y, v.z);
        public static Vector4 ToZWYW(this Vector4 v) => new(v.z, v.w, v.y, v.w);
        
        public static Vector4 ToZWZ0(this Vector4 v) => new(v.z, v.w, v.z, 0  );
        public static Vector4 ToZWZX(this Vector4 v) => new(v.z, v.w, v.z, v.x);
        public static Vector4 ToZWZY(this Vector4 v) => new(v.z, v.w, v.z, v.y);
        public static Vector4 ToZWZZ(this Vector4 v) => new(v.z, v.w, v.z, v.z);
        public static Vector4 ToZWZW(this Vector4 v) => new(v.z, v.w, v.z, v.w);
        
        public static Vector4 ToZWW0(this Vector4 v) => new(v.z, v.w, v.w, 0  );
        public static Vector4 ToZWWX(this Vector4 v) => new(v.z, v.w, v.w, v.x);
        public static Vector4 ToZWWY(this Vector4 v) => new(v.z, v.w, v.w, v.y);
        public static Vector4 ToZWWZ(this Vector4 v) => new(v.z, v.w, v.w, v.z);
        public static Vector4 ToZWWW(this Vector4 v) => new(v.z, v.w, v.w, v.w);
        
        public static Vector4 ToW000(this Vector4 v) => new(v.w, 0  , 0  , 0  );
        public static Vector4 ToW00X(this Vector4 v) => new(v.w, 0  , 0  , v.x);
        public static Vector4 ToW00Y(this Vector4 v) => new(v.w, 0  , 0  , v.y);
        public static Vector4 ToW00Z(this Vector4 v) => new(v.w, 0  , 0  , v.z);
        public static Vector4 ToW00W(this Vector4 v) => new(v.w, 0  , 0  , v.w);
        
        public static Vector4 ToW0X0(this Vector4 v) => new(v.w, 0  , v.x, 0  );
        public static Vector4 ToW0XX(this Vector4 v) => new(v.w, 0  , v.x, v.x);
        public static Vector4 ToW0XY(this Vector4 v) => new(v.w, 0  , v.x, v.y);
        public static Vector4 ToW0XZ(this Vector4 v) => new(v.w, 0  , v.x, v.z);
        public static Vector4 ToW0XW(this Vector4 v) => new(v.w, 0  , v.x, v.w);
        
        public static Vector4 ToW0Y0(this Vector4 v) => new(v.w, 0  , v.y, 0  );
        public static Vector4 ToW0YX(this Vector4 v) => new(v.w, 0  , v.y, v.x);
        public static Vector4 ToW0YY(this Vector4 v) => new(v.w, 0  , v.y, v.y);
        public static Vector4 ToW0YZ(this Vector4 v) => new(v.w, 0  , v.y, v.z);
        public static Vector4 ToW0YW(this Vector4 v) => new(v.w, 0  , v.y, v.w);
        
        public static Vector4 ToW0Z0(this Vector4 v) => new(v.w, 0  , v.z, 0  );
        public static Vector4 ToW0ZX(this Vector4 v) => new(v.w, 0  , v.z, v.x);
        public static Vector4 ToW0ZY(this Vector4 v) => new(v.w, 0  , v.z, v.y);
        public static Vector4 ToW0ZZ(this Vector4 v) => new(v.w, 0  , v.z, v.z);
        public static Vector4 ToW0ZW(this Vector4 v) => new(v.w, 0  , v.z, v.w);
        
        public static Vector4 ToW0W0(this Vector4 v) => new(v.w, 0  , v.w, 0  );
        public static Vector4 ToW0WX(this Vector4 v) => new(v.w, 0  , v.w, v.x);
        public static Vector4 ToW0WY(this Vector4 v) => new(v.w, 0  , v.w, v.y);
        public static Vector4 ToW0WZ(this Vector4 v) => new(v.w, 0  , v.w, v.z);
        public static Vector4 ToW0WW(this Vector4 v) => new(v.w, 0  , v.w, v.w);
        
        public static Vector4 ToWX00(this Vector4 v) => new(v.w, v.x, 0  , 0  );
        public static Vector4 ToWX0X(this Vector4 v) => new(v.w, v.x, 0  , v.x);
        public static Vector4 ToWX0Y(this Vector4 v) => new(v.w, v.x, 0  , v.y);
        public static Vector4 ToWX0Z(this Vector4 v) => new(v.w, v.x, 0  , v.z);
        public static Vector4 ToWX0W(this Vector4 v) => new(v.w, v.x, 0  , v.w);
        
        public static Vector4 ToWXX0(this Vector4 v) => new(v.w, v.x, v.x, 0  );
        public static Vector4 ToWXXX(this Vector4 v) => new(v.w, v.x, v.x, v.x);
        public static Vector4 ToWXXY(this Vector4 v) => new(v.w, v.x, v.x, v.y);
        public static Vector4 ToWXXZ(this Vector4 v) => new(v.w, v.x, v.x, v.z);
        public static Vector4 ToWXXW(this Vector4 v) => new(v.w, v.x, v.x, v.w);
        
        public static Vector4 ToWXY0(this Vector4 v) => new(v.w, v.x, v.y, 0  );
        public static Vector4 ToWXYX(this Vector4 v) => new(v.w, v.x, v.y, v.x);
        public static Vector4 ToWXYY(this Vector4 v) => new(v.w, v.x, v.y, v.y);
        public static Vector4 ToWXYZ(this Vector4 v) => new(v.w, v.x, v.y, v.z);
        public static Vector4 ToWXYW(this Vector4 v) => new(v.w, v.x, v.y, v.w);
        
        public static Vector4 ToWXZ0(this Vector4 v) => new(v.w, v.x, v.z, 0  );
        public static Vector4 ToWXZX(this Vector4 v) => new(v.w, v.x, v.z, v.x);
        public static Vector4 ToWXZY(this Vector4 v) => new(v.w, v.x, v.z, v.y);
        public static Vector4 ToWXZZ(this Vector4 v) => new(v.w, v.x, v.z, v.z);
        public static Vector4 ToWXZW(this Vector4 v) => new(v.w, v.x, v.z, v.w);
        
        public static Vector4 ToWXW0(this Vector4 v) => new(v.w, v.x, v.w, 0  );
        public static Vector4 ToWXWX(this Vector4 v) => new(v.w, v.x, v.w, v.x);
        public static Vector4 ToWXWY(this Vector4 v) => new(v.w, v.x, v.w, v.y);
        public static Vector4 ToWXWZ(this Vector4 v) => new(v.w, v.x, v.w, v.z);
        public static Vector4 ToWXWW(this Vector4 v) => new(v.w, v.x, v.w, v.w);
        
        public static Vector4 ToWY00(this Vector4 v) => new(v.w, v.y, 0  , 0  );
        public static Vector4 ToWY0X(this Vector4 v) => new(v.w, v.y, 0  , v.x);
        public static Vector4 ToWY0Y(this Vector4 v) => new(v.w, v.y, 0  , v.y);
        public static Vector4 ToWY0Z(this Vector4 v) => new(v.w, v.y, 0  , v.z);
        public static Vector4 ToWY0W(this Vector4 v) => new(v.w, v.y, 0  , v.w);
        
        public static Vector4 ToWYX0(this Vector4 v) => new(v.w, v.y, v.x, 0  );
        public static Vector4 ToWYXX(this Vector4 v) => new(v.w, v.y, v.x, v.x);
        public static Vector4 ToWYXY(this Vector4 v) => new(v.w, v.y, v.x, v.y);
        public static Vector4 ToWYXZ(this Vector4 v) => new(v.w, v.y, v.x, v.z);
        public static Vector4 ToWYXW(this Vector4 v) => new(v.w, v.y, v.x, v.w);
        
        public static Vector4 ToWYY0(this Vector4 v) => new(v.w, v.y, v.y, 0  );
        public static Vector4 ToWYYX(this Vector4 v) => new(v.w, v.y, v.y, v.x);
        public static Vector4 ToWYYY(this Vector4 v) => new(v.w, v.y, v.y, v.y);
        public static Vector4 ToWYYZ(this Vector4 v) => new(v.w, v.y, v.y, v.z);
        public static Vector4 ToWYYW(this Vector4 v) => new(v.w, v.y, v.y, v.w);
        
        public static Vector4 ToWYZ0(this Vector4 v) => new(v.w, v.y, v.z, 0  );
        public static Vector4 ToWYZX(this Vector4 v) => new(v.w, v.y, v.z, v.x);
        public static Vector4 ToWYZY(this Vector4 v) => new(v.w, v.y, v.z, v.y);
        public static Vector4 ToWYZZ(this Vector4 v) => new(v.w, v.y, v.z, v.z);
        public static Vector4 ToWYZW(this Vector4 v) => new(v.w, v.y, v.z, v.w);
        
        public static Vector4 ToWYW0(this Vector4 v) => new(v.w, v.y, v.w, 0  );
        public static Vector4 ToWYWX(this Vector4 v) => new(v.w, v.y, v.w, v.x);
        public static Vector4 ToWYWY(this Vector4 v) => new(v.w, v.y, v.w, v.y);
        public static Vector4 ToWYWZ(this Vector4 v) => new(v.w, v.y, v.w, v.z);
        public static Vector4 ToWYWW(this Vector4 v) => new(v.w, v.y, v.w, v.w);
        
        public static Vector4 ToWZ00(this Vector4 v) => new(v.w, v.z, 0  , 0  );
        public static Vector4 ToWZ0X(this Vector4 v) => new(v.w, v.z, 0  , v.x);
        public static Vector4 ToWZ0Y(this Vector4 v) => new(v.w, v.z, 0  , v.y);
        public static Vector4 ToWZ0Z(this Vector4 v) => new(v.w, v.z, 0  , v.z);
        public static Vector4 ToWZ0W(this Vector4 v) => new(v.w, v.z, 0  , v.w);
        
        public static Vector4 ToWZX0(this Vector4 v) => new(v.w, v.z, v.x, 0  );
        public static Vector4 ToWZXX(this Vector4 v) => new(v.w, v.z, v.x, v.x);
        public static Vector4 ToWZXY(this Vector4 v) => new(v.w, v.z, v.x, v.y);
        public static Vector4 ToWZXZ(this Vector4 v) => new(v.w, v.z, v.x, v.z);
        public static Vector4 ToWZXW(this Vector4 v) => new(v.w, v.z, v.x, v.w);
        
        public static Vector4 ToWZY0(this Vector4 v) => new(v.w, v.z, v.y, 0  );
        public static Vector4 ToWZYX(this Vector4 v) => new(v.w, v.z, v.y, v.x);
        public static Vector4 ToWZYY(this Vector4 v) => new(v.w, v.z, v.y, v.y);
        public static Vector4 ToWZYZ(this Vector4 v) => new(v.w, v.z, v.y, v.z);
        public static Vector4 ToWZYW(this Vector4 v) => new(v.w, v.z, v.y, v.w);
        
        public static Vector4 ToWZZ0(this Vector4 v) => new(v.w, v.z, v.z, 0  );
        public static Vector4 ToWZZX(this Vector4 v) => new(v.w, v.z, v.z, v.x);
        public static Vector4 ToWZZY(this Vector4 v) => new(v.w, v.z, v.z, v.y);
        public static Vector4 ToWZZZ(this Vector4 v) => new(v.w, v.z, v.z, v.z);
        public static Vector4 ToWZZW(this Vector4 v) => new(v.w, v.z, v.z, v.w);
        
        public static Vector4 ToWZW0(this Vector4 v) => new(v.w, v.z, v.w, 0  );
        public static Vector4 ToWZWX(this Vector4 v) => new(v.w, v.z, v.w, v.x);
        public static Vector4 ToWZWY(this Vector4 v) => new(v.w, v.z, v.w, v.y);
        public static Vector4 ToWZWZ(this Vector4 v) => new(v.w, v.z, v.w, v.z);
        public static Vector4 ToWZWW(this Vector4 v) => new(v.w, v.z, v.w, v.w);
        
        public static Vector4 ToWW00(this Vector4 v) => new(v.w, v.w, 0  , 0  );
        public static Vector4 ToWW0X(this Vector4 v) => new(v.w, v.w, 0  , v.x);
        public static Vector4 ToWW0Y(this Vector4 v) => new(v.w, v.w, 0  , v.y);
        public static Vector4 ToWW0Z(this Vector4 v) => new(v.w, v.w, 0  , v.z);
        public static Vector4 ToWW0W(this Vector4 v) => new(v.w, v.w, 0  , v.w);
        
        public static Vector4 ToWWX0(this Vector4 v) => new(v.w, v.w, v.x, 0  );
        public static Vector4 ToWWXX(this Vector4 v) => new(v.w, v.w, v.x, v.x);
        public static Vector4 ToWWXY(this Vector4 v) => new(v.w, v.w, v.x, v.y);
        public static Vector4 ToWWXZ(this Vector4 v) => new(v.w, v.w, v.x, v.z);
        public static Vector4 ToWWXW(this Vector4 v) => new(v.w, v.w, v.x, v.w);
        
        public static Vector4 ToWWY0(this Vector4 v) => new(v.w, v.w, v.y, 0  );
        public static Vector4 ToWWYX(this Vector4 v) => new(v.w, v.w, v.y, v.x);
        public static Vector4 ToWWYY(this Vector4 v) => new(v.w, v.w, v.y, v.y);
        public static Vector4 ToWWYZ(this Vector4 v) => new(v.w, v.w, v.y, v.z);
        public static Vector4 ToWWYW(this Vector4 v) => new(v.w, v.w, v.y, v.w);
        
        public static Vector4 ToWWZ0(this Vector4 v) => new(v.w, v.w, v.z, 0  );
        public static Vector4 ToWWZX(this Vector4 v) => new(v.w, v.w, v.z, v.x);
        public static Vector4 ToWWZY(this Vector4 v) => new(v.w, v.w, v.z, v.y);
        public static Vector4 ToWWZZ(this Vector4 v) => new(v.w, v.w, v.z, v.z);
        public static Vector4 ToWWZW(this Vector4 v) => new(v.w, v.w, v.z, v.w);
        
        public static Vector4 ToWWW0(this Vector4 v) => new(v.w, v.w, v.w, 0  );
        public static Vector4 ToWWWX(this Vector4 v) => new(v.w, v.w, v.w, v.x);
        public static Vector4 ToWWWY(this Vector4 v) => new(v.w, v.w, v.w, v.y);
        public static Vector4 ToWWWZ(this Vector4 v) => new(v.w, v.w, v.w, v.z);
        public static Vector4 ToWWWW(this Vector4 v) => new(v.w, v.w, v.w, v.w);
    }
}
