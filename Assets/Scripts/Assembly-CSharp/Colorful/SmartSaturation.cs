using UnityEngine;

namespace Colorful
{
	[ExecuteInEditMode]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/smart-saturation.html")]
	[AddComponentMenu("Colorful FX/Color Correction/Smart Saturation")]
	public class SmartSaturation : BaseEffect
	{
		[Tooltip("Saturation boost. Default: 1 (no boost).")]
		[Range(0f, 2f)]
		public float Boost;

		public AnimationCurve Curve;

		private Texture2D _CurveTexture;

		protected Texture2D m_CurveTexture => null;

		protected virtual void Reset()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		public virtual void UpdateCurve()
		{
		}

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
