using UnityEngine;

namespace Colorful
{
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/dynamic-lookup.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Color Correction/Dynamic Lookup")]
	public class DynamicLookup : BaseEffect
	{
		[ColorUsage(false)]
		public Color White;

		[ColorUsage(false)]
		public Color Black;

		[ColorUsage(false)]
		public Color Red;

		[ColorUsage(false)]
		public Color Green;

		[ColorUsage(false)]
		public Color Blue;

		[ColorUsage(false)]
		public Color Yellow;

		[ColorUsage(false)]
		public Color Magenta;

		[ColorUsage(false)]
		public Color Cyan;

		[Range(0f, 1f)]
		[Tooltip("Blending factor.")]
		public float Amount;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
