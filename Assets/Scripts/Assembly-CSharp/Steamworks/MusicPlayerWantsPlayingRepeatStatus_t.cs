using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(0, Pack = 8, Size = 4)]
	[CallbackIdentity(4114)]
	public struct MusicPlayerWantsPlayingRepeatStatus_t
	{
		public const int k_iCallback = 4114;

		public int m_nPlayingRepeatStatus;
	}
}
