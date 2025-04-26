using UnityEngine;

namespace Klak.Motion
{
	[AddComponentMenu("Klak/Motion/Smooth Follow")]
	public class SmoothFollow : MonoBehaviour
	{
		public enum Interpolator
		{
			Exponential = 0,
			Spring = 1,
			DampedSpring = 2
		}

		[SerializeField]
		private Interpolator _interpolator;

		[SerializeField]
		private Transform _target;

		[SerializeField]
		[Range(0f, 10f)]
		private float _positionSpeed;

		[Range(0f, 10f)]
		[SerializeField]
		private float _rotationSpeed;

		[SerializeField]
		private float _jumpDistance;

		[SerializeField]
		[Range(0f, 360f)]
		private float _jumpAngle;

		private Vector3 _vposition;

		private Vector4 _vrotation;

		public Interpolator interpolationType
		{
			get
			{
				return default(Interpolator);
			}
			set
			{
			}
		}

		public Transform target
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float positionSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float rotationSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float jumpDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float jumpAngle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public void Snap()
		{
		}

		public void JumpRandomly()
		{
		}

		private Vector3 SpringPosition(Vector3 current, Vector3 target)
		{
			return default(Vector3);
		}

		private Quaternion SpringRotation(Quaternion current, Quaternion target)
		{
			return default(Quaternion);
		}

		private void Update()
		{
		}
	}
}
