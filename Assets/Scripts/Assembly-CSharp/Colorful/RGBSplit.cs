using UnityEngine;

namespace Colorful
{
	[HelpURL("http://www.thomashourdel.com/colorful/doc/camera-effects/rgb-split.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Camera Effects/RGB Split")]
	public class RGBSplit : BaseEffect
	{
		[Tooltip("RGB shifting amount.")]
		public float Amount;

		[Tooltip("Shift direction in radians.")]
		public float Angle;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
