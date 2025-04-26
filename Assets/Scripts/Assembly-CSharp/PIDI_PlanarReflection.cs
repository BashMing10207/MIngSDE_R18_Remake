using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
[ExecuteInEditMode]
public class PIDI_PlanarReflection : MonoBehaviour
{
	public struct ReflectionCamera
	{
		public Camera reflector;

		public Camera source;

		public PIDI_PlanarReflection owner;

		public ReflectionCamera(Camera v_ref, Camera v_source, PIDI_PlanarReflection v_owner)
		{
			reflector = null;
			source = null;
			owner = null;
		}
	}

	private static ReflectionCamera[] v_reflectionPool;

	private List<ReflectionCamera> v_reflectionCameras;

	public RenderingPath v_renderingPath;

	public RenderTexture v_staticTexture;

	public bool b_displayGizmos;

	public bool b_updateInEditMode;

	public bool b_useFixedUptade;

	public bool b_ignoreSkybox;

	public Color v_backdropColor;

	public int v_timesPerSecond;

	public bool b_useGlobalSettings;

	public static int v_maxResolution;

	public static int v_forcedQualityDowngrade;

	public bool b_useExplicitCameras;

	public bool b_useExplicitNormal;

	public Vector3 v_explicitNormal;

	public Shader depthShader;

	public bool b_forcePower2;

	public bool b_useScreenResolution;

	public bool b_useDynamicResolution;

	public int v_dynRes;

	public float v_resMultiplier;

	public Vector2 v_minMaxDistance;

	public bool b_useReflectionsPool;

	public int v_poolSize;

	public float v_disableOnDistance;

	public Vector2 v_resolution;

	private Vector2 v_oldRes;

	public int v_pixelLights;

	public LayerMask v_reflectLayers;

	public bool b_simplifyLandscapes;

	public int v_agressiveness;

	public float v_shadowDistance;

	public float v_clippingOffset;

	public float v_nearClipModifier;

	public float v_farClipModifier;

	public bool b_safeClipping;

	public bool b_realOblique;

	public Vector2 v_mirrorSize;

	public RenderTexture v_oldRend;

	public RenderTexture v_oldDepth;

	private float v_nextUpdate;

	private Vector3 v_surfaceNormal;

	private static bool b_isRendering;

	private RenderTexture v_refTexture;

	private float v_oldDistance;

	private float v_distance;

	private Camera v_reflectionCam;

	private Camera v_srcCamera;

	private bool b_oldUsePool;

	private bool b_willRender;

	public Mesh v_defaultMesh;

	public Material v_defaultMat;

	[SerializeField]
	private Material v_matInstance;

	public void OnEnable()
	{
	}

	public void Update()
	{
	}

	public void OnWillRenderObject()
	{
	}

	public void OnWillRenderObject(Camera withCamera)
	{
	}

	public void OnDrawGizmos()
	{
	}

	public static void GenerateReflectionsPool(int v_size)
	{
	}

	private void GetReflectionCamera(Camera v_source, out Camera v_reflected)
	{
		v_reflected = null;
	}

	public void ReleaseCamera()
	{
	}

	private void SynchCameras(Camera v_source, Camera v_reflected)
	{
	}

	private void CalculateReflectionMatrix(ref Matrix4x4 v_refMatrix, Vector4 v_refPlane)
	{
	}

	private Vector4 CameraSpacePlane(Camera v_cam, Vector3 v_pos, Vector3 v_normal, float sideSign)
	{
		return default(Vector4);
	}

	public void ClearReflectors()
	{
	}

	public void OnDisable()
	{
	}

	public bool IsObjectReflectionVisible(Transform targetObject, Camera fromCamera)
	{
		return false;
	}
}
