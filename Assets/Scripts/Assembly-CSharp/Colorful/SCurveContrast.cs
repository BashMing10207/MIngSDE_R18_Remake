using UnityEngine;

namespace Colorful
{
	[ExecuteInEditMode]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/s-curve-contrast.html")]
	[AddComponentMenu("Colorful FX/Color Correction/S-Curve Contrast")]
	public class SCurveContrast : BaseEffect
	{
		public float RedSteepness;

		public float RedGamma;

		public float GreenSteepness;

		public float GreenGamma;

		public float BlueSteepness;

		public float BlueGamma;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
