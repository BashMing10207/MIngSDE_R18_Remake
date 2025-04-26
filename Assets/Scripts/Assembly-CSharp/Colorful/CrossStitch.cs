using UnityEngine;

namespace Colorful
{
	[HelpURL("http://www.thomashourdel.com/colorful/doc/artistic-effects/cross-stitch.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Artistic Effects/Cross Stitch")]
	public class CrossStitch : BaseEffect
	{
		[Tooltip("Works best with power of two values.")]
		[Range(1f, 128f)]
		public int Size;

		[Tooltip("Brightness adjustment. Cross-stitching tends to lower the overall brightness, use this to compensate.")]
		[Range(0f, 10f)]
		public float Brightness;

		[Tooltip("Inverts the cross-stiching pattern.")]
		public bool Invert;

		[Tooltip("Should the original render be pixelized ?")]
		public bool Pixelize;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
