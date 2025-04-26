using UnityEngine;

namespace Colorful
{
	[HelpURL("http://www.thomashourdel.com/colorful/doc/camera-effects/double-vision.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Camera Effects/Double Vision")]
	public class DoubleVision : BaseEffect
	{
		[Tooltip("Diploplia strength.")]
		public Vector2 Displace;

		[Tooltip("Blending factor.")]
		[Range(0f, 1f)]
		public float Amount;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
