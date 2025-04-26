using UnityEngine;

namespace Colorful
{
	[HelpURL("http://www.thomashourdel.com/colorful/doc/blur-effects/radial-blur.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Blur Effects/Radial Blur")]
	public class RadialBlur : BaseEffect
	{
		public enum QualityPreset
		{
			Low = 4,
			Medium = 8,
			High = 12,
			Custom = 13
		}

		[Range(0f, 1f)]
		[Tooltip("Blur strength.")]
		public float Strength;

		[Range(2f, 32f)]
		[Tooltip("Sample count. Higher means better quality but slower processing.")]
		public int Samples;

		[Tooltip("Focus point.")]
		public Vector2 Center;

		[Tooltip("Quality preset. Higher means better quality but slower processing.")]
		public QualityPreset Quality;

		[Range(-100f, 100f)]
		[Tooltip("Smoothness of the vignette effect.")]
		public float Sharpness;

		[Range(0f, 100f)]
		[Tooltip("Amount of vignetting on screen.")]
		public float Darkness;

		[Tooltip("Should the effect be applied like a vignette ?")]
		public bool EnableVignette;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
