using UnityEngine;

namespace Colorful
{
	[AddComponentMenu("Colorful FX/Color Correction/Vibrance")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/vibrance.html")]
	[ExecuteInEditMode]
	public class Vibrance : BaseEffect
	{
		[Range(-100f, 100f)]
		[Tooltip("Adjusts the saturation so that clipping is minimized as colors approach full saturation.")]
		public float Amount;

		[Range(-5f, 5f)]
		public float RedChannel;

		[Range(-5f, 5f)]
		public float GreenChannel;

		[Range(-5f, 5f)]
		public float BlueChannel;

		public bool AdvancedMode;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
