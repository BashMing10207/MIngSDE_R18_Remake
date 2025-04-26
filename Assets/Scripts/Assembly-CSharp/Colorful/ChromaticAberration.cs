using UnityEngine;

namespace Colorful
{
	[HelpURL("http://www.thomashourdel.com/colorful/doc/camera-effects/chromatic-aberration.html")]
	[AddComponentMenu("Colorful FX/Camera Effects/Chromatic Aberration")]
	[ExecuteInEditMode]
	public class ChromaticAberration : BaseEffect
	{
		[Range(0.9f, 1.1f)]
		[Tooltip("Indice of refraction for the red channel.")]
		public float RedRefraction;

		[Range(0.9f, 1.1f)]
		[Tooltip("Indice of refraction for the green channel.")]
		public float GreenRefraction;

		[Tooltip("Indice of refraction for the blue channel.")]
		[Range(0.9f, 1.1f)]
		public float BlueRefraction;

		[Tooltip("Enable this option if you need the effect to keep the alpha channel from the original render (some effects like Glow will need it). Disable it otherwise for better performances.")]
		public bool PreserveAlpha;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
