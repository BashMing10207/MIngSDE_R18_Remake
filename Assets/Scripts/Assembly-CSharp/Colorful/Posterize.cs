using UnityEngine;

namespace Colorful
{
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/posterize.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Color Correction/Posterize")]
	public class Posterize : BaseEffect
	{
		[Range(2f, 255f)]
		[Tooltip("Number of tonal levels (brightness values) for each channel.")]
		public int Levels;

		[Tooltip("Blending factor.")]
		[Range(0f, 1f)]
		public float Amount;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
