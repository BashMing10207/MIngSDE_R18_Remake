using UnityEngine;

namespace Colorful
{
	[ExecuteInEditMode]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/camera-effects/contrast-vignette.html")]
	[AddComponentMenu("Colorful FX/Camera Effects/Contrast Vignette")]
	public class ContrastVignette : BaseEffect
	{
		[Tooltip("Center point.")]
		public Vector2 Center;

		[Range(-100f, 100f)]
		[Tooltip("Smoothness of the vignette effect.")]
		public float Sharpness;

		[Range(0f, 100f)]
		[Tooltip("Amount of vignetting on screen.")]
		public float Darkness;

		[Tooltip("Expands or shrinks the overall range of tonal values in the vignette area.")]
		[Range(0f, 200f)]
		public float Contrast;

		public Vector3 ContrastCoeff;

		[Range(0f, 200f)]
		[Tooltip("Blends the contrast change toward the edges of the vignette effect.")]
		public float EdgeBlending;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
