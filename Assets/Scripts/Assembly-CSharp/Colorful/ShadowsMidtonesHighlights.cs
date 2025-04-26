using UnityEngine;

namespace Colorful
{
	[AddComponentMenu("Colorful FX/Color Correction/Shadows, Midtones, Highlights")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/shadows-midtones-highlights.html")]
	[ExecuteInEditMode]
	public class ShadowsMidtonesHighlights : BaseEffect
	{
		public enum ColorMode
		{
			LiftGammaGain = 0,
			OffsetGammaSlope = 1
		}

		[Tooltip("Color mode. The difference between these two modes is the way shadows are handled.")]
		public ColorMode Mode;

		[Tooltip("Adds density or darkness, raises or lowers the shadow levels with its alpha value and offset the color balance in the dark regions with the hue point.")]
		public Color Shadows;

		[Tooltip("Shifts the middle tones to be brighter or darker. For instance, to make your render more warm, just move the midtone color toward the yellow/red range. The more saturated the color is, the warmer the render becomes.")]
		public Color Midtones;

		[Tooltip("Brightens and tints the entire render but mostly affects the highlights.")]
		public Color Highlights;

		[Tooltip("Blending factor.")]
		[Range(0f, 1f)]
		public float Amount;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
