using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(0, Pack = 8, Size = 16)]
	[CallbackIdentity(4525)]
	public struct HTML_UpdateToolTip_t
	{
		public const int k_iCallback = 4525;

		public HHTMLBrowser unBrowserHandle;

		public string pchMsg;
	}
}
