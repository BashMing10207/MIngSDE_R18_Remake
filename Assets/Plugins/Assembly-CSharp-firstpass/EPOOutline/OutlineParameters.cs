using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace EPOOutline
{
	public class OutlineParameters
	{
		public readonly MeshPool MeshPool;

		public Camera Camera;

		public RenderTargetIdentifier Target;

		public RenderTargetIdentifier DepthTarget;

		public CommandBuffer Buffer;

		public DilateQuality DilateQuality;

		public int DilateIterations;

		public int BlurIterations;

		public long OutlineLayerMask;

		public int TargetWidth;

		public int TargetHeight;

		public float BlurShift;

		public float DilateShift;

		public bool UseHDR;

		public bool UseInfoBuffer;

		public bool IsEditorCamera;

		public float PrimaryBufferScale;

		public float InfoBufferScale;

		public bool ScaleIndependent;

		public StereoTargetEyeMask EyeMask;

		public int Antialiasing;

		public BlurType BlurType;

		public LayerMask Mask;

		public Mesh BlitMesh;

		public List<Outlinable> OutlinablesToRender;

		private bool isInitialized;

		public void CheckInitialization()
		{
		}

		public void Prepare()
		{
		}

		private bool AreEqual(Outlinable first, Outlinable second)
		{
			return false;
		}

		private bool AreEqualToSelf(Outlinable first)
		{
			return false;
		}
	}
}
