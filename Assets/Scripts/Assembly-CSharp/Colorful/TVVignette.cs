using UnityEngine;

namespace Colorful
{
	[HelpURL("http://www.thomashourdel.com/colorful/doc/camera-effects/tv-vignette.html")]
	[AddComponentMenu("Colorful FX/Camera Effects/TV Vignette")]
	[ExecuteInEditMode]
	public class TVVignette : BaseEffect
	{
		[Min(0f)]
		public float Size;

		[Range(0f, 1f)]
		public float Offset;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
