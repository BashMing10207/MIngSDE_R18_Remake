using UnityEngine;

namespace Colorful
{
	[AddComponentMenu("Colorful FX/Color Correction/Vintage")]
	[ExecuteInEditMode]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/vintage-fast.html")]
	public class VintageFast : LookupFilter3D
	{
		public Vintage.InstragramFilter Filter;

		protected Vintage.InstragramFilter m_CurrentFilter;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
