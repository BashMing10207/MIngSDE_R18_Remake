using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(0, Pack = 8, Size = 8)]
	[CallbackIdentity(1202)]
	public struct P2PSessionRequest_t
	{
		public const int k_iCallback = 1202;

		public CSteamID m_steamIDRemote;
	}
}
