using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(0, Pack = 8, Size = 16)]
	[CallbackIdentity(1315)]
	public struct RemoteStorageUnsubscribePublishedFileResult_t
	{
		public const int k_iCallback = 1315;

		public EResult m_eResult;

		public PublishedFileId_t m_nPublishedFileId;
	}
}
