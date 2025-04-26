using UnityEngine;

namespace Colorful
{
	[ExecuteInEditMode]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/blur-effects/lens-distortion-blur.html")]
	[AddComponentMenu("Colorful FX/Blur Effects/Lens Distortion Blur")]
	public class LensDistortionBlur : BaseEffect
	{
		public enum QualityPreset
		{
			Low = 4,
			Medium = 8,
			High = 12,
			Custom = 13
		}

		[Tooltip("Quality preset. Higher means better quality but slower processing.")]
		public QualityPreset Quality;

		[Range(2f, 32f)]
		[Tooltip("Sample count. Higher means better quality but slower processing.")]
		public int Samples;

		[Range(-2f, 2f)]
		[Tooltip("Spherical distortion factor.")]
		public float Distortion;

		[Range(-2f, 2f)]
		[Tooltip("Cubic distortion factor.")]
		public float CubicDistortion;

		[Range(0.01f, 2f)]
		[Tooltip("Helps avoid screen streching on borders when working with heavy distortions.")]
		public float Scale;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
