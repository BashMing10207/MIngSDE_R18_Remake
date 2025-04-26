using UnityEngine;

namespace Colorful
{
	[HelpURL("http://www.thomashourdel.com/colorful/doc/other-effects/noise.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Other Effects/Noise")]
	public class Noise : BaseEffect
	{
		public enum ColorMode
		{
			Monochrome = 0,
			RGB = 1
		}

		[Tooltip("Black & white or colored noise.")]
		public ColorMode Mode;

		[Tooltip("Automatically increment the seed to animate the noise.")]
		public bool Animate;

		[Tooltip("A number used to initialize the noise generator.")]
		public float Seed;

		[Range(0f, 1f)]
		[Tooltip("Strength used to apply the noise. 0 means no noise at all, 1 is full noise.")]
		public float Strength;

		[Range(0f, 1f)]
		[Tooltip("Reduce the noise visibility in luminous areas.")]
		public float LumContribution;

		protected virtual void Update()
		{
		}

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
