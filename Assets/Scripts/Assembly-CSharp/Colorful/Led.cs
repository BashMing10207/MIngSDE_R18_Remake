using UnityEngine;

namespace Colorful
{
	[HelpURL("http://www.thomashourdel.com/colorful/doc/other-effects/led.html")]
	[AddComponentMenu("Colorful FX/Other Effects/LED")]
	[ExecuteInEditMode]
	public class Led : BaseEffect
	{
		public enum SizeMode
		{
			ResolutionIndependent = 0,
			PixelPerfect = 1
		}

		[Tooltip("Scale of an individual LED. Depends on the Mode used.")]
		[Range(1f, 255f)]
		public float Scale;

		[Tooltip("LED brightness booster.")]
		[Range(0f, 10f)]
		public float Brightness;

		[Range(1f, 3f)]
		[Tooltip("LED shape, from softer to harsher.")]
		public float Shape;

		[Tooltip("Turn this on to automatically compute the aspect ratio needed for squared LED.")]
		public bool AutomaticRatio;

		[Tooltip("Custom aspect ratio.")]
		public float Ratio;

		[Tooltip("Used for the Scale field.")]
		public SizeMode Mode;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
