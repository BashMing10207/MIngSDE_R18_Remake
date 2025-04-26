using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace VertexFragment
{
	[PostProcess(typeof(SobelOutlineRenderer), PostProcessEvent.BeforeStack, "SobelOutline", true)]
	public class SobelOutline : PostProcessEffectSettings
	{
		public Shader shaderOutline;

		[Tooltip("Thickness of the Sobel Outline")]
		public FloatParameter thickness;

		[Tooltip("Multiplier of the Depth-Component of the Sobel Outline")]
		public FloatParameter depthMultiplier;

		[Tooltip("Bias of the Depth-Component of the Sobel Outline")]
		public FloatParameter depthBias;

		[Tooltip("Multiplier of the Normal-Component of the Sobel Outline")]
		public FloatParameter normalMultiplier;

		[Tooltip("Bias of the Normal-Component of the Sobel Outline")]
		public FloatParameter normalBias;

		[Tooltip("Color of the Sobel Outline")]
		public ColorParameter color;
	}
}
