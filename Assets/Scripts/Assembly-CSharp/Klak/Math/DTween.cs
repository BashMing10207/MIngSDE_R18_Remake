using UnityEngine;

namespace Klak.Math
{
	internal struct DTween
	{
		public float position;

		public float velocity;

		public float omega;

		public static float Step(float current, float target, ref float velocity, float omega)
		{
			return 0f;
		}

		public static Vector2 Step(Vector2 current, Vector2 target, ref Vector2 velocity, float omega)
		{
			return default(Vector2);
		}

		public static Vector3 Step(Vector3 current, Vector3 target, ref Vector3 velocity, float omega)
		{
			return default(Vector3);
		}

		public static Vector4 Step(Vector4 current, Vector4 target, ref Vector4 velocity, float omega)
		{
			return default(Vector4);
		}

		public static Quaternion Step(Quaternion current, Quaternion target, ref Vector4 velocity, float omega)
		{
			return default(Quaternion);
		}

		public DTween(float position, float omega)
		{
			this.position = 0f;
			velocity = 0f;
			this.omega = 0f;
		}

		public void Step(float target)
		{
		}

		public static implicit operator float(DTween m)
		{
			return 0f;
		}
	}
}
