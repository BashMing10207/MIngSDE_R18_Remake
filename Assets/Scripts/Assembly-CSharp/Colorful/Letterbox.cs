using UnityEngine;

namespace Colorful
{
	[HelpURL("http://www.thomashourdel.com/colorful/doc/camera-effects/letterbox.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Camera Effects/Letterbox")]
	public class Letterbox : BaseEffect
	{
		[Tooltip("Crop the screen to the given aspect ratio.")]
		[Min(0f)]
		public float Aspect;

		[Tooltip("Letter/Pillar box color. Alpha is transparency.")]
		public Color FillColor;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
