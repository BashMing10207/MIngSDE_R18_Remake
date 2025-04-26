using UnityEngine;

namespace Colorful
{
	[ExecuteInEditMode]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/threshold.html")]
	[AddComponentMenu("Colorful FX/Color Correction/Threshold")]
	public class Threshold : BaseEffect
	{
		[Range(1f, 255f)]
		[Tooltip("Luminosity threshold.")]
		public float Value;

		[Range(0f, 128f)]
		[Tooltip("Aomunt of randomization.")]
		public float NoiseRange;

		[Tooltip("Adds some randomization to the threshold value.")]
		public bool UseNoise;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
