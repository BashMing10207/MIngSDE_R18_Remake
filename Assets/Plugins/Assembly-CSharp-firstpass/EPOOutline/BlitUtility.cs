using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace EPOOutline
{
	public static class BlitUtility
	{
		private static readonly int MainTexHash;

		private static Vector3[] vertices;

		private static Vector4[] matrix;

		private static Vector3[] tempVector3;

		private static Vector2[] tempVector2;

		private static int[] trianglesToAdd;

		private static Vector3[] normals;

		private static int[] triangles;

		private static List<Vector4> firstUV;

		private static List<Vector4> secondUV;

		private static List<Vector4> thirdUV;

		private static List<Vector4> fourthUV;

		private static List<Vector3> centers;

		private static List<Vector3> size;

		private static List<Vector3> stages;

		private static List<Vector2> additionalScale;

		private static List<Vector3> addedVertices;

		public static List<int> addedTriangles;

		public static List<Vector3> addedNormals;

		private static void UpdateBounds(Renderer renderer)
		{
		}

		public static void SetupMesh(OutlineParameters parameters, float baseShift)
		{
		}

		public static void Blit(OutlineParameters parameters, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderTargetIdentifier destinationDepth, Material material, CommandBuffer targetBuffer, int pass = -1)
		{
		}

		public static void Draw(OutlineParameters parameters, RenderTargetIdentifier target, RenderTargetIdentifier depth, Material material)
		{
		}
	}
}
