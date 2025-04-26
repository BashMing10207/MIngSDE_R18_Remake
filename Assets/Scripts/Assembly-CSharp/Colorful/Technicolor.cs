using UnityEngine;

namespace Colorful
{
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/technicolor.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Color Correction/Technicolor")]
	public class Technicolor : BaseEffect
	{
		[Range(0f, 8f)]
		public float Exposure;

		public Vector3 Balance;

		[Range(0f, 1f)]
		[Tooltip("Blending factor.")]
		public float Amount;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
