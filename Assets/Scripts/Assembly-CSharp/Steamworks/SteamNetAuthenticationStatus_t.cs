using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(0, Pack = 8, Size = 260)]
	[CallbackIdentity(1222)]
	public struct SteamNetAuthenticationStatus_t
	{
		public const int k_iCallback = 1222;

		public ESteamNetworkingAvailability m_eAvail;

		private byte[] m_debugMsg_;

		public string m_debugMsg
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
