using UnityEngine;

namespace Colorful
{
	[AddComponentMenu("Colorful FX/Color Correction/Channel Mixer")]
	[ExecuteInEditMode]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/channel-mixer.html")]
	public class ChannelMixer : BaseEffect
	{
		public Vector3 Red;

		public Vector3 Green;

		public Vector3 Blue;

		public Vector3 Constant;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
