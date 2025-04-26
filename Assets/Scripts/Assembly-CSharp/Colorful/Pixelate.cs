using UnityEngine;

namespace Colorful
{
	[HelpURL("http://www.thomashourdel.com/colorful/doc/other-effects/pixelate.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Other Effects/Pixelate")]
	public class Pixelate : BaseEffect
	{
		public enum SizeMode
		{
			ResolutionIndependent = 0,
			PixelPerfect = 1
		}

		[Tooltip("Scale of an individual pixel. Depends on the Mode used.")]
		[Range(1f, 1024f)]
		public float Scale;

		[Tooltip("Turn this on to automatically compute the aspect ratio needed for squared pixels.")]
		public bool AutomaticRatio;

		[Tooltip("Custom aspect ratio.")]
		public float Ratio;

		[Tooltip("Used for the Scale field.")]
		public SizeMode Mode;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
