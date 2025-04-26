using System;
using UnityEngine;

namespace Colorful
{
	[AddComponentMenu("Colorful FX/Color Correction/Gradient Ramp (Dynamic)")]
	[ExecuteInEditMode]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/gradient-ramp-dynamic.html")]
	public class GradientRampDynamic : BaseEffect
	{
		[Tooltip("Gradient used to remap the pixels luminosity.")]
		public Gradient Ramp;

		[Tooltip("Blending factor.")]
		[Range(0f, 1f)]
		public float Amount;

		protected Texture2D m_RampTexture;

		[Obsolete]
		protected override void Start()
		{
		}

		protected virtual void Reset()
		{
		}

		public void UpdateGradientCache()
		{
		}

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
