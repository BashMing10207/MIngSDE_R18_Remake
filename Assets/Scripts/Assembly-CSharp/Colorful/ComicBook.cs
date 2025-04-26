using UnityEngine;

namespace Colorful
{
	[HelpURL("http://www.thomashourdel.com/colorful/doc/artistic-effects/comic-book.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Artistic Effects/Comic Book")]
	public class ComicBook : BaseEffect
	{
		[Tooltip("Strip orientation in radians.")]
		public float StripAngle;

		[Tooltip("Amount of strips to draw.")]
		[Min(0f)]
		public float StripDensity;

		[Tooltip("Thickness of the inner strip fill.")]
		[Range(0f, 1f)]
		public float StripThickness;

		public Vector2 StripLimits;

		[ColorUsage(false)]
		public Color StripInnerColor;

		[ColorUsage(false)]
		public Color StripOuterColor;

		[ColorUsage(false)]
		public Color FillColor;

		[ColorUsage(false)]
		public Color BackgroundColor;

		[Tooltip("Toggle edge detection (slower).")]
		public bool EdgeDetection;

		[Min(0.01f)]
		[Tooltip("Edge detection threshold. Use lower values for more visible edges.")]
		public float EdgeThreshold;

		[ColorUsage(false)]
		public Color EdgeColor;

		[Tooltip("Blending factor.")]
		[Range(0f, 1f)]
		public float Amount;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
