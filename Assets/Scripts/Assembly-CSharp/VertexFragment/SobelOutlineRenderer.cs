using UnityEngine.Rendering.PostProcessing;

namespace VertexFragment
{
	public sealed class SobelOutlineRenderer : PostProcessEffectRenderer<SobelOutline>
	{
		public const string SobelShader = "Aihasto/SobelOutlineCg";

		public override void Render(PostProcessRenderContext context)
		{
		}
	}
}
