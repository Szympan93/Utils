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
        
        public static Vector3 To000(this Vector3 v) => new(0  , 0  , 0  );
        public static Vector3 To00X(this Vector3 v) => new(0  , 0  , v.x);
        public static Vector3 To00Y(this Vector3 v) => new(0  , 0  , v.y);
        public static Vector3 To00Z(this Vector3 v) => new(0  , 0  , v.z);
        
        public static Vector3 To0X0(this Vector3 v) => new(0  , v.x, 0  );
        public static Vector3 To0XX(this Vector3 v) => new(0  , v.x, v.x);
        public static Vector3 To0XY(this Vector3 v) => new(0  , v.x, v.y);
        public static Vector3 To0XZ(this Vector3 v) => new(0  , v.x, v.z);
        
        public static Vector3 To0Y0(this Vector3 v) => new(0  , v.y, 0  );
        public static Vector3 To0YX(this Vector3 v) => new(0  , v.y, v.x);
        public static Vector3 To0YY(this Vector3 v) => new(0  , v.y, v.y);
        public static Vector3 To0YZ(this Vector3 v) => new(0  , v.y, v.z);
        
        public static Vector3 To0Z0(this Vector3 v) => new(0  , v.z, 0  );
        public static Vector3 To0ZX(this Vector3 v) => new(0  , v.z, v.x);
        public static Vector3 To0ZY(this Vector3 v) => new(0  , v.z, v.y);
        public static Vector3 To0ZZ(this Vector3 v) => new(0  , v.z, v.z);
        
        public static Vector3 ToX00(this Vector3 v) => new(v.x, 0  , 0  );
        public static Vector3 ToX0X(this Vector3 v) => new(v.x, 0  , v.x);
        public static Vector3 ToX0Y(this Vector3 v) => new(v.x, 0  , v.y);
        public static Vector3 ToX0Z(this Vector3 v) => new(v.x, 0  , v.z);
        
        public static Vector3 ToXX0(this Vector3 v) => new(v.x, v.x, 0  );
        public static Vector3 ToXXX(this Vector3 v) => new(v.x, v.x, v.x);
        public static Vector3 ToXXY(this Vector3 v) => new(v.x, v.x, v.y);
        public static Vector3 ToXXZ(this Vector3 v) => new(v.x, v.x, v.z);
        
        public static Vector3 ToXY0(this Vector3 v) => new(v.x, v.y, 0  );
        public static Vector3 ToXYX(this Vector3 v) => new(v.x, v.y, v.x);
        public static Vector3 ToXYY(this Vector3 v) => new(v.x, v.y, v.y);
        public static Vector3 ToXYZ(this Vector3 v) => new(v.x, v.y, v.z);
        
        public static Vector3 ToXZ0(this Vector3 v) => new(v.x, v.z, 0  );
        public static Vector3 ToXZX(this Vector3 v) => new(v.x, v.z, v.x);
        public static Vector3 ToXZY(this Vector3 v) => new(v.x, v.z, v.y);
        public static Vector3 ToXZZ(this Vector3 v) => new(v.x, v.z, v.z);
        
        public static Vector3 ToY00(this Vector3 v) => new(v.y, 0  , 0  );
        public static Vector3 ToY0X(this Vector3 v) => new(v.y, 0  , v.x);
        public static Vector3 ToY0Y(this Vector3 v) => new(v.y, 0  , v.y);
        public static Vector3 ToY0Z(this Vector3 v) => new(v.y, 0  , v.z);
        
        public static Vector3 ToYX0(this Vector3 v) => new(v.y, v.x, 0  );
        public static Vector3 ToYXX(this Vector3 v) => new(v.y, v.x, v.x);
        public static Vector3 ToYXY(this Vector3 v) => new(v.y, v.x, v.y);
        public static Vector3 ToYXZ(this Vector3 v) => new(v.y, v.x, v.z);
        
        public static Vector3 ToYY0(this Vector3 v) => new(v.y, v.y, 0  );
        public static Vector3 ToYYX(this Vector3 v) => new(v.y, v.y, v.x);
        public static Vector3 ToYYY(this Vector3 v) => new(v.y, v.y, v.y);
        public static Vector3 ToYYZ(this Vector3 v) => new(v.y, v.y, v.z);
        
        public static Vector3 ToYZ0(this Vector3 v) => new(v.y, v.z, 0  );
        public static Vector3 ToYZX(this Vector3 v) => new(v.y, v.z, v.x);
        public static Vector3 ToYZY(this Vector3 v) => new(v.y, v.z, v.y);
        public static Vector3 ToYZZ(this Vector3 v) => new(v.y, v.z, v.z);
        
        public static Vector3 ToZ00(this Vector3 v) => new(v.z, 0  , 0  );
        public static Vector3 ToZ0X(this Vector3 v) => new(v.z, 0  , v.x);
        public static Vector3 ToZ0Y(this Vector3 v) => new(v.z, 0  , v.y);
        public static Vector3 ToZ0Z(this Vector3 v) => new(v.z, 0  , v.z);
        
        public static Vector3 ToZX0(this Vector3 v) => new(v.z, v.x, 0  );
        public static Vector3 ToZXX(this Vector3 v) => new(v.z, v.x, v.x);
        public static Vector3 ToZXY(this Vector3 v) => new(v.z, v.x, v.y);
        public static Vector3 ToZXZ(this Vector3 v) => new(v.z, v.x, v.z);
        
        public static Vector3 ToZY0(this Vector3 v) => new(v.z, v.y, 0  );
        public static Vector3 ToZYX(this Vector3 v) => new(v.z, v.y, v.x);
        public static Vector3 ToZYY(this Vector3 v) => new(v.z, v.y, v.y);
        public static Vector3 ToZYZ(this Vector3 v) => new(v.z, v.y, v.z);
        
        public static Vector3 ToZZ0(this Vector3 v) => new(v.z, v.z, 0  );
        public static Vector3 ToZZX(this Vector3 v) => new(v.z, v.z, v.x);
        public static Vector3 ToZZY(this Vector3 v) => new(v.z, v.z, v.y);
        public static Vector3 ToZZZ(this Vector3 v) => new(v.z, v.z, v.z);
    }
}
