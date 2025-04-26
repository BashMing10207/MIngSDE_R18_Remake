using UnityEngine;

namespace Colorful
{
	[AddComponentMenu("Colorful FX/Color Correction/Grayscale")]
	[ExecuteInEditMode]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/grayscale.html")]
	public class Grayscale : BaseEffect
	{
		[Range(0f, 1f)]
		[Tooltip("Amount of red to contribute to the luminosity.")]
		public float RedLuminance;

		[Range(0f, 1f)]
		[Tooltip("Amount of green to contribute to the luminosity.")]
		public float GreenLuminance;

		[Range(0f, 1f)]
		[Tooltip("Amount of blue to contribute to the luminosity.")]
		public float BlueLuminance;

		[Range(0f, 1f)]
		[Tooltip("Blending factor.")]
		public float Amount;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
