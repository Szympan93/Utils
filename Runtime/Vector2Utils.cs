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
        
        public static Vector4 To0000(this Vector2 v) => new(0  , 0  , 0  , 0  );
        public static Vector4 To000X(this Vector2 v) => new(0  , 0  , 0  , v.x);
        public static Vector4 To000Y(this Vector2 v) => new(0  , 0  , 0  , v.y);
        
        public static Vector4 To00X0(this Vector2 v) => new(0  , 0  , v.x, 0  );
        public static Vector4 To00XX(this Vector2 v) => new(0  , 0  , v.x, v.x);
        public static Vector4 To00XY(this Vector2 v) => new(0  , 0  , v.x, v.y);
        
        public static Vector4 To00Y0(this Vector2 v) => new(0  , 0  , v.y, 0  );
        public static Vector4 To00YX(this Vector2 v) => new(0  , 0  , v.y, v.x);
        public static Vector4 To00YY(this Vector2 v) => new(0  , 0  , v.y, v.y);
        
        public static Vector4 To0X00(this Vector2 v) => new(0  , v.x, 0  , 0  );
        public static Vector4 To0X0X(this Vector2 v) => new(0  , v.x, 0  , v.x);
        public static Vector4 To0X0Y(this Vector2 v) => new(0  , v.x, 0  , v.y);
        
        public static Vector4 To0XX0(this Vector2 v) => new(0  , v.x, v.x, 0  );
        public static Vector4 To0XXX(this Vector2 v) => new(0  , v.x, v.x, v.x);
        public static Vector4 To0XXY(this Vector2 v) => new(0  , v.x, v.x, v.y);
        
        public static Vector4 To0XY0(this Vector2 v) => new(0  , v.x, v.y, 0  );
        public static Vector4 To0XYX(this Vector2 v) => new(0  , v.x, v.y, v.x);
        public static Vector4 To0XYY(this Vector2 v) => new(0  , v.x, v.y, v.y);
        
        public static Vector4 To0Y00(this Vector2 v) => new(0  , v.y, 0  , 0  );
        public static Vector4 To0Y0X(this Vector2 v) => new(0  , v.y, 0  , v.x);
        public static Vector4 To0Y0Y(this Vector2 v) => new(0  , v.y, 0  , v.y);
        
        public static Vector4 To0YX0(this Vector2 v) => new(0  , v.y, v.x, 0  );
        public static Vector4 To0YXX(this Vector2 v) => new(0  , v.y, v.x, v.x);
        public static Vector4 To0YXY(this Vector2 v) => new(0  , v.y, v.x, v.y);
        
        public static Vector4 To0YY0(this Vector2 v) => new(0  , v.y, v.y, 0  );
        public static Vector4 To0YYX(this Vector2 v) => new(0  , v.y, v.y, v.x);
        public static Vector4 To0YYY(this Vector2 v) => new(0  , v.y, v.y, v.y);
        
        public static Vector4 ToX000(this Vector2 v) => new(v.x, 0  , 0  , 0  );
        public static Vector4 ToX00X(this Vector2 v) => new(v.x, 0  , 0  , v.x);
        public static Vector4 ToX00Y(this Vector2 v) => new(v.x, 0  , 0  , v.y);
        
        public static Vector4 ToX0X0(this Vector2 v) => new(v.x, 0  , v.x, 0  );
        public static Vector4 ToX0XX(this Vector2 v) => new(v.x, 0  , v.x, v.x);
        public static Vector4 ToX0XY(this Vector2 v) => new(v.x, 0  , v.x, v.y);
        
        public static Vector4 ToX0Y0(this Vector2 v) => new(v.x, 0  , v.y, 0  );
        public static Vector4 ToX0YX(this Vector2 v) => new(v.x, 0  , v.y, v.x);
        public static Vector4 ToX0YY(this Vector2 v) => new(v.x, 0  , v.y, v.y);
        
        public static Vector4 ToXX00(this Vector2 v) => new(v.x, v.x, 0  , 0  );
        public static Vector4 ToXX0X(this Vector2 v) => new(v.x, v.x, 0  , v.x);
        public static Vector4 ToXX0Y(this Vector2 v) => new(v.x, v.x, 0  , v.y);
        
        public static Vector4 ToXXX0(this Vector2 v) => new(v.x, v.x, v.x, 0  );
        public static Vector4 ToXXXX(this Vector2 v) => new(v.x, v.x, v.x, v.x);
        public static Vector4 ToXXXY(this Vector2 v) => new(v.x, v.x, v.x, v.y);
        
        public static Vector4 ToXXY0(this Vector2 v) => new(v.x, v.x, v.y, 0  );
        public static Vector4 ToXXYX(this Vector2 v) => new(v.x, v.x, v.y, v.x);
        public static Vector4 ToXXYY(this Vector2 v) => new(v.x, v.x, v.y, v.y);
        
        public static Vector4 ToXY00(this Vector2 v) => new(v.x, v.y, 0  , 0  );
        public static Vector4 ToXY0X(this Vector2 v) => new(v.x, v.y, 0  , v.x);
        public static Vector4 ToXY0Y(this Vector2 v) => new(v.x, v.y, 0  , v.y);
        
        public static Vector4 ToXYX0(this Vector2 v) => new(v.x, v.y, v.x, 0  );
        public static Vector4 ToXYXX(this Vector2 v) => new(v.x, v.y, v.x, v.x);
        public static Vector4 ToXYXY(this Vector2 v) => new(v.x, v.y, v.x, v.y);
        
        public static Vector4 ToXYY0(this Vector2 v) => new(v.x, v.y, v.y, 0  );
        public static Vector4 ToXYYX(this Vector2 v) => new(v.x, v.y, v.y, v.x);
        public static Vector4 ToXYYY(this Vector2 v) => new(v.x, v.y, v.y, v.y);
        
        public static Vector4 ToY000(this Vector2 v) => new(v.y, 0  , 0  , 0  );
        public static Vector4 ToY00X(this Vector2 v) => new(v.y, 0  , 0  , v.x);
        public static Vector4 ToY00Y(this Vector2 v) => new(v.y, 0  , 0  , v.y);
        
        public static Vector4 ToY0X0(this Vector2 v) => new(v.y, 0  , v.x, 0  );
        public static Vector4 ToY0XX(this Vector2 v) => new(v.y, 0  , v.x, v.x);
        public static Vector4 ToY0XY(this Vector2 v) => new(v.y, 0  , v.x, v.y);
        
        public static Vector4 ToY0Y0(this Vector2 v) => new(v.y, 0  , v.y, 0  );
        public static Vector4 ToY0YX(this Vector2 v) => new(v.y, 0  , v.y, v.x);
        public static Vector4 ToY0YY(this Vector2 v) => new(v.y, 0  , v.y, v.y);
        
        public static Vector4 ToYX00(this Vector2 v) => new(v.y, v.x, 0  , 0  );
        public static Vector4 ToYX0X(this Vector2 v) => new(v.y, v.x, 0  , v.x);
        public static Vector4 ToYX0Y(this Vector2 v) => new(v.y, v.x, 0  , v.y);
        
        public static Vector4 ToYXX0(this Vector2 v) => new(v.y, v.x, v.x, 0  );
        public static Vector4 ToYXXX(this Vector2 v) => new(v.y, v.x, v.x, v.x);
        public static Vector4 ToYXXY(this Vector2 v) => new(v.y, v.x, v.x, v.y);
        
        public static Vector4 ToYXY0(this Vector2 v) => new(v.y, v.x, v.y, 0  );
        public static Vector4 ToYXYX(this Vector2 v) => new(v.y, v.x, v.y, v.x);
        public static Vector4 ToYXYY(this Vector2 v) => new(v.y, v.x, v.y, v.y);
        
        public static Vector4 ToYY00(this Vector2 v) => new(v.y, v.y, 0  , 0  );
        public static Vector4 ToYY0X(this Vector2 v) => new(v.y, v.y, 0  , v.x);
        public static Vector4 ToYY0Y(this Vector2 v) => new(v.y, v.y, 0  , v.y);
        
        public static Vector4 ToYYX0(this Vector2 v) => new(v.y, v.y, v.x, 0  );
        public static Vector4 ToYYXX(this Vector2 v) => new(v.y, v.y, v.x, v.x);
        public static Vector4 ToYYXY(this Vector2 v) => new(v.y, v.y, v.x, v.y);
        
        public static Vector4 ToYYY0(this Vector2 v) => new(v.y, v.y, v.y, 0  );
        public static Vector4 ToYYYX(this Vector2 v) => new(v.y, v.y, v.y, v.x);
        public static Vector4 ToYYYY(this Vector2 v) => new(v.y, v.y, v.y, v.y);
    }
}
