using UnityEngine;

namespace Colorful
{
	[AddComponentMenu("Colorful FX/Color Correction/Channel Swapper")]
	[ExecuteInEditMode]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/channel-swapper.html")]
	public class ChannelSwapper : BaseEffect
	{
		public enum Channel
		{
			Red = 0,
			Green = 1,
			Blue = 2
		}

		[Tooltip("Source channel to use for the output red channel.")]
		public Channel RedSource;

		[Tooltip("Source channel to use for the output green channel.")]
		public Channel GreenSource;

		[Tooltip("Source channel to use for the output blue channel.")]
		public Channel BlueSource;

		private static Vector4[] m_Channels;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
