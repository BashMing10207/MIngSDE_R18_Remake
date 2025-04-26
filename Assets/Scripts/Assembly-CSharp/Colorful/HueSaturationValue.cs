using UnityEngine;

namespace Colorful
{
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Color Correction/Hue, Saturation, Value")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/hue-saturation-value.html")]
	public class HueSaturationValue : BaseEffect
	{
		[Range(-180f, 180f)]
		public float MasterHue;

		[Range(-100f, 100f)]
		public float MasterSaturation;

		[Range(-100f, 100f)]
		public float MasterValue;

		[Range(-180f, 180f)]
		public float RedsHue;

		[Range(-100f, 100f)]
		public float RedsSaturation;

		[Range(-100f, 100f)]
		public float RedsValue;

		[Range(-180f, 180f)]
		public float YellowsHue;

		[Range(-100f, 100f)]
		public float YellowsSaturation;

		[Range(-100f, 100f)]
		public float YellowsValue;

		[Range(-180f, 180f)]
		public float GreensHue;

		[Range(-100f, 100f)]
		public float GreensSaturation;

		[Range(-100f, 100f)]
		public float GreensValue;

		[Range(-180f, 180f)]
		public float CyansHue;

		[Range(-100f, 100f)]
		public float CyansSaturation;

		[Range(-100f, 100f)]
		public float CyansValue;

		[Range(-180f, 180f)]
		public float BluesHue;

		[Range(-100f, 100f)]
		public float BluesSaturation;

		[Range(-100f, 100f)]
		public float BluesValue;

		[Range(-180f, 180f)]
		public float MagentasHue;

		[Range(-100f, 100f)]
		public float MagentasSaturation;

		[Range(-100f, 100f)]
		public float MagentasValue;

		public bool AdvancedMode;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
