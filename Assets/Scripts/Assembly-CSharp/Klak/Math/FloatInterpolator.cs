using System;
using UnityEngine;

namespace Klak.Math
{
	public struct FloatInterpolator
	{
		[Serializable]
		public class Config
		{
			public enum InterpolationType
			{
				Direct = 0,
				Exponential = 1,
				DampedSpring = 2
			}

			[SerializeField]
			private InterpolationType _interpolationType;

			[SerializeField]
			[Range(0.1f, 50f)]
			private float _interpolationSpeed;

			public InterpolationType interpolationType
			{
				get
				{
					return default(InterpolationType);
				}
				set
				{
				}
			}

			public bool enabled => false;

			public float interpolationSpeed
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}
		}

		private float _velocity;

		public Config config { get; set; }

		public float currentValue { get; set; }

		public float targetValue { get; set; }

		public FloatInterpolator(float initialValue, Config config)
		{
			_velocity = 0f;
			this.config = null;
			currentValue = 0f;
			targetValue = 0f;
		}

		public float Step(float targetValue)
		{
			return 0f;
		}

		public float Step()
		{
			return 0f;
		}
	}
}
