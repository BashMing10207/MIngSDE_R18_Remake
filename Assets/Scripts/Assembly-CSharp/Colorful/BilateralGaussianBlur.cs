using System;
using UnityEngine;

namespace Colorful
{
	[HelpURL("http://www.thomashourdel.com/colorful/doc/blur-effects/bilateral-gaussian-blur.html")]
	[AddComponentMenu("Colorful FX/Blur Effects/Bilateral Gaussian Blur")]
	[ExecuteInEditMode]
	public class BilateralGaussianBlur : BaseEffect
	{
		[Tooltip("Add more passes to get a smoother blur. Beware that each pass will slow down the effect.")]
		[Range(0f, 10f)]
		public int Passes;

		[Range(0.04f, 1f)]
		[Tooltip("Adjusts the blur \"sharpness\" around edges")]
		public float Threshold;

		[Tooltip("Blending factor.")]
		[Range(0f, 1f)]
		public float Amount;

		[Obsolete]
		protected override void Start()
		{
		}

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		protected virtual void OnePassBlur(RenderTexture source, RenderTexture destination)
		{
		}

		protected virtual void MultiPassBlur(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
