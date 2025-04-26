using UnityEngine;

namespace Colorful
{
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/channel-clamper.html")]
	[AddComponentMenu("Colorful FX/Color Correction/Channel Clamper")]
	[ExecuteInEditMode]
	public class ChannelClamper : BaseEffect
	{
		public Vector2 Red;

		public Vector2 Green;

		public Vector2 Blue;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
