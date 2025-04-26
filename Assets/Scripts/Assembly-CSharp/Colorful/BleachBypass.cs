using UnityEngine;

namespace Colorful
{
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/bleach-bypass.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Color Correction/Bleach Bypass")]
	public class BleachBypass : BaseEffect
	{
		[Tooltip("Blending factor.")]
		[Range(0f, 1f)]
		public float Amount;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
