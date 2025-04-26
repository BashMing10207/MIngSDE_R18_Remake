using UnityEngine;

namespace Colorful
{
	[HelpURL("http://www.thomashourdel.com/colorful/doc/artistic-effects/strokes.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Artistic Effects/Strokes")]
	public class Strokes : BaseEffect
	{
		public enum ColorMode
		{
			BlackAndWhite = 0,
			WhiteAndBlack = 1,
			ColorAndWhite = 2,
			ColorAndBlack = 3,
			WhiteAndColor = 4,
			BlackAndColor = 5
		}

		public ColorMode Mode;

		[Tooltip("Stroke rotation, or wave pattern amplitude.")]
		[Range(0f, 0.04f)]
		public float Amplitude;

		[Tooltip("Wave pattern frequency (higher means more waves).")]
		[Range(0f, 20f)]
		public float Frequency;

		[Range(4f, 12f)]
		[Tooltip("Global scaling.")]
		public float Scaling;

		[Tooltip("Stroke maximum thickness.")]
		[Range(0.1f, 0.5f)]
		public float MaxThickness;

		[Range(0f, 1f)]
		[Tooltip("Contribution threshold (higher means more continous strokes).")]
		public float Threshold;

		[Range(-0.3f, 0.3f)]
		[Tooltip("Stroke pressure.")]
		public float Harshness;

		[Range(0f, 1f)]
		[Tooltip("Amount of red to contribute to the strokes.")]
		public float RedLuminance;

		[Range(0f, 1f)]
		[Tooltip("Amount of green to contribute to the strokes.")]
		public float GreenLuminance;

		[Range(0f, 1f)]
		[Tooltip("Amount of blue to contribute to the strokes.")]
		public float BlueLuminance;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
