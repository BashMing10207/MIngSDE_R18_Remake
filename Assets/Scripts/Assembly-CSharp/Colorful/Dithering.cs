using UnityEngine;

namespace Colorful
{
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Artistic Effects/Dithering")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/artistic-effects/dithering.html")]
	public class Dithering : BaseEffect
	{
		[Tooltip("Show the original picture under the dithering pass.")]
		public bool ShowOriginal;

		[Tooltip("Convert the original render to black & white.")]
		public bool ConvertToGrayscale;

		[Range(0f, 1f)]
		[Tooltip("Amount of red to contribute to the luminosity.")]
		public float RedLuminance;

		[Tooltip("Amount of green to contribute to the luminosity.")]
		[Range(0f, 1f)]
		public float GreenLuminance;

		[Tooltip("Amount of blue to contribute to the luminosity.")]
		[Range(0f, 1f)]
		public float BlueLuminance;

		[Range(0f, 1f)]
		[Tooltip("Blending factor.")]
		public float Amount;

		protected Texture2D m_DitherPattern;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
