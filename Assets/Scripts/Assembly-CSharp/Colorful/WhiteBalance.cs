using UnityEngine;

namespace Colorful
{
	[AddComponentMenu("Colorful FX/Color Correction/White Balance")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/white-balance.html")]
	[ExecuteInEditMode]
	public class WhiteBalance : BaseEffect
	{
		public enum BalanceMode
		{
			Simple = 0,
			Complex = 1
		}

		[Tooltip("Reference white point or midtone value.")]
		[ColorUsage(false)]
		public Color White;

		[Tooltip("Algorithm used.")]
		public BalanceMode Mode;

		protected virtual void Reset()
		{
		}

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
