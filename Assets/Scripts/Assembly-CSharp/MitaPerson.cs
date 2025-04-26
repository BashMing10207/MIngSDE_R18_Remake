using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class MitaPerson : MonoBehaviour
{
	public Animator animMita;

	public NavMeshAgent nma;

	public Character_Look lookLife;

	private float timeFaceLayer;

	private int indexTextureFaceLayer;

	private int indexTextureFaceLayerNow;

	private Color colorFaceLayer;

	private Color colorEmissionFaceLayer;

	[Header("Лицевая маска")]
	public SkinnedMeshRenderer faceLayer;

	public SkinnedMeshRenderer meshHead;

	public int startLayerFace;

	[Header("Hands")]
	public Transform boneRightItem;

	public Transform boneLeftItem;

	public Transform fixedRightItem;

	public Transform fixedLeftItem;

	private Transform magnetTarget;

	private bool canRotate;

	private AnimationClip animIdleAfter;

	private Transform targetMoveTo;

	private UnityEvent eventFinish;

	[HideInInspector]
	public UnityEvent eventFinishAddon;

	private float timeRotate;

	private Transform tTarget;

	private float nmaSpeed;

	[Header("AI")]
	public float distanceTargetMoveFinish;

	[SerializeField]
	private float speedRotateLerp;

	private bool faceEmotion;

	[Header("Эмоция")]
	public string startEmotion;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	public void MagnetToTarget(Transform _target)
	{
	}

	public void MagnetOff()
	{
	}

	public void MitaTeleport(Transform _target)
	{
	}

	public void AiWalkToTarget(Transform _target, UnityEvent _eventFinish)
	{
	}

	public void AiWalkToTarget(Transform _target, UnityEvent _eventFinish, AnimationClip _animIdleAfter)
	{
	}

	public void AiWalkToTargetTranform(Transform _target, UnityEvent _eventFinish)
	{
	}

	private void AiWalkToTarget(Transform _target)
	{
	}

	public void AiWalkToTargetRotate(Transform _target, UnityEvent _eventFinish)
	{
	}

	public void AiSpeedNavigation(float x)
	{
	}

	public void AiShraplyStop()
	{
	}

	public void FaceLayer(int _index)
	{
	}

	public void FaceLayerFast(int _index)
	{
	}

	private void FaceSetTexture()
	{
	}

	private void FaceColorUpdate()
	{
	}

	public void FaceEmotion(string _name)
	{
	}

	public void FaceEmotionFast(string _name)
	{
	}

	public void FaceEmotionOff()
	{
	}

	public void FaceEmotionFastOff()
	{
	}

	public void FaceEmotionType(EmotionType _emotion)
	{
	}
}
