using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(0, Pack = 8, Size = 1)]
	[CallbackIdentity(4101)]
	public struct MusicPlayerRemoteWillActivate_t
	{
		public const int k_iCallback = 4101;
	}
}
