using UnityEngine;

namespace Colorful
{
	[HelpURL("http://www.thomashourdel.com/colorful/doc/camera-effects/frost.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Camera Effects/Frost")]
	public class Frost : BaseEffect
	{
		[Tooltip("Frosting strength.")]
		[Range(0f, 16f)]
		public float Scale;

		[Tooltip("Smoothness of the vignette effect.")]
		[Range(-100f, 100f)]
		public float Sharpness;

		[Tooltip("Amount of vignetting on screen.")]
		[Range(0f, 100f)]
		public float Darkness;

		[Tooltip("Should the effect be applied like a vignette ?")]
		public bool EnableVignette;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
