using UnityEngine;

namespace Colorful
{
	[AddComponentMenu("Colorful FX/Camera Effects/Wiggle")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/camera-effects/wiggle.html")]
	[ExecuteInEditMode]
	public class Wiggle : BaseEffect
	{
		public enum Algorithm
		{
			Simple = 0,
			Complex = 1
		}

		[Tooltip("Animation type. Complex is slower but looks more natural.")]
		public Algorithm Mode;

		public float Timer;

		[Tooltip("Wave animation speed.")]
		public float Speed;

		[Tooltip("Wave frequency (higher means more waves).")]
		public float Frequency;

		[Tooltip("Wave amplitude (higher means bigger waves).")]
		public float Amplitude;

		[Tooltip("Automatically animate this effect at runtime.")]
		public bool AutomaticTimer;

		protected virtual void Update()
		{
		}

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
