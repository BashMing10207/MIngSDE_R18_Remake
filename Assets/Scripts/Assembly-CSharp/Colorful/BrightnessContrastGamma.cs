using UnityEngine;

namespace Colorful
{
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/brightness-contrast-gamma.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Color Correction/Brightness, Contrast, Gamma")]
	public class BrightnessContrastGamma : BaseEffect
	{
		[Tooltip("Moving the slider to the right increases tonal values and expands highlights, to the left decreases values and expands shadows.")]
		[Range(-100f, 100f)]
		public float Brightness;

		[Tooltip("Expands or shrinks the overall range of tonal values.")]
		[Range(-100f, 100f)]
		public float Contrast;

		public Vector3 ContrastCoeff;

		[Tooltip("Simple power function.")]
		[Range(0.1f, 9.9f)]
		public float Gamma;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
