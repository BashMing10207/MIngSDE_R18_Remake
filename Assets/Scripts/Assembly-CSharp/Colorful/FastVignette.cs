using UnityEngine;

namespace Colorful
{
	[AddComponentMenu("Colorful FX/Camera Effects/Fast Vignette")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/camera-effects/fast-vignette.html")]
	[ExecuteInEditMode]
	public class FastVignette : BaseEffect
	{
		public enum ColorMode
		{
			Classic = 0,
			Desaturate = 1,
			Colored = 2
		}

		[Tooltip("Vignette type.")]
		public ColorMode Mode;

		[ColorUsage(false)]
		[Tooltip("The color to use in the vignette area.")]
		public Color Color;

		[Tooltip("Center point.")]
		public Vector2 Center;

		[Range(-100f, 100f)]
		[Tooltip("Smoothness of the vignette effect.")]
		public float Sharpness;

		[Range(0f, 100f)]
		[Tooltip("Amount of vignetting on screen.")]
		public float Darkness;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
