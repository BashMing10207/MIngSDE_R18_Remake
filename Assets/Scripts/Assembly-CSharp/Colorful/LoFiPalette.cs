using UnityEngine;

namespace Colorful
{
	[HelpURL("http://www.thomashourdel.com/colorful/doc/artistic-effects/lofi-palette.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Artistic Effects/LoFi Palette")]
	public class LoFiPalette : LookupFilter3D
	{
		public enum Preset
		{
			None = 0,
			AmstradCPC = 2,
			CGA = 3,
			Commodore64 = 4,
			CommodorePlus = 5,
			EGA = 6,
			GameBoy = 7,
			MacOS16 = 8,
			MacOS256 = 9,
			MasterSystem = 10,
			RiscOS16 = 11,
			Teletex = 12,
			Windows16 = 13,
			Windows256 = 14,
			ZXSpectrum = 15,
			Andrae = 17,
			Anodomani = 18,
			Crayolo = 19,
			DB16 = 20,
			DB32 = 21,
			DJinn = 22,
			DrazileA = 23,
			DrazileB = 24,
			DrazileC = 25,
			Eggy = 26,
			FinlalA = 27,
			FinlalB = 28,
			Hapiel = 29,
			PavanzA = 30,
			PavanzB = 31,
			Peyton = 32,
			SpeedyCube = 33
		}

		public Preset Palette;

		[Tooltip("Pixelize the display.")]
		public bool Pixelize;

		[Tooltip("The display height in pixels.")]
		public float PixelSize;

		protected Preset m_CurrentPreset;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		protected override void RenderLut2D(RenderTexture source, RenderTexture destination)
		{
		}

		protected override void RenderLut3D(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
