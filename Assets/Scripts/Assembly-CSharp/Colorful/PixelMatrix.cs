using UnityEngine;

namespace Colorful
{
	[AddComponentMenu("Colorful FX/Other Effects/Pixel Matrix")]
	[ExecuteInEditMode]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/other-effects/pixel-matrix.html")]
	public class PixelMatrix : BaseEffect
	{
		[Min(3f)]
		[Tooltip("Tile size. Works best with multiples of 3.")]
		public int Size;

		[Range(0f, 10f)]
		[Tooltip("Tile brightness booster.")]
		public float Brightness;

		[Tooltip("Show / hide black borders on every tile.")]
		public bool BlackBorder;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
