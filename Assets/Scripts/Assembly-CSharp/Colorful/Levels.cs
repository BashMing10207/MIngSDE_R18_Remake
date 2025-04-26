using UnityEngine;

namespace Colorful
{
	[AddComponentMenu("Colorful FX/Color Correction/Levels")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/levels.html")]
	[ExecuteInEditMode]
	public class Levels : BaseEffect
	{
		public enum ColorMode
		{
			Monochrome = 0,
			RGB = 1
		}

		public ColorMode Mode;

		public Vector3 InputL;

		public Vector3 InputR;

		public Vector3 InputG;

		public Vector3 InputB;

		public Vector2 OutputL;

		public Vector2 OutputR;

		public Vector2 OutputG;

		public Vector2 OutputB;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
