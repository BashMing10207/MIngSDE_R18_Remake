using UnityEngine;

namespace Colorful
{
	[ExecuteInEditMode]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/negative.html")]
	[AddComponentMenu("Colorful FX/Color Correction/Negative")]
	public class Negative : BaseEffect
	{
		[Tooltip("Blending factor.")]
		[Range(0f, 1f)]
		public float Amount;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
