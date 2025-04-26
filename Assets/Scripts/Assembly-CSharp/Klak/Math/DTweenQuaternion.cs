using UnityEngine;

namespace Klak.Math
{
	internal struct DTweenQuaternion
	{
		public Quaternion rotation;

		public Vector4 velocity;

		public float omega;

		public DTweenQuaternion(Quaternion rotation, float omega)
		{
			this.rotation = default(Quaternion);
			velocity = default(Vector4);
			this.omega = 0f;
		}

		public void Step(Quaternion target)
		{
		}

		public static implicit operator Quaternion(DTweenQuaternion m)
		{
			return default(Quaternion);
		}
	}
}
