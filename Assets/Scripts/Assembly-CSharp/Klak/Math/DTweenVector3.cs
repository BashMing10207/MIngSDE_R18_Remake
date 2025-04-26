using UnityEngine;

namespace Klak.Math
{
	internal struct DTweenVector3
	{
		public Vector3 position;

		public Vector3 velocity;

		public float omega;

		public DTweenVector3(Vector3 position, float omega)
		{
			this.position = default(Vector3);
			velocity = default(Vector3);
			this.omega = 0f;
		}

		public void Step(Vector3 target)
		{
		}

		public static implicit operator Vector3(DTweenVector3 m)
		{
			return default(Vector3);
		}
	}
}
