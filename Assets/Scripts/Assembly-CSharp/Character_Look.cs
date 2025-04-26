using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.Events;

public class Character_Look : MonoBehaviour
{
	private Transform mainTransform;

	[SerializeField]
	[Header("Поведение")]
	private bool active;

	[SerializeField]
	private bool activeBlink;

	private float timeOffBlink;

	[SerializeField]
	[Header("Анимация")]
	private Animator animPerson;

	[SerializeField]
	private AnimationCurve movePoints;

	[SerializeField]
	private AnimationCurve movePointsBody;

	private FullBodyBipedIK ikMain;

	private Transform boneHead;

	[SerializeField]
	[Header("IK")]
	private Transform forwardPerson;

	[SerializeField]
	private Transform spine;

	[SerializeField]
	private LookAtIK head;

	[SerializeField]
	private LookAtIK eyes;

	[SerializeField]
	private LookAtIK body;

	[SerializeField]
	private float bodyYOffset;

	private float needBodyYOffset;

	private float wasBodyYOffset;

	private float timeNeedBodyYOffset;

	[SerializeField]
	private bool activeBodyIK;

	[SerializeField]
	private bool offLimitAngleLook;

	public bool offTimeLookRandom;

	public bool offIKHead;

	private float timeAnimationPivotLegsRotate;

	private float pivotLegsRotateWas;

	private float pivotLegsRotateNeed;

	private bool rotateBodySide;

	private Vector3 positionRightLegStay;

	private Vector3 positionLeftLegStay;

	private Vector3 positionLegNeedLeft;

	private Vector3 positionLegNeedRight;

	private Quaternion rotationLegRotateRight;

	private Quaternion rotationLegRotateLeft;

	private float timeDontCanRotateBody;

	private float timeNowCanRotateBody;

	private float speedRotateBody;

	private Transform targetForRotateBody;

	private bool rotateBodyExact;

	[SerializeField]
	[Header("Поворот персонажа")]
	private AnimationCurve animationRotateBody;

	[SerializeField]
	private AnimationCurve animationRotateBodyUpLegs;

	public bool canRotateBody;

	[SerializeField]
	private Transform pivotLegs;

	[SerializeField]
	private Transform legRightBone;

	[SerializeField]
	private Transform legLeftBone;

	[SerializeField]
	private Animator_UnitStep stepLegs;

	private float timeAnimationNow;

	private AnimationCurve animationNod;

	private bool typeNod;

	private Vector3 positionNod;

	[SerializeField]
	[Header("Блендшейпы")]
	private Animator animBlink;

	[SerializeField]
	[Header("Стартовые настройки")]
	private bool startPriorityPlayer;

	[Header("Инфо")]
	private Transform lookObjectEyes;

	private float timeLookObjectEyes;

	private float timeCheckEyes;

	private Vector3 eyesPositionRandom;

	private float timeBlink;

	private float timeBlinkM;

	private bool randomLook;

	private Vector3 positionRandomLook;

	private float timeLookEyes;

	private float timeLookEyesMax;

	private float timeLookHead;

	private float timeLookHeadMax;

	private float speedLerpLookHead;

	private float speedLerpDivide;

	[Header("Взгляд персонажа")]
	public Transform lookObject;

	[SerializeField]
	private float dotLook;

	[HideInInspector]
	public UnityEvent eventRotateBodyFinish;

	private bool erbfReady;

	[HideInInspector]
	public UnityEvent eventRotateBodyHalfFinish;

	private bool erbhfReady;

	private float speedActivation;

	private float speedLook;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void OnEnable()
	{
	}

	private void ReTimeLookEyes()
	{
	}

	private void CheckLookForEyes()
	{
	}

	[ContextMenu("ReLookHead")]
	private void ReTimeLookHead()
	{
	}

	private void ReTimeBlink()
	{
	}

	public void StartRotate(Vector3 _positionTarget)
	{
	}

	public void StopRotate()
	{
	}

	public void IKBodyEnable(bool x)
	{
	}

	public void Nod(bool _yes)
	{
	}

	public void LookOnObject(Transform _target)
	{
	}

	public void LookOnObjectSmooth(Transform _target)
	{
	}

	public void LookAndPriorityObject(Transform _target)
	{
	}

	public void LookOnObjectAndRotate(Transform _target)
	{
	}

	public void RotateOnTarget(Transform _target)
	{
	}

	public void RotateOnTargetExact(Transform _target)
	{
	}

	public void ForwardReTransform(Transform _target)
	{
	}

	[ContextMenu("Случайный взгляд")]
	public void LookRandom()
	{
	}

	public void EyesLookOnPlayer(float _time)
	{
	}

	public void EyesLookOffsetRandom(float _x)
	{
	}

	public void Blink()
	{
	}

	public void OffsetBody(float x)
	{
	}

	public void InstantTargetLook(Transform _target)
	{
	}

	public void LookOnPlayer()
	{
	}

	public void LookOnPlayerAndRotate()
	{
	}

	public void LookRotatePriorityOnPlayer()
	{
	}

	public void PriorityLookOnPlayer()
	{
	}

	public void PriorityLookAndOnPlayer()
	{
	}

	public void FastDeactive()
	{
	}

	public void Activation(bool x)
	{
	}

	public void ActivationBlink(bool x)
	{
	}

	public void ActivationRotateBody(bool x)
	{
	}

	public void PriorityLook(Transform _transform)
	{
	}

	public void RandomTimeLookActivation(bool x)
	{
	}

	public void ReSpeedActivation(float x)
	{
	}

	public void ReSpeedLook(float x)
	{
	}

	public void LimitAngleLookOff(bool x)
	{
	}
}
