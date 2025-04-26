using UnityEngine;

namespace Colorful
{
	[AddComponentMenu("Colorful FX/Other Effects/Convolution Matrix 3x3")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/other-effects/convolution-3x3.html")]
	[ExecuteInEditMode]
	public class Convolution3x3 : BaseEffect
	{
		public Vector3 KernelTop;

		public Vector3 KernelMiddle;

		public Vector3 KernelBottom;

		[Tooltip("Used to normalize the kernel.")]
		public float Divisor;

		[Range(0f, 1f)]
		[Tooltip("Blending factor.")]
		public float Amount;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
