using UnityEngine;

namespace Colorful
{
	[HelpURL("http://www.thomashourdel.com/colorful/doc/blur-effects/directional-blur.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Blur Effects/Directional Blur")]
	public class DirectionalBlur : BaseEffect
	{
		public enum QualityPreset
		{
			Low = 2,
			Medium = 4,
			High = 6,
			Custom = 7
		}

		[Tooltip("Quality preset. Higher means better quality but slower processing.")]
		public QualityPreset Quality;

		[Tooltip("Sample count. Higher means better quality but slower processing.")]
		[Range(1f, 16f)]
		public int Samples;

		[Tooltip("Blur strength (distance).")]
		[Range(0f, 5f)]
		public float Strength;

		[Tooltip("Blur direction in radians.")]
		public float Angle;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
