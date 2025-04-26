using UnityEngine;

namespace Colorful
{
	[AddComponentMenu("Colorful FX/Camera Effects/Analog TV")]
	[ExecuteInEditMode]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/camera-effects/analog-tv.html")]
	public class AnalogTV : BaseEffect
	{
		[Tooltip("Automatically animate the Phase value.")]
		public bool AutomaticPhase;

		[Tooltip("Current noise phase. Consider this a seed value.")]
		public float Phase;

		[Tooltip("Convert the original render to black & white.")]
		public bool ConvertToGrayscale;

		[Range(0f, 1f)]
		[Tooltip("Noise brightness. Will impact the scanlines visibility.")]
		public float NoiseIntensity;

		[Range(0f, 10f)]
		[Tooltip("Scanline brightness. Depends on the NoiseIntensity value.")]
		public float ScanlinesIntensity;

		[Range(0f, 4096f)]
		[Tooltip("The number of scanlines to draw.")]
		public int ScanlinesCount;

		[Tooltip("Scanline offset. Gives a cool screen scanning effect when animated.")]
		public float ScanlinesOffset;

		[Tooltip("Uses vertical scanlines.")]
		public bool VerticalScanlines;

		[Range(-2f, 2f)]
		[Tooltip("Spherical distortion factor.")]
		public float Distortion;

		[Range(-2f, 2f)]
		[Tooltip("Cubic distortion factor.")]
		public float CubicDistortion;

		[Range(0.01f, 2f)]
		[Tooltip("Helps avoid screen streching on borders when working with heavy distortions.")]
		public float Scale;

		protected virtual void Update()
		{
		}

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
