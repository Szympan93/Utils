using UnityEngine;

namespace FunFact.Utils
{
    public static class Vector2IntUtils
    {
        public static Vector2Int With(this Vector2Int v, int? x = null, int? y = null) => new(x ?? v.x, y ?? v.y);
        
        public static Vector2Int To00(this Vector2Int v) => new(0, 0);
        public static Vector2Int To0X(this Vector2Int v) => new(0, v.x);
        public static Vector2Int To0Y(this Vector2Int v) => new(0, v.y);
        
        public static Vector2Int ToX0(this Vector2Int v) => new(v.x, 0);
        public static Vector2Int ToXX(this Vector2Int v) => new(v.x, v.x);
        public static Vector2Int ToXY(this Vector2Int v) => new(v.x, v.y);
        
        public static Vector2Int ToY0(this Vector2Int v) => new(v.y, 0);
        public static Vector2Int ToYX(this Vector2Int v) => new(v.y, v.x);
        public static Vector2Int ToYY(this Vector2Int v) => new(v.y, v.y);
        
        public static Vector3Int To000(this Vector2Int v) => new(0  , 0  , 0  );
        public static Vector3Int To00X(this Vector2Int v) => new(0  , 0  , v.x);
        public static Vector3Int To00Y(this Vector2Int v) => new(0  , 0  , v.y);
        
        public static Vector3Int To0X0(this Vector2Int v) => new(0  , v.x, 0  );
        public static Vector3Int To0XX(this Vector2Int v) => new(0  , v.x, v.x);
        public static Vector3Int To0XY(this Vector2Int v) => new(0  , v.x, v.y);
        
        public static Vector3Int To0Y0(this Vector2Int v) => new(0  , v.y, 0  );
        public static Vector3Int To0YX(this Vector2Int v) => new(0  , v.y, v.x);
        public static Vector3Int To0YY(this Vector2Int v) => new(0  , v.y, v.y);
        
        public static Vector3Int ToX00(this Vector2Int v) => new(v.x, 0  , 0  );
        public static Vector3Int ToX0X(this Vector2Int v) => new(v.x, 0  , v.x);
        public static Vector3Int ToX0Y(this Vector2Int v) => new(v.x, 0  , v.y);
        
        public static Vector3Int ToXX0(this Vector2Int v) => new(v.x, v.x, 0  );
        public static Vector3Int ToXXX(this Vector2Int v) => new(v.x, v.x, v.x);
        public static Vector3Int ToXXY(this Vector2Int v) => new(v.x, v.x, v.y);
        
        public static Vector3Int ToXY0(this Vector2Int v) => new(v.x, v.y, 0  );
        public static Vector3Int ToXYX(this Vector2Int v) => new(v.x, v.y, v.x);
        public static Vector3Int ToXYY(this Vector2Int v) => new(v.x, v.y, v.y);
        
        public static Vector3Int ToY00(this Vector2Int v) => new(v.y, 0  , 0  );
        public static Vector3Int ToY0X(this Vector2Int v) => new(v.y, 0  , v.x);
        public static Vector3Int ToY0Y(this Vector2Int v) => new(v.y, 0  , v.y);
        
        public static Vector3Int ToYX0(this Vector2Int v) => new(v.y, v.x, 0  );
        public static Vector3Int ToYXX(this Vector2Int v) => new(v.y, v.x, v.x);
        public static Vector3Int ToYXY(this Vector2Int v) => new(v.y, v.x, v.y);
        
        public static Vector3Int ToYY0(this Vector2Int v) => new(v.y, v.y, 0  );
        public static Vector3Int ToYYX(this Vector2Int v) => new(v.y, v.y, v.x);
        public static Vector3Int ToYYY(this Vector2Int v) => new(v.y, v.y, v.y);
    }
}
