using UnityEngine;

namespace FunFact.Utils
{
    public static class Vector3IntUtils
    {
        public static Vector3Int With(this Vector3Int v, int? x = null, int? y = null, int? z = null) => new(x ?? v.x, y ?? v.y, z ?? v.z);
        
        public static Vector2Int To00(this Vector3Int v) => new(0, 0);
        public static Vector2Int To0X(this Vector3Int v) => new(0, v.x);
        public static Vector2Int To0Y(this Vector3Int v) => new(0, v.y);
        public static Vector2Int To0Z(this Vector3Int v) => new(0, v.z);
        
        public static Vector2Int ToX0(this Vector3Int v) => new(v.x, 0);
        public static Vector2Int ToXX(this Vector3Int v) => new(v.x, v.x);
        public static Vector2Int ToXY(this Vector3Int v) => new(v.x, v.y);
        public static Vector2Int ToXZ(this Vector3Int v) => new(v.x, v.z);
        
        public static Vector2Int ToY0(this Vector3Int v) => new(v.y, 0);
        public static Vector2Int ToYX(this Vector3Int v) => new(v.y, v.x);
        public static Vector2Int ToYY(this Vector3Int v) => new(v.y, v.y);
        public static Vector2Int ToYZ(this Vector3Int v) => new(v.y, v.z);
        
        public static Vector2Int ToZ0(this Vector3Int v) => new(v.z, 0);
        public static Vector2Int ToZX(this Vector3Int v) => new(v.z, v.x);
        public static Vector2Int ToZY(this Vector3Int v) => new(v.z, v.y);
        public static Vector2Int ToZZ(this Vector3Int v) => new(v.z, v.z);
        
        public static Vector3Int To000(this Vector3Int v) => new(0  , 0  , 0  );
        public static Vector3Int To00X(this Vector3Int v) => new(0  , 0  , v.x);
        public static Vector3Int To00Y(this Vector3Int v) => new(0  , 0  , v.y);
        public static Vector3Int To00Z(this Vector3Int v) => new(0  , 0  , v.z);
        
        public static Vector3Int To0X0(this Vector3Int v) => new(0  , v.x, 0  );
        public static Vector3Int To0XX(this Vector3Int v) => new(0  , v.x, v.x);
        public static Vector3Int To0XY(this Vector3Int v) => new(0  , v.x, v.y);
        public static Vector3Int To0XZ(this Vector3Int v) => new(0  , v.x, v.z);
        
        public static Vector3Int To0Y0(this Vector3Int v) => new(0  , v.y, 0  );
        public static Vector3Int To0YX(this Vector3Int v) => new(0  , v.y, v.x);
        public static Vector3Int To0YY(this Vector3Int v) => new(0  , v.y, v.y);
        public static Vector3Int To0YZ(this Vector3Int v) => new(0  , v.y, v.z);
        
        public static Vector3Int To0Z0(this Vector3Int v) => new(0  , v.z, 0  );
        public static Vector3Int To0ZX(this Vector3Int v) => new(0  , v.z, v.x);
        public static Vector3Int To0ZY(this Vector3Int v) => new(0  , v.z, v.y);
        public static Vector3Int To0ZZ(this Vector3Int v) => new(0  , v.z, v.z);
        
        public static Vector3Int ToX00(this Vector3Int v) => new(v.x, 0  , 0  );
        public static Vector3Int ToX0X(this Vector3Int v) => new(v.x, 0  , v.x);
        public static Vector3Int ToX0Y(this Vector3Int v) => new(v.x, 0  , v.y);
        public static Vector3Int ToX0Z(this Vector3Int v) => new(v.x, 0  , v.z);
        
        public static Vector3Int ToXX0(this Vector3Int v) => new(v.x, v.x, 0  );
        public static Vector3Int ToXXX(this Vector3Int v) => new(v.x, v.x, v.x);
        public static Vector3Int ToXXY(this Vector3Int v) => new(v.x, v.x, v.y);
        public static Vector3Int ToXXZ(this Vector3Int v) => new(v.x, v.x, v.z);
        
        public static Vector3Int ToXY0(this Vector3Int v) => new(v.x, v.y, 0  );
        public static Vector3Int ToXYX(this Vector3Int v) => new(v.x, v.y, v.x);
        public static Vector3Int ToXYY(this Vector3Int v) => new(v.x, v.y, v.y);
        public static Vector3Int ToXYZ(this Vector3Int v) => new(v.x, v.y, v.z);
        
        public static Vector3Int ToXZ0(this Vector3Int v) => new(v.x, v.z, 0  );
        public static Vector3Int ToXZX(this Vector3Int v) => new(v.x, v.z, v.x);
        public static Vector3Int ToXZY(this Vector3Int v) => new(v.x, v.z, v.y);
        public static Vector3Int ToXZZ(this Vector3Int v) => new(v.x, v.z, v.z);
        
        public static Vector3Int ToY00(this Vector3Int v) => new(v.y, 0  , 0  );
        public static Vector3Int ToY0X(this Vector3Int v) => new(v.y, 0  , v.x);
        public static Vector3Int ToY0Y(this Vector3Int v) => new(v.y, 0  , v.y);
        public static Vector3Int ToY0Z(this Vector3Int v) => new(v.y, 0  , v.z);
        
        public static Vector3Int ToYX0(this Vector3Int v) => new(v.y, v.x, 0  );
        public static Vector3Int ToYXX(this Vector3Int v) => new(v.y, v.x, v.x);
        public static Vector3Int ToYXY(this Vector3Int v) => new(v.y, v.x, v.y);
        public static Vector3Int ToYXZ(this Vector3Int v) => new(v.y, v.x, v.z);
        
        public static Vector3Int ToYY0(this Vector3Int v) => new(v.y, v.y, 0  );
        public static Vector3Int ToYYX(this Vector3Int v) => new(v.y, v.y, v.x);
        public static Vector3Int ToYYY(this Vector3Int v) => new(v.y, v.y, v.y);
        public static Vector3Int ToYYZ(this Vector3Int v) => new(v.y, v.y, v.z);
        
        public static Vector3Int ToYZ0(this Vector3Int v) => new(v.y, v.z, 0  );
        public static Vector3Int ToYZX(this Vector3Int v) => new(v.y, v.z, v.x);
        public static Vector3Int ToYZY(this Vector3Int v) => new(v.y, v.z, v.y);
        public static Vector3Int ToYZZ(this Vector3Int v) => new(v.y, v.z, v.z);
        
        public static Vector3Int ToZ00(this Vector3Int v) => new(v.z, 0  , 0  );
        public static Vector3Int ToZ0X(this Vector3Int v) => new(v.z, 0  , v.x);
        public static Vector3Int ToZ0Y(this Vector3Int v) => new(v.z, 0  , v.y);
        public static Vector3Int ToZ0Z(this Vector3Int v) => new(v.z, 0  , v.z);
        
        public static Vector3Int ToZX0(this Vector3Int v) => new(v.z, v.x, 0  );
        public static Vector3Int ToZXX(this Vector3Int v) => new(v.z, v.x, v.x);
        public static Vector3Int ToZXY(this Vector3Int v) => new(v.z, v.x, v.y);
        public static Vector3Int ToZXZ(this Vector3Int v) => new(v.z, v.x, v.z);
        
        public static Vector3Int ToZY0(this Vector3Int v) => new(v.z, v.y, 0  );
        public static Vector3Int ToZYX(this Vector3Int v) => new(v.z, v.y, v.x);
        public static Vector3Int ToZYY(this Vector3Int v) => new(v.z, v.y, v.y);
        public static Vector3Int ToZYZ(this Vector3Int v) => new(v.z, v.y, v.z);
        
        public static Vector3Int ToZZ0(this Vector3Int v) => new(v.z, v.z, 0  );
        public static Vector3Int ToZZX(this Vector3Int v) => new(v.z, v.z, v.x);
        public static Vector3Int ToZZY(this Vector3Int v) => new(v.z, v.z, v.y);
        public static Vector3Int ToZZZ(this Vector3Int v) => new(v.z, v.z, v.z);
    }
}
