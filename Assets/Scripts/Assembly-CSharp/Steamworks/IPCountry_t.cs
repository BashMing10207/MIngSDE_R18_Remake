using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(0, Pack = 8, Size = 1)]
	[CallbackIdentity(701)]
	public struct IPCountry_t
	{
		public const int k_iCallback = 701;
	}
}
