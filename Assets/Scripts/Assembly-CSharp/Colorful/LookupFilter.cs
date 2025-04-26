using UnityEngine;

namespace Colorful
{
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/lookup-filter.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Color Correction/Lookup Filter (Deprecated)")]
	public class LookupFilter : BaseEffect
	{
		[Tooltip("The lookup texture to apply. Read the documentation to learn how to create one.")]
		public Texture LookupTexture;

		[Range(0f, 1f)]
		[Tooltip("Blending factor.")]
		public float Amount;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
