using UnityEngine;

namespace RealToon.Effects
{
	[ImageEffectAllowedInSceneView]
	[AddComponentMenu("RealToon/Effects/Sobel Outline")]
	[ExecuteInEditMode]
	public class RealToonSobelOutline : MonoBehaviour
	{
		[Range(0f, 1f)]
		[Space(10f)]
		[Header("(RealToon Sobel Outline V1.0.1)")]
		public float OutlineWidth;

		[Tooltip("Note:Set this to white if you want to use the color of the image.")]
		public Color OutlineColor;

		[Tooltip("How strong is the outline color")]
		public float ColorPower;

		[Space(10f)]
		[Header("(Experimental)")]
		[Tooltip("[Experimental] Which layer/s should not be included")]
		public LayerMask excludeLayers;

		private GameObject tmpCam;

		private Camera _camera;

		[HideInInspector]
		public Material _material;

		private GameObject go;

		private bool destroy;

		private void OnEnable()
		{
		}

		private void Reset()
		{
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		private Camera GetTmpCam()
		{
			return null;
		}
	}
}
