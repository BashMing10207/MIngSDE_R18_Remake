using UnityEngine;

namespace Colorful
{
	[HelpURL("http://www.thomashourdel.com/colorful/doc/camera-effects/wave-distortion.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Camera Effects/Wave Distortion")]
	public class WaveDistortion : BaseEffect
	{
		[Tooltip("Wave amplitude.")]
		[Range(0f, 1f)]
		public float Amplitude;

		[Tooltip("Amount of waves.")]
		public float Waves;

		[Tooltip("Amount of color shifting.")]
		[Range(0f, 5f)]
		public float ColorGlitch;

		[Tooltip("Distortion state. Think of it as a bell curve going from 0 to 1, with 0.5 being the highest point.")]
		public float Phase;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
