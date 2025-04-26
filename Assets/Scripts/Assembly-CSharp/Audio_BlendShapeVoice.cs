using UnityEngine;

public class Audio_BlendShapeVoice : MonoBehaviour
{
	[SerializeField]
	private float intensity;

	[SerializeField]
	private string nameShapeO;

	[SerializeField]
	private AudioSource audioVoice;

	[SerializeField]
	private AnimationCurve animationMouth;

	[SerializeField]
	[Header("Отключение блендшейпов")]
	private Audio_BlendShapeVoice_Intensity[] shapesOffInSpeak;

	[SerializeField]
	private AnimationCurve animationOffInSpeak;

	private float intensityOff;

	private float timeOffInSpeak;

	private SkinnedMeshRenderer mesh;

	private int shapeO;

	private float timeAnimationFloat;

	private float intensotyO;

	private float randomMaxO;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void UpdateBlendShapeODeactive()
	{
	}

	private void UpdateBlendShape()
	{
	}

	public void RechangeIntensity(float x)
	{
	}

	public void RebindBlendshapes()
	{
	}
}
