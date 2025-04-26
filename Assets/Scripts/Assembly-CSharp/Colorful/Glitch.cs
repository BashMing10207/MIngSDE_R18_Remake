using System;
using UnityEngine;

namespace Colorful
{
	[HelpURL("http://www.thomashourdel.com/colorful/doc/camera-effects/glitch.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Camera Effects/Glitch")]
	public class Glitch : BaseEffect
	{
		public enum GlitchingMode
		{
			Interferences = 0,
			Tearing = 1,
			Complete = 2
		}

		[Serializable]
		public class InterferenceSettings
		{
			public float Speed;

			public float Density;

			public float MaxDisplacement;
		}

		[Serializable]
		public class TearingSettings
		{
			public float Speed;

			[Range(0f, 1f)]
			public float Intensity;

			[Range(0f, 0.5f)]
			public float MaxDisplacement;

			public bool AllowFlipping;

			public bool YuvColorBleeding;

			[Range(-2f, 2f)]
			public float YuvOffset;
		}

		[Tooltip("Automatically activate/deactivate the effect randomly.")]
		public bool RandomActivation;

		public Vector2 RandomEvery;

		public Vector2 RandomDuration;

		[Tooltip("Glitch type.")]
		public GlitchingMode Mode;

		public InterferenceSettings SettingsInterferences;

		public TearingSettings SettingsTearing;

		protected bool m_Activated;

		protected float m_EveryTimer;

		protected float m_EveryTimerEnd;

		protected float m_DurationTimer;

		protected float m_DurationTimerEnd;

		public bool IsActive => false;

		[Obsolete]
		protected override void Start()
		{
		}

		protected virtual void Update()
		{
		}

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		protected virtual void DoInterferences(RenderTexture source, RenderTexture destination, InterferenceSettings settings)
		{
		}

		protected virtual void DoTearing(RenderTexture source, RenderTexture destination, TearingSettings settings)
		{
		}
	}
}
