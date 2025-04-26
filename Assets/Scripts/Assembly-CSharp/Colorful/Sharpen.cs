using UnityEngine;

namespace Colorful
{
	[ExecuteInEditMode]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/other-effects/sharpen.html")]
	[AddComponentMenu("Colorful FX/Other Effects/Sharpen")]
	public class Sharpen : BaseEffect
	{
		public enum Algorithm
		{
			TypeA = 0,
			TypeB = 1
		}

		[Tooltip("Sharpening algorithm to use.")]
		public Algorithm Mode;

		[Tooltip("Sharpening Strength.")]
		[Range(0f, 5f)]
		public float Strength;

		[Range(0f, 1f)]
		[Tooltip("Limits the amount of sharpening a pixel will receive.")]
		public float Clamp;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
