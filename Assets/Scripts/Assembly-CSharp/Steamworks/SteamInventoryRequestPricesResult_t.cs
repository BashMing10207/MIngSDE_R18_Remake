using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(0, Pack = 8, Size = 8)]
	[CallbackIdentity(4705)]
	public struct SteamInventoryRequestPricesResult_t
	{
		public const int k_iCallback = 4705;

		public EResult m_result;

		private byte[] m_rgchCurrency_;

		public string m_rgchCurrency
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
