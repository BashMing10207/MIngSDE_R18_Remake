using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(0, Pack = 8, Size = 24)]
	[CallbackIdentity(1327)]
	public struct RemoteStorageSetUserPublishedFileActionResult_t
	{
		public const int k_iCallback = 1327;

		public EResult m_eResult;

		public PublishedFileId_t m_nPublishedFileId;

		public EWorkshopFileAction m_eAction;
	}
}
