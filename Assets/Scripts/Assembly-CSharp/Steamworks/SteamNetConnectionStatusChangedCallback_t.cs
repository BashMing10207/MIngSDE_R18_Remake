using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(0, Pack = 8, Size = 712)]
	[CallbackIdentity(1221)]
	public struct SteamNetConnectionStatusChangedCallback_t
	{
		public const int k_iCallback = 1221;

		public HSteamNetConnection m_hConn;

		public SteamNetConnectionInfo_t m_info;

		public ESteamNetworkingConnectionState m_eOldState;
	}
}
