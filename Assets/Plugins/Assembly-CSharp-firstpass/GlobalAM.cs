using UnityEngine;

public class GlobalAM : MonoBehaviour
{
	public static float FloatTimeZero(float _variable)
	{
		return 0f;
	}

	public static float Distance(float a, float b)
	{
		return 0f;
	}

	public static void SaveFile(string path, string text)
	{
	}

	public static Texture2D TextureLoad(int _width, int _height, string path)
	{
		return null;
	}

	public static bool ExistsData(string path)
	{
		return false;
	}

	public static void DeleteData(string path)
	{
	}

	public static void SaveData(string path, string text)
	{
	}

	public static string[] LoadData(string path)
	{
		return null;
	}

	public static int LoadDataInt(string path, int indexString)
	{
		return 0;
	}

	public static bool LoadDataStringExists(string path, string _string)
	{
		return false;
	}

	public static float DistanceFloor(Vector3 position1, Vector3 position2)
	{
		return 0f;
	}

	public static Vector3 DirectionFloor(Vector3 positionStart, Vector3 positionEnd)
	{
		return default(Vector3);
	}

	public static Vector3 Direction(Vector3 positionStart, Vector3 positionEnd)
	{
		return default(Vector3);
	}

	public static Vector3 VectorFloor(Vector3 vector3)
	{
		return default(Vector3);
	}

	public static Vector3 NormalizeFloor(Vector3 vector3)
	{
		return default(Vector3);
	}

	public static Vector2 Vector2Normalize(Vector2 vector2)
	{
		return default(Vector2);
	}

	public static Vector3 TransformPivot(Transform _transform, Vector3 _vector3)
	{
		return default(Vector3);
	}

	public static Vector3 TransformPivotLocal(Transform _transform, Vector3 _vector3)
	{
		return default(Vector3);
	}

	public static Vector3 TransformDirection(Transform _transform, Vector3 _vector3)
	{
		return default(Vector3);
	}

	public static Vector2 Vector2Clamp(Vector2 _vector2, float _min, float _max)
	{
		return default(Vector2);
	}

	public static Vector3 Vector3Clamp2D(Vector2 _vector2, float _min, float _max)
	{
		return default(Vector3);
	}

	public static Vector3 Vector3Random(float _min, float _max)
	{
		return default(Vector3);
	}

	public static bool LinesIntersection(out Vector3 intersection, float radiusIntersection, bool checkDistance, Vector3 lineStart1, Vector3 lineEnd1, Vector3 lineStart2, Vector3 lineEnd2)
	{
		intersection = default(Vector3);
		return false;
	}

	public static GameObject[] OverlapLine(Vector3 pointStart, Vector3 pointEnd, LayerMask layers)
	{
		return null;
	}

	public static void DestroyColliders(GameObject _object)
	{
	}

	public static float RotationFloor(Vector3 _pointStart, Vector3 _pointEnd)
	{
		return 0f;
	}

	public static Quaternion RotationFloorQuaternion(Vector3 _pointStart, Vector3 _pointEnd)
	{
		return default(Quaternion);
	}

	public static Quaternion RotationDirection(Vector3 _pointStart, Vector3 _pointEnd)
	{
		return default(Quaternion);
	}

	public static int StringToInt(string x)
	{
		return 0;
	}

	public static float StringToFloat(string x)
	{
		return 0f;
	}

	public static float DoubleToFloat(double x)
	{
		return 0f;
	}

	public static float FloatRound(float x, int count)
	{
		return 0f;
	}

	public static int ChanceInt()
	{
		return 0;
	}

	public static float ChanceFloat()
	{
		return 0f;
	}

	public static bool ChanceBool(float x)
	{
		return false;
	}

	public static int RandomNext(int _was, int _min, int _max)
	{
		return 0;
	}

	public static void DrawBox(Transform transformTarget, Vector3 offset, Vector3 size, Color colorDraw)
	{
	}

	public static void DrawBoxZero(Vector3 offset, Vector3 size, Color colorDraw)
	{
	}

	public static void DrawCircle(Vector3 position, Vector3 direction, float radius, Color colorDraw)
	{
	}

	public static void DrawCross(Vector3 position, float _radius, Color colorDraw)
	{
	}
}
