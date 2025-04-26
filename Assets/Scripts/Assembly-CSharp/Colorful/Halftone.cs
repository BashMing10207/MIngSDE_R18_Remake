using UnityEngine;

namespace Colorful
{
	[AddComponentMenu("Colorful FX/Artistic Effects/Halftone")]
	[ExecuteInEditMode]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/artistic-effects/halftone.html")]
	public class Halftone : BaseEffect
	{
		[Min(0f)]
		[Tooltip("Global haltfoning scale.")]
		public float Scale;

		[Tooltip("Individual dot size.")]
		[Min(0f)]
		public float DotSize;

		[Tooltip("Rotates the dot placement according to the Center point.")]
		public float Angle;

		[Tooltip("Dots antialiasing")]
		[Range(0f, 1f)]
		public float Smoothness;

		[Tooltip("Center point to use for the rotation.")]
		public Vector2 Center;

		[Tooltip("Turns the effect black & white.")]
		public bool Desaturate;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		private Vector4 CMYKRot(float angle)
		{
			return default(Vector4);
		}
	}
}
