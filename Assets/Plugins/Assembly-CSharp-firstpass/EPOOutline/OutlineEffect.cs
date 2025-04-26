using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace EPOOutline
{
	public static class OutlineEffect
	{
		private struct OutlineTargetGroup
		{
			public readonly Outlinable Outlinable;

			public readonly OutlineTarget Target;

			public OutlineTargetGroup(Outlinable outlinable, OutlineTarget target)
			{
				Outlinable = null;
				Target = null;
			}
		}

		private static int FillRefHash;

		private static int DilateShiftHash;

		private static int ColorMaskHash;

		private static int OutlineRefHash;

		private static int RefHash;

		private static int ZWriteHash;

		private static int EffectSizeHash;

		private static int CullHash;

		private static int ZTestHash;

		private static int ColorHash;

		private static int ShiftHash;

		private static int InitialTexHash;

		private static int InfoBufferHash;

		private static int ComparisonHash;

		private static int ReadMaskHash;

		private static int WriteMaskHash;

		private static int OperationHash;

		private static int CutoutThresholdHash;

		private static int TextureIndexHash;

		private static int CutoutTextureHash;

		private static int CutoutTextureSTHash;

		private static int SrcBlendHash;

		private static int DstBlendHash;

		private static int TargetHash;

		private static int InfoTargetHash;

		private static int PrimaryBufferHash;

		private static int HelperBufferHash;

		private static int PrimaryInfoBufferHash;

		private static int HelperInfoBufferHash;

		private static Material TransparentBlitMaterial;

		private static Material EmptyFillMaterial;

		private static Material OutlineMaterial;

		private static Material PartialBlitMaterial;

		private static Material ObstacleMaterial;

		private static Material FillMaskMaterial;

		private static Material ZPrepassMaterial;

		private static Material OutlineMaskMaterial;

		private static Material DilateMaterial;

		private static Material EdgeDilateMaterial;

		private static Material BlurMaterial;

		private static Material FinalBlitMaterial;

		private static Material BasicBlitMaterial;

		private static Material ClearStencilMaterial;

		private static List<OutlineTargetGroup> targets;

		private static List<string> keywords;

		public static Material LoadMaterial(string shaderName)
		{
			return null;
		}

		private static void InitMaterials()
		{
		}

		private static void Postprocess(OutlineParameters parameters, float shiftScale, bool scaleIndependent, float bufferScale, int first, int second, Material material, int iterrations, bool additionalShift, float shiftValue, ref int stencil)
		{
		}

		private static void Blit(OutlineParameters parameters, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderTargetIdentifier destinationDepth, Material material, float effectSize, CommandBuffer buffer, int pass = -1)
		{
		}

		private static float GetBlurShift(BlurType blurType, int iterrationsCount)
		{
			return 0f;
		}

		private static float ComputeEffectShift(OutlineParameters parameters)
		{
			return 0f;
		}

		private static void PrepareTargets(OutlineParameters parameters)
		{
		}

		public static void SetupOutline(OutlineParameters parameters)
		{
		}

		private static void SetupDilateKeyword(OutlineParameters parameters)
		{
		}

		private static void SetupBlurKeyword(OutlineParameters parameters)
		{
		}

		private static int DrawOutlineables(OutlineParameters parameters, CompareFunction function, bool edgeShiftOnly, float shift, Func<Outlinable, bool> shouldRender, Func<Outlinable, Color> colorProvider, Func<Outlinable, Material> materialProvider, RenderStyle styleMask, OutlinableDrawingMode modeMask = OutlinableDrawingMode.Normal)
		{
			return 0;
		}

		private static void DrawFill(OutlineParameters parameters, RenderTargetIdentifier targetSurfance)
		{
		}

		private static void SetupCutout(OutlineParameters parameters, OutlineTarget target)
		{
		}

		private static void SetupCull(OutlineParameters parameters, OutlineTarget target)
		{
		}
	}
}
