using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(0, Pack = 8, Size = 40)]
	[CallbackIdentity(4503)]
	public struct HTML_StartRequest_t
	{
		public const int k_iCallback = 4503;

		public HHTMLBrowser unBrowserHandle;

		public string pchURL;

		public string pchTarget;

		public string pchPostData;

		public bool bIsRedirect;
	}
}
