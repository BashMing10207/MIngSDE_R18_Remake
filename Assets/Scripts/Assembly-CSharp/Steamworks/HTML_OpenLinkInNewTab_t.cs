using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(0, Pack = 8, Size = 16)]
	[CallbackIdentity(4507)]
	public struct HTML_OpenLinkInNewTab_t
	{
		public const int k_iCallback = 4507;

		public HHTMLBrowser unBrowserHandle;

		public string pchURL;
	}
}
