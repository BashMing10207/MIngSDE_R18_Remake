using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(0, Pack = 4, Size = 140)]
	[CallbackIdentity(202)]
	public struct GSClientDeny_t
	{
		public const int k_iCallback = 202;

		public CSteamID m_SteamID;

		public EDenyReason m_eDenyReason;

		private byte[] m_rgchOptionalText_;

		public string m_rgchOptionalText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
