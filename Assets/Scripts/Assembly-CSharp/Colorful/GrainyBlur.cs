using UnityEngine;

namespace Colorful
{
	[HelpURL("http://www.thomashourdel.com/colorful/doc/blur-effects/grainy-blur.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Blur Effects/Grainy Blur")]
	public class GrainyBlur : BaseEffect
	{
		[Min(0f)]
		[Tooltip("Blur radius.")]
		public float Radius;

		[Range(1f, 32f)]
		[Tooltip("Sample count. Higher means better quality but slower processing.")]
		public int Samples;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
