using System;
using System.Collections.Generic;
using UnityEngine;

namespace EPOOutline
{
	[ExecuteAlways]
	public class Outlinable : MonoBehaviour
	{
		[Serializable]
		public class OutlineProperties
		{
			[SerializeField]
			private bool enabled;

			[SerializeField]
			private Color color;

			[SerializeField]
			[Range(0f, 1f)]
			private float dilateShift;

			[SerializeField]
			[Range(0f, 1f)]
			private float blurShift;

			[SerializeField]
			[SerializedPassInfo("Fill style", "Hidden/EPO/Fill/")]
			private SerializedPass fillPass;

			public bool Enabled
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public Color Color
			{
				get
				{
					return default(Color);
				}
				set
				{
				}
			}

			public float DilateShift
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public float BlurShift
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public SerializedPass FillPass => null;
		}

		private static HashSet<Outlinable> outlinables;

		private static Plane[] frustrumPlanes;

		[SerializeField]
		private bool complexMaskingEnabled;

		[SerializeField]
		private OutlinableDrawingMode drawingMode;

		[SerializeField]
		private int outlineLayer;

		public List<OutlineTarget> outlineTargets;

		[SerializeField]
		private RenderStyle renderStyle;

		[SerializeField]
		private OutlineProperties outlineParameters;

		[SerializeField]
		private OutlineProperties backParameters;

		[SerializeField]
		private OutlineProperties frontParameters;

		public RenderStyle RenderStyle
		{
			get
			{
				return default(RenderStyle);
			}
			set
			{
			}
		}

		public bool ComplexMaskingEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public OutlinableDrawingMode DrawingMode
		{
			get
			{
				return default(OutlinableDrawingMode);
			}
			set
			{
			}
		}

		public int OutlineLayer
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public List<OutlineTarget> OutlineTargets => null;

		public OutlineProperties OutlineParameters => null;

		public OutlineProperties BackParameters => null;

		public OutlineProperties FrontParameters => null;

		public bool IsObstacle => false;

		private bool IsVisible(Plane[] planes)
		{
			return false;
		}

		private void Reset()
		{
		}

		private void OnValidate()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public static void GetAllActiveOutlinables(Camera camera, List<Outlinable> outlinablesList)
		{
		}

		private int GetSubmeshCount(Renderer renderer)
		{
			return 0;
		}

		public void AddAllChildRenderersToRenderingList(RenderersAddingMode renderersAddingMode = RenderersAddingMode.All)
		{
		}

		private bool MatchingMode(Renderer renderer, RenderersAddingMode mode)
		{
			return false;
		}
	}
}
