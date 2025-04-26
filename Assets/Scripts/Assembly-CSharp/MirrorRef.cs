using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class MirrorRef : MonoBehaviour
{
	private enum Dimension
	{
		Auto = 0,
		X256 = 0x100,
		X512 = 0x200,
		X1024 = 0x400
	}

	private class ReflectionData
	{
		public readonly RenderTexture[] texture;

		public MaterialPropertyBlock propertyBlock;
	}

	[Tooltip("Disables real-time pixel shaded point and spot lighting. Pixel shaded lights will fall-back to vertex lighting when this is enabled.")]
	public bool m_DisablePixelLights;

	[Tooltip("Disables occlusion culling on the mirror. Enable this if you see objects flickering in the mirror.")]
	public bool TurnOffMirrorOcclusion;

	[Tooltip("Only objects on the selected layers will be rendered in the mirror. Objects on the Water layer are never rendered in mirrors.")]
	public LayerMask m_ReflectLayers;

	[SerializeField]
	[Tooltip("Rendering resolution of the mirror (per eye in VR). Auto renders at the same resolution as the user's HMD or monitor up to the maximum.")]
	private Dimension mirrorResolution;

	[SerializeField]
	[Tooltip("The mirror will use this shader instead of the default shader if one is provided.")]
	private Shader customShader;

	private Dictionary<Camera, ReflectionData> _mReflections;

	private Camera mirrorCamera;

	private Skybox mirrorSkybox;

	private Matrix4x4 parentTransform;

	private Quaternion parentRotation;

	private int _playerLocalLayer;

	private static bool _sInsideRendering;

	private static readonly int[] _texturePropertyId;

	private const int MAX_AUTO_VR_RESOLUTION_WIDTH = 2048;

	private const int MAX_AUTO_VR_RESOLUTION_HEIGHT = 2048;

	private const int MAX_AUTO_DESKTOP_RESOLUTION_WIDTH = 2048;

	private const int MAX_AUTO_DESKTOP_RESOLUTION_HEIGHT = 2048;

	private void OnValidate()
	{
	}

	private void Start()
	{
	}

	public void OnWillRenderObject()
	{
	}

	public void CameraPostRender(Camera cam)
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private bool ShouldRenderMonoscopic(Camera cam)
	{
		return false;
	}

	private Vector3 GetNormalDirection()
	{
		return default(Vector3);
	}

	private void RenderMirror(RenderTexture targetTexture, Vector3 camPosition, Quaternion camRotation, Matrix4x4 camProjectionMatrix)
	{
	}

	private void UpdateCameraModes(Camera src)
	{
	}

	private void UpdateParentTransform(Camera cam)
	{
	}

	private ReflectionData GetReflectionData(Camera currentCamera)
	{
		return null;
	}

	private static void GetAutoResolution(Camera currentCamera, out int width, out int height)
	{
		width = default(int);
		height = default(int);
	}

	private static Vector4 Plane(Vector3 pos, Vector3 normal)
	{
		return default(Vector4);
	}

	private static Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal)
	{
		return default(Vector4);
	}

	private static Matrix4x4 CalculateReflectionMatrix(Vector4 plane)
	{
		return default(Matrix4x4);
	}

	private static float _copysign(float sizeval, float signval)
	{
		return 0f;
	}

	private static Quaternion GetRotation(Matrix4x4 matrix)
	{
		return default(Quaternion);
	}

	private static Vector3 GetPosition(Matrix4x4 matrix)
	{
		return default(Vector3);
	}
}
