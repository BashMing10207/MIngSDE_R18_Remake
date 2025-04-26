using UnityEngine;

namespace Klak.Math
{
	internal struct DTweenVector2
	{
		public Vector2 position;

		public Vector2 velocity;

		public float omega;

		public DTweenVector2(Vector2 position, float omega)
		{
			this.position = default(Vector2);
			velocity = default(Vector2);
			this.omega = 0f;
		}

		public void Step(Vector2 target)
		{
		}

		public static implicit operator Vector2(DTweenVector2 m)
		{
			return default(Vector2);
		}
	}
}
