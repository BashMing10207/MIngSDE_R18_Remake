using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(0, Size = 1)]
	[CallbackIdentity(5001)]
	public struct SteamParentalSettingsChanged_t
	{
		public const int k_iCallback = 5001;
	}
}
