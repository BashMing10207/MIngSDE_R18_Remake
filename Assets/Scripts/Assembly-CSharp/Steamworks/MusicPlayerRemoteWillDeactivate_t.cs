using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(0, Pack = 8, Size = 1)]
	[CallbackIdentity(4102)]
	public struct MusicPlayerRemoteWillDeactivate_t
	{
		public const int k_iCallback = 4102;
	}
}
