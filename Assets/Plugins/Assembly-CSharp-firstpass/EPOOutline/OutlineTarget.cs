using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace EPOOutline
{
	[Serializable]
	public class OutlineTarget
	{
		[SerializeField]
		private float edgeDilateAmount;

		[SerializeField]
		private float frontEdgeDilateAmount;

		[SerializeField]
		private float backEdgeDilateAmount;

		[SerializeField]
		public Renderer Renderer;

		[SerializeField]
		public int SubmeshIndex;

		[SerializeField]
		public BoundsMode BoundsMode;

		[SerializeField]
		public Bounds Bounds;

		[SerializeField]
		public CutoutDescriptionType CutoutDescriptionType;

		[Range(0f, 1f)]
		[SerializeField]
		public float CutoutThreshold;

		[SerializeField]
		public CullMode CullMode;

		[SerializeField]
		private string cutoutTextureName;

		[SerializeField]
		public DilateRenderMode DilateRenderingMode;

		[SerializeField]
		private int cutoutTextureIndex;

		private int? cutoutTextureId;

		public bool UsesCutout => false;

		public int CutoutTextureIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool CanUseEdgeDilateShift => false;

		public int ShiftedSubmeshIndex => 0;

		public int CutoutTextureId => 0;

		public string CutoutTextureName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float EdgeDilateAmount
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float FrontEdgeDilateAmount
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float BackEdgeDilateAmount
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public OutlineTarget()
		{
		}

		public OutlineTarget(Renderer renderer, int submesh = 0)
		{
		}

		public OutlineTarget(Renderer renderer, string cutoutTextureName, float cutoutThreshold = 0.5f)
		{
		}
	}
}
