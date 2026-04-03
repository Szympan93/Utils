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
        
        public static Vector4 To0000(this Vector3 v) => new(0  , 0  , 0  , 0  );
        public static Vector4 To000X(this Vector3 v) => new(0  , 0  , 0  , v.x);
        public static Vector4 To000Y(this Vector3 v) => new(0  , 0  , 0  , v.y);
        public static Vector4 To000Z(this Vector3 v) => new(0  , 0  , 0  , v.z);
        
        public static Vector4 To00X0(this Vector3 v) => new(0  , 0  , v.x, 0  );
        public static Vector4 To00XX(this Vector3 v) => new(0  , 0  , v.x, v.x);
        public static Vector4 To00XY(this Vector3 v) => new(0  , 0  , v.x, v.y);
        public static Vector4 To00XZ(this Vector3 v) => new(0  , 0  , v.x, v.z);
        
        public static Vector4 To00Y0(this Vector3 v) => new(0  , 0  , v.y, 0  );
        public static Vector4 To00YX(this Vector3 v) => new(0  , 0  , v.y, v.x);
        public static Vector4 To00YY(this Vector3 v) => new(0  , 0  , v.y, v.y);
        public static Vector4 To00YZ(this Vector3 v) => new(0  , 0  , v.y, v.z);
        
        public static Vector4 To00Z0(this Vector3 v) => new(0  , 0  , v.z, 0  );
        public static Vector4 To00ZX(this Vector3 v) => new(0  , 0  , v.z, v.x);
        public static Vector4 To00ZY(this Vector3 v) => new(0  , 0  , v.z, v.y);
        public static Vector4 To00ZZ(this Vector3 v) => new(0  , 0  , v.z, v.z);
        
        public static Vector4 To0X00(this Vector3 v) => new(0  , v.x, 0  , 0  );
        public static Vector4 To0X0X(this Vector3 v) => new(0  , v.x, 0  , v.x);
        public static Vector4 To0X0Y(this Vector3 v) => new(0  , v.x, 0  , v.y);
        public static Vector4 To0X0Z(this Vector3 v) => new(0  , v.x, 0  , v.z);
        
        public static Vector4 To0XX0(this Vector3 v) => new(0  , v.x, v.x, 0  );
        public static Vector4 To0XXX(this Vector3 v) => new(0  , v.x, v.x, v.x);
        public static Vector4 To0XXY(this Vector3 v) => new(0  , v.x, v.x, v.y);
        public static Vector4 To0XXZ(this Vector3 v) => new(0  , v.x, v.x, v.z);
        
        public static Vector4 To0XY0(this Vector3 v) => new(0  , v.x, v.y, 0  );
        public static Vector4 To0XYX(this Vector3 v) => new(0  , v.x, v.y, v.x);
        public static Vector4 To0XYY(this Vector3 v) => new(0  , v.x, v.y, v.y);
        public static Vector4 To0XYZ(this Vector3 v) => new(0  , v.x, v.y, v.z);
        
        public static Vector4 To0XZ0(this Vector3 v) => new(0  , v.x, v.z, 0  );
        public static Vector4 To0XZX(this Vector3 v) => new(0  , v.x, v.z, v.x);
        public static Vector4 To0XZY(this Vector3 v) => new(0  , v.x, v.z, v.y);
        public static Vector4 To0XZZ(this Vector3 v) => new(0  , v.x, v.z, v.z);
        
        public static Vector4 To0Y00(this Vector3 v) => new(0  , v.y, 0  , 0  );
        public static Vector4 To0Y0X(this Vector3 v) => new(0  , v.y, 0  , v.x);
        public static Vector4 To0Y0Y(this Vector3 v) => new(0  , v.y, 0  , v.y);
        public static Vector4 To0Y0Z(this Vector3 v) => new(0  , v.y, 0  , v.z);
        
        public static Vector4 To0YX0(this Vector3 v) => new(0  , v.y, v.x, 0  );
        public static Vector4 To0YXX(this Vector3 v) => new(0  , v.y, v.x, v.x);
        public static Vector4 To0YXY(this Vector3 v) => new(0  , v.y, v.x, v.y);
        public static Vector4 To0YXZ(this Vector3 v) => new(0  , v.y, v.x, v.z);
        
        public static Vector4 To0YY0(this Vector3 v) => new(0  , v.y, v.y, 0  );
        public static Vector4 To0YYX(this Vector3 v) => new(0  , v.y, v.y, v.x);
        public static Vector4 To0YYY(this Vector3 v) => new(0  , v.y, v.y, v.y);
        public static Vector4 To0YYZ(this Vector3 v) => new(0  , v.y, v.y, v.z);
        
        public static Vector4 To0YZ0(this Vector3 v) => new(0  , v.y, v.z, 0  );
        public static Vector4 To0YZX(this Vector3 v) => new(0  , v.y, v.z, v.x);
        public static Vector4 To0YZY(this Vector3 v) => new(0  , v.y, v.z, v.y);
        public static Vector4 To0YZZ(this Vector3 v) => new(0  , v.y, v.z, v.z);
        
        public static Vector4 To0Z00(this Vector3 v) => new(0  , v.z, 0  , 0  );
        public static Vector4 To0Z0X(this Vector3 v) => new(0  , v.z, 0  , v.x);
        public static Vector4 To0Z0Y(this Vector3 v) => new(0  , v.z, 0  , v.y);
        public static Vector4 To0Z0Z(this Vector3 v) => new(0  , v.z, 0  , v.z);
        
        public static Vector4 To0ZX0(this Vector3 v) => new(0  , v.z, v.x, 0  );
        public static Vector4 To0ZXX(this Vector3 v) => new(0  , v.z, v.x, v.x);
        public static Vector4 To0ZXY(this Vector3 v) => new(0  , v.z, v.x, v.y);
        public static Vector4 To0ZXZ(this Vector3 v) => new(0  , v.z, v.x, v.z);
        
        public static Vector4 To0ZY0(this Vector3 v) => new(0  , v.z, v.y, 0  );
        public static Vector4 To0ZYX(this Vector3 v) => new(0  , v.z, v.y, v.x);
        public static Vector4 To0ZYY(this Vector3 v) => new(0  , v.z, v.y, v.y);
        public static Vector4 To0ZYZ(this Vector3 v) => new(0  , v.z, v.y, v.z);
        
        public static Vector4 To0ZZ0(this Vector3 v) => new(0  , v.z, v.z, 0  );
        public static Vector4 To0ZZX(this Vector3 v) => new(0  , v.z, v.z, v.x);
        public static Vector4 To0ZZY(this Vector3 v) => new(0  , v.z, v.z, v.y);
        public static Vector4 To0ZZZ(this Vector3 v) => new(0  , v.z, v.z, v.z);
        
        public static Vector4 ToX000(this Vector3 v) => new(v.x, 0  , 0  , 0  );
        public static Vector4 ToX00X(this Vector3 v) => new(v.x, 0  , 0  , v.x);
        public static Vector4 ToX00Y(this Vector3 v) => new(v.x, 0  , 0  , v.y);
        public static Vector4 ToX00Z(this Vector3 v) => new(v.x, 0  , 0  , v.z);
        
        public static Vector4 ToX0X0(this Vector3 v) => new(v.x, 0  , v.x, 0  );
        public static Vector4 ToX0XX(this Vector3 v) => new(v.x, 0  , v.x, v.x);
        public static Vector4 ToX0XY(this Vector3 v) => new(v.x, 0  , v.x, v.y);
        public static Vector4 ToX0XZ(this Vector3 v) => new(v.x, 0  , v.x, v.z);
        
        public static Vector4 ToX0Y0(this Vector3 v) => new(v.x, 0  , v.y, 0  );
        public static Vector4 ToX0YX(this Vector3 v) => new(v.x, 0  , v.y, v.x);
        public static Vector4 ToX0YY(this Vector3 v) => new(v.x, 0  , v.y, v.y);
        public static Vector4 ToX0YZ(this Vector3 v) => new(v.x, 0  , v.y, v.z);
        
        public static Vector4 ToX0Z0(this Vector3 v) => new(v.x, 0  , v.z, 0  );
        public static Vector4 ToX0ZX(this Vector3 v) => new(v.x, 0  , v.z, v.x);
        public static Vector4 ToX0ZY(this Vector3 v) => new(v.x, 0  , v.z, v.y);
        public static Vector4 ToX0ZZ(this Vector3 v) => new(v.x, 0  , v.z, v.z);
        
        public static Vector4 ToXX00(this Vector3 v) => new(v.x, v.x, 0  , 0  );
        public static Vector4 ToXX0X(this Vector3 v) => new(v.x, v.x, 0  , v.x);
        public static Vector4 ToXX0Y(this Vector3 v) => new(v.x, v.x, 0  , v.y);
        public static Vector4 ToXX0Z(this Vector3 v) => new(v.x, v.x, 0  , v.z);
        
        public static Vector4 ToXXX0(this Vector3 v) => new(v.x, v.x, v.x, 0  );
        public static Vector4 ToXXXX(this Vector3 v) => new(v.x, v.x, v.x, v.x);
        public static Vector4 ToXXXY(this Vector3 v) => new(v.x, v.x, v.x, v.y);
        public static Vector4 ToXXXZ(this Vector3 v) => new(v.x, v.x, v.x, v.z);
        
        public static Vector4 ToXXY0(this Vector3 v) => new(v.x, v.x, v.y, 0  );
        public static Vector4 ToXXYX(this Vector3 v) => new(v.x, v.x, v.y, v.x);
        public static Vector4 ToXXYY(this Vector3 v) => new(v.x, v.x, v.y, v.y);
        public static Vector4 ToXXYZ(this Vector3 v) => new(v.x, v.x, v.y, v.z);
        
        public static Vector4 ToXXZ0(this Vector3 v) => new(v.x, v.x, v.z, 0  );
        public static Vector4 ToXXZX(this Vector3 v) => new(v.x, v.x, v.z, v.x);
        public static Vector4 ToXXZY(this Vector3 v) => new(v.x, v.x, v.z, v.y);
        public static Vector4 ToXXZZ(this Vector3 v) => new(v.x, v.x, v.z, v.z);
        
        public static Vector4 ToXY00(this Vector3 v) => new(v.x, v.y, 0  , 0  );
        public static Vector4 ToXY0X(this Vector3 v) => new(v.x, v.y, 0  , v.x);
        public static Vector4 ToXY0Y(this Vector3 v) => new(v.x, v.y, 0  , v.y);
        public static Vector4 ToXY0Z(this Vector3 v) => new(v.x, v.y, 0  , v.z);
        
        public static Vector4 ToXYX0(this Vector3 v) => new(v.x, v.y, v.x, 0  );
        public static Vector4 ToXYXX(this Vector3 v) => new(v.x, v.y, v.x, v.x);
        public static Vector4 ToXYXY(this Vector3 v) => new(v.x, v.y, v.x, v.y);
        public static Vector4 ToXYXZ(this Vector3 v) => new(v.x, v.y, v.x, v.z);
        
        public static Vector4 ToXYY0(this Vector3 v) => new(v.x, v.y, v.y, 0  );
        public static Vector4 ToXYYX(this Vector3 v) => new(v.x, v.y, v.y, v.x);
        public static Vector4 ToXYYY(this Vector3 v) => new(v.x, v.y, v.y, v.y);
        public static Vector4 ToXYYZ(this Vector3 v) => new(v.x, v.y, v.y, v.z);
        
        public static Vector4 ToXYZ0(this Vector3 v) => new(v.x, v.y, v.z, 0  );
        public static Vector4 ToXYZX(this Vector3 v) => new(v.x, v.y, v.z, v.x);
        public static Vector4 ToXYZY(this Vector3 v) => new(v.x, v.y, v.z, v.y);
        public static Vector4 ToXYZZ(this Vector3 v) => new(v.x, v.y, v.z, v.z);
        
        public static Vector4 ToXZ00(this Vector3 v) => new(v.x, v.z, 0  , 0  );
        public static Vector4 ToXZ0X(this Vector3 v) => new(v.x, v.z, 0  , v.x);
        public static Vector4 ToXZ0Y(this Vector3 v) => new(v.x, v.z, 0  , v.y);
        public static Vector4 ToXZ0Z(this Vector3 v) => new(v.x, v.z, 0  , v.z);
        
        public static Vector4 ToXZX0(this Vector3 v) => new(v.x, v.z, v.x, 0  );
        public static Vector4 ToXZXX(this Vector3 v) => new(v.x, v.z, v.x, v.x);
        public static Vector4 ToXZXY(this Vector3 v) => new(v.x, v.z, v.x, v.y);
        public static Vector4 ToXZXZ(this Vector3 v) => new(v.x, v.z, v.x, v.z);
        
        public static Vector4 ToXZY0(this Vector3 v) => new(v.x, v.z, v.y, 0  );
        public static Vector4 ToXZYX(this Vector3 v) => new(v.x, v.z, v.y, v.x);
        public static Vector4 ToXZYY(this Vector3 v) => new(v.x, v.z, v.y, v.y);
        public static Vector4 ToXZYZ(this Vector3 v) => new(v.x, v.z, v.y, v.z);
        
        public static Vector4 ToXZZ0(this Vector3 v) => new(v.x, v.z, v.z, 0  );
        public static Vector4 ToXZZX(this Vector3 v) => new(v.x, v.z, v.z, v.x);
        public static Vector4 ToXZZY(this Vector3 v) => new(v.x, v.z, v.z, v.y);
        public static Vector4 ToXZZZ(this Vector3 v) => new(v.x, v.z, v.z, v.z);
        
        public static Vector4 ToY000(this Vector3 v) => new(v.y, 0  , 0  , 0  );
        public static Vector4 ToY00X(this Vector3 v) => new(v.y, 0  , 0  , v.x);
        public static Vector4 ToY00Y(this Vector3 v) => new(v.y, 0  , 0  , v.y);
        public static Vector4 ToY00Z(this Vector3 v) => new(v.y, 0  , 0  , v.z);
        
        public static Vector4 ToY0X0(this Vector3 v) => new(v.y, 0  , v.x, 0  );
        public static Vector4 ToY0XX(this Vector3 v) => new(v.y, 0  , v.x, v.x);
        public static Vector4 ToY0XY(this Vector3 v) => new(v.y, 0  , v.x, v.y);
        public static Vector4 ToY0XZ(this Vector3 v) => new(v.y, 0  , v.x, v.z);
        
        public static Vector4 ToY0Y0(this Vector3 v) => new(v.y, 0  , v.y, 0  );
        public static Vector4 ToY0YX(this Vector3 v) => new(v.y, 0  , v.y, v.x);
        public static Vector4 ToY0YY(this Vector3 v) => new(v.y, 0  , v.y, v.y);
        public static Vector4 ToY0YZ(this Vector3 v) => new(v.y, 0  , v.y, v.z);
        
        public static Vector4 ToY0Z0(this Vector3 v) => new(v.y, 0  , v.z, 0  );
        public static Vector4 ToY0ZX(this Vector3 v) => new(v.y, 0  , v.z, v.x);
        public static Vector4 ToY0ZY(this Vector3 v) => new(v.y, 0  , v.z, v.y);
        public static Vector4 ToY0ZZ(this Vector3 v) => new(v.y, 0  , v.z, v.z);
        
        public static Vector4 ToYX00(this Vector3 v) => new(v.y, v.x, 0  , 0  );
        public static Vector4 ToYX0X(this Vector3 v) => new(v.y, v.x, 0  , v.x);
        public static Vector4 ToYX0Y(this Vector3 v) => new(v.y, v.x, 0  , v.y);
        public static Vector4 ToYX0Z(this Vector3 v) => new(v.y, v.x, 0  , v.z);
        
        public static Vector4 ToYXX0(this Vector3 v) => new(v.y, v.x, v.x, 0  );
        public static Vector4 ToYXXX(this Vector3 v) => new(v.y, v.x, v.x, v.x);
        public static Vector4 ToYXXY(this Vector3 v) => new(v.y, v.x, v.x, v.y);
        public static Vector4 ToYXXZ(this Vector3 v) => new(v.y, v.x, v.x, v.z);
        
        public static Vector4 ToYXY0(this Vector3 v) => new(v.y, v.x, v.y, 0  );
        public static Vector4 ToYXYX(this Vector3 v) => new(v.y, v.x, v.y, v.x);
        public static Vector4 ToYXYY(this Vector3 v) => new(v.y, v.x, v.y, v.y);
        public static Vector4 ToYXYZ(this Vector3 v) => new(v.y, v.x, v.y, v.z);
        
        public static Vector4 ToYXZ0(this Vector3 v) => new(v.y, v.x, v.z, 0  );
        public static Vector4 ToYXZX(this Vector3 v) => new(v.y, v.x, v.z, v.x);
        public static Vector4 ToYXZY(this Vector3 v) => new(v.y, v.x, v.z, v.y);
        public static Vector4 ToYXZZ(this Vector3 v) => new(v.y, v.x, v.z, v.z);
        
        public static Vector4 ToYY00(this Vector3 v) => new(v.y, v.y, 0  , 0  );
        public static Vector4 ToYY0X(this Vector3 v) => new(v.y, v.y, 0  , v.x);
        public static Vector4 ToYY0Y(this Vector3 v) => new(v.y, v.y, 0  , v.y);
        public static Vector4 ToYY0Z(this Vector3 v) => new(v.y, v.y, 0  , v.z);
        
        public static Vector4 ToYYX0(this Vector3 v) => new(v.y, v.y, v.x, 0  );
        public static Vector4 ToYYXX(this Vector3 v) => new(v.y, v.y, v.x, v.x);
        public static Vector4 ToYYXY(this Vector3 v) => new(v.y, v.y, v.x, v.y);
        public static Vector4 ToYYXZ(this Vector3 v) => new(v.y, v.y, v.x, v.z);
        
        public static Vector4 ToYYY0(this Vector3 v) => new(v.y, v.y, v.y, 0  );
        public static Vector4 ToYYYX(this Vector3 v) => new(v.y, v.y, v.y, v.x);
        public static Vector4 ToYYYY(this Vector3 v) => new(v.y, v.y, v.y, v.y);
        public static Vector4 ToYYYZ(this Vector3 v) => new(v.y, v.y, v.y, v.z);
        
        public static Vector4 ToYYZ0(this Vector3 v) => new(v.y, v.y, v.z, 0  );
        public static Vector4 ToYYZX(this Vector3 v) => new(v.y, v.y, v.z, v.x);
        public static Vector4 ToYYZY(this Vector3 v) => new(v.y, v.y, v.z, v.y);
        public static Vector4 ToYYZZ(this Vector3 v) => new(v.y, v.y, v.z, v.z);
        
        public static Vector4 ToYZ00(this Vector3 v) => new(v.y, v.z, 0  , 0  );
        public static Vector4 ToYZ0X(this Vector3 v) => new(v.y, v.z, 0  , v.x);
        public static Vector4 ToYZ0Y(this Vector3 v) => new(v.y, v.z, 0  , v.y);
        public static Vector4 ToYZ0Z(this Vector3 v) => new(v.y, v.z, 0  , v.z);
        
        public static Vector4 ToYZX0(this Vector3 v) => new(v.y, v.z, v.x, 0  );
        public static Vector4 ToYZXX(this Vector3 v) => new(v.y, v.z, v.x, v.x);
        public static Vector4 ToYZXY(this Vector3 v) => new(v.y, v.z, v.x, v.y);
        public static Vector4 ToYZXZ(this Vector3 v) => new(v.y, v.z, v.x, v.z);
        
        public static Vector4 ToYZY0(this Vector3 v) => new(v.y, v.z, v.y, 0  );
        public static Vector4 ToYZYX(this Vector3 v) => new(v.y, v.z, v.y, v.x);
        public static Vector4 ToYZYY(this Vector3 v) => new(v.y, v.z, v.y, v.y);
        public static Vector4 ToYZYZ(this Vector3 v) => new(v.y, v.z, v.y, v.z);
        
        public static Vector4 ToYZZ0(this Vector3 v) => new(v.y, v.z, v.z, 0  );
        public static Vector4 ToYZZX(this Vector3 v) => new(v.y, v.z, v.z, v.x);
        public static Vector4 ToYZZY(this Vector3 v) => new(v.y, v.z, v.z, v.y);
        public static Vector4 ToYZZZ(this Vector3 v) => new(v.y, v.z, v.z, v.z);
        
        public static Vector4 ToZ000(this Vector3 v) => new(v.z, 0  , 0  , 0  );
        public static Vector4 ToZ00X(this Vector3 v) => new(v.z, 0  , 0  , v.x);
        public static Vector4 ToZ00Y(this Vector3 v) => new(v.z, 0  , 0  , v.y);
        public static Vector4 ToZ00Z(this Vector3 v) => new(v.z, 0  , 0  , v.z);
        
        public static Vector4 ToZ0X0(this Vector3 v) => new(v.z, 0  , v.x, 0  );
        public static Vector4 ToZ0XX(this Vector3 v) => new(v.z, 0  , v.x, v.x);
        public static Vector4 ToZ0XY(this Vector3 v) => new(v.z, 0  , v.x, v.y);
        public static Vector4 ToZ0XZ(this Vector3 v) => new(v.z, 0  , v.x, v.z);
        
        public static Vector4 ToZ0Y0(this Vector3 v) => new(v.z, 0  , v.y, 0  );
        public static Vector4 ToZ0YX(this Vector3 v) => new(v.z, 0  , v.y, v.x);
        public static Vector4 ToZ0YY(this Vector3 v) => new(v.z, 0  , v.y, v.y);
        public static Vector4 ToZ0YZ(this Vector3 v) => new(v.z, 0  , v.y, v.z);
        
        public static Vector4 ToZ0Z0(this Vector3 v) => new(v.z, 0  , v.z, 0  );
        public static Vector4 ToZ0ZX(this Vector3 v) => new(v.z, 0  , v.z, v.x);
        public static Vector4 ToZ0ZY(this Vector3 v) => new(v.z, 0  , v.z, v.y);
        public static Vector4 ToZ0ZZ(this Vector3 v) => new(v.z, 0  , v.z, v.z);
        
        public static Vector4 ToZX00(this Vector3 v) => new(v.z, v.x, 0  , 0  );
        public static Vector4 ToZX0X(this Vector3 v) => new(v.z, v.x, 0  , v.x);
        public static Vector4 ToZX0Y(this Vector3 v) => new(v.z, v.x, 0  , v.y);
        public static Vector4 ToZX0Z(this Vector3 v) => new(v.z, v.x, 0  , v.z);
        
        public static Vector4 ToZXX0(this Vector3 v) => new(v.z, v.x, v.x, 0  );
        public static Vector4 ToZXXX(this Vector3 v) => new(v.z, v.x, v.x, v.x);
        public static Vector4 ToZXXY(this Vector3 v) => new(v.z, v.x, v.x, v.y);
        public static Vector4 ToZXXZ(this Vector3 v) => new(v.z, v.x, v.x, v.z);
        
        public static Vector4 ToZXY0(this Vector3 v) => new(v.z, v.x, v.y, 0  );
        public static Vector4 ToZXYX(this Vector3 v) => new(v.z, v.x, v.y, v.x);
        public static Vector4 ToZXYY(this Vector3 v) => new(v.z, v.x, v.y, v.y);
        public static Vector4 ToZXYZ(this Vector3 v) => new(v.z, v.x, v.y, v.z);
        
        public static Vector4 ToZXZ0(this Vector3 v) => new(v.z, v.x, v.z, 0  );
        public static Vector4 ToZXZX(this Vector3 v) => new(v.z, v.x, v.z, v.x);
        public static Vector4 ToZXZY(this Vector3 v) => new(v.z, v.x, v.z, v.y);
        public static Vector4 ToZXZZ(this Vector3 v) => new(v.z, v.x, v.z, v.z);
        
        public static Vector4 ToZY00(this Vector3 v) => new(v.z, v.y, 0  , 0  );
        public static Vector4 ToZY0X(this Vector3 v) => new(v.z, v.y, 0  , v.x);
        public static Vector4 ToZY0Y(this Vector3 v) => new(v.z, v.y, 0  , v.y);
        public static Vector4 ToZY0Z(this Vector3 v) => new(v.z, v.y, 0  , v.z);
        
        public static Vector4 ToZYX0(this Vector3 v) => new(v.z, v.y, v.x, 0  );
        public static Vector4 ToZYXX(this Vector3 v) => new(v.z, v.y, v.x, v.x);
        public static Vector4 ToZYXY(this Vector3 v) => new(v.z, v.y, v.x, v.y);
        public static Vector4 ToZYXZ(this Vector3 v) => new(v.z, v.y, v.x, v.z);
        
        public static Vector4 ToZYY0(this Vector3 v) => new(v.z, v.y, v.y, 0  );
        public static Vector4 ToZYYX(this Vector3 v) => new(v.z, v.y, v.y, v.x);
        public static Vector4 ToZYYY(this Vector3 v) => new(v.z, v.y, v.y, v.y);
        public static Vector4 ToZYYZ(this Vector3 v) => new(v.z, v.y, v.y, v.z);
        
        public static Vector4 ToZYZ0(this Vector3 v) => new(v.z, v.y, v.z, 0  );
        public static Vector4 ToZYZX(this Vector3 v) => new(v.z, v.y, v.z, v.x);
        public static Vector4 ToZYZY(this Vector3 v) => new(v.z, v.y, v.z, v.y);
        public static Vector4 ToZYZZ(this Vector3 v) => new(v.z, v.y, v.z, v.z);
        
        public static Vector4 ToZZ00(this Vector3 v) => new(v.z, v.z, 0  , 0  );
        public static Vector4 ToZZ0X(this Vector3 v) => new(v.z, v.z, 0  , v.x);
        public static Vector4 ToZZ0Y(this Vector3 v) => new(v.z, v.z, 0  , v.y);
        public static Vector4 ToZZ0Z(this Vector3 v) => new(v.z, v.z, 0  , v.z);
        
        public static Vector4 ToZZX0(this Vector3 v) => new(v.z, v.z, v.x, 0  );
        public static Vector4 ToZZXX(this Vector3 v) => new(v.z, v.z, v.x, v.x);
        public static Vector4 ToZZXY(this Vector3 v) => new(v.z, v.z, v.x, v.y);
        public static Vector4 ToZZXZ(this Vector3 v) => new(v.z, v.z, v.x, v.z);
        
        public static Vector4 ToZZY0(this Vector3 v) => new(v.z, v.z, v.y, 0  );
        public static Vector4 ToZZYX(this Vector3 v) => new(v.z, v.z, v.y, v.x);
        public static Vector4 ToZZYY(this Vector3 v) => new(v.z, v.z, v.y, v.y);
        public static Vector4 ToZZYZ(this Vector3 v) => new(v.z, v.z, v.y, v.z);
        
        public static Vector4 ToZZZ0(this Vector3 v) => new(v.z, v.z, v.z, 0  );
        public static Vector4 ToZZZX(this Vector3 v) => new(v.z, v.z, v.z, v.x);
        public static Vector4 ToZZZY(this Vector3 v) => new(v.z, v.z, v.z, v.y);
        public static Vector4 ToZZZZ(this Vector3 v) => new(v.z, v.z, v.z, v.z);
    }
}
