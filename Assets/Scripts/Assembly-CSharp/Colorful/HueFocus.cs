using UnityEngine;

namespace Colorful
{
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/hue-focus.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Color Correction/Hue Focus")]
	public class HueFocus : BaseEffect
	{
		[Tooltip("Center hue.")]
		[Range(0f, 360f)]
		public float Hue;

		[Tooltip("Hue range to focus on.")]
		[Range(1f, 180f)]
		public float Range;

		[Range(0f, 1f)]
		[Tooltip("Makes the colored pixels more vibrant.")]
		public float Boost;

		[Range(0f, 1f)]
		[Tooltip("Blending Factor.")]
		public float Amount;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
