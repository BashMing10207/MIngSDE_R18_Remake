using UnityEngine;

namespace Colorful
{
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/photo-filter.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Color Correction/Photo Filter")]
	public class PhotoFilter : BaseEffect
	{
		[ColorUsage(false)]
		[Tooltip("Lens filter color.")]
		public Color Color;

		[Tooltip("Blending factor.")]
		[Range(0f, 1f)]
		public float Density;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
