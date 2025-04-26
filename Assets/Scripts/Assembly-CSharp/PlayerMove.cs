using System.Collections.Generic;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.Events;

public class PlayerMove : MonoBehaviour
{
	[Header("Игрок")]
	[SerializeField]
	private float headOffsetWalkForward;

	[SerializeField]
	private float headOffsetWalkBack;

	[SerializeField]
	private float headOffsetWalkRight;

	[SerializeField]
	private bool canRun;

	[SerializeField]
	private bool needRun;

	public float intensityMouse;

	private PlayerPerson scrpp;

	[HideInInspector]
	public PlayerPersonIK scrppik;

	[SerializeField]
	[Header("Скрипты")]
	private PlayerArmsHead scrpah;

	private float timeCameraFreeze;

	private bool faceWall;

	private float forwardHead;

	private float heightHead;

	[HideInInspector]
	public float rotX;

	[HideInInspector]
	public float rotY;

	private float clampRotYMin;

	private float clampRotYMax;

	private int timeCast;

	private AnimationCurve cameraOtherTargetLerp;

	private Transform cameraOtherTarget;

	private float timeCameraOtherTargetLerp;

	private float speedCameraOtherTargetLerp;

	private Vector3 cameraOtherTargetWasPosition;

	private Quaternion cameraOtherTargetWasRotation;

	[Header("Голова")]
	public Transform mainCamera;

	[SerializeField]
	private Transform cameraPostProcessing;

	public Transform head;

	[SerializeField]
	private AnimationCurve animationHeadWalk;

	private float animationHeadWalkTime;

	[SerializeField]
	private AnimationCurve animationHeadRotationX;

	private float animationHeadTorationXTime;

	[SerializeField]
	private AnimationCurve animationHeadRotationY;

	private float animationHeadTorationYTime;

	[SerializeField]
	private Transform headPerson;

	public LayerMask castHead;

	public LayerMask castMove;

	public LayerMask castFixCamera;

	[SerializeField]
	private LookAtIK ikHead;

	[SerializeField]
	private AnimationCurve animationCameraZoom;

	private bool zoom;

	public bool zoomControl;

	private float timeZoom;

	private float zoomWas;

	[SerializeField]
	private Transform fixHead;

	private float cameraNoise;

	[HideInInspector]
	public bool dontMove;

	[HideInInspector]
	public bool stopMouseMove;

	private float speed;

	private float speedAnim;

	private int moveH;

	private int moveV;

	private Rigidbody rb;

	private bool hide;

	private float ladderSpeed;

	private Vector3 velocityNormalized;

	private float moveSlow;

	[HideInInspector]
	public Vector3 velocityLocal;

	[HideInInspector]
	public float speedVelocity;

	[Header("Движение")]
	[SerializeField]
	private float speedPlayer;

	public bool canSit;

	private bool needSit;

	private int sit;

	private CapsuleCollider capsule;

	private float timeSitStart;

	private float timeSitStop;

	[HideInInspector]
	public bool animationHandRun;

	private float timeAnimationHandNow;

	private AnimationClip animationHandsLoop;

	private AnimationClip animationHandsStop;

	private UnityEvent eventAnimationHandStartLoop;

	private AnimatorOverrideController animArmsFaceOver;

	private bool typeAnimationArms;

	private bool animationArmsFace;

	private bool animationArmsRechangeItem;

	[HideInInspector]
	public string nameStatePlayNow;

	[HideInInspector]
	public ObjectAnimationPlayer scrAnimationNow;

	[HideInInspector]
	public bool animationRun;

	[HideInInspector]
	public bool keepItem;

	[HideInInspector]
	public bool animationFast;

	private float timeAnimationNow;

	[HideInInspector]
	public float timeAnimationAfter;

	[HideInInspector]
	public bool animationLoopRun;

	private AnimationClip animationLoop;

	private AnimationClip animationStop;

	private Transform animationPosition;

	private UnityEvent eventAnimationStartLoop;

	private bool typeAnimation;

	private Quaternion rotationPlayerSave;

	private Vector3 positionPlayerSave;

	[HideInInspector]
	public AnimatorOverrideController animOver;

	[HideInInspector]
	public float angleHeadRotateAnimation;

	private float rotXAnim;

	private float rotYAnim;

	private float animForward;

	private float animRight;

	private bool stopAnimationPositionHips;

	private bool stopAnimationFastBody;

	private Vector3 stopAPHStartPos;

	private Vector3 stopAPHStopPos;

	[Header("анимация")]
	[SerializeField]
	private AnimationCurve animationBlend;

	private float animationBlendTime;

	[SerializeField]
	private AnimationCurve animationBlendCamera;

	public Animator animPerson;

	[SerializeField]
	private Animator animArmsFace;

	[SerializeField]
	private Transform hipsPerson;

	private int timeAnimOtherFloat;

	private float animatorFloatOtherA;

	private float animatorFloatOtherB;

	private float animationCameraIntensity;

	private float animationCameraSpeed;

	private bool animationCameraActive;

	private float timeAnimationCamera;

	private AnimationCurve animationCameraX;

	private AnimationCurve animationCameraY;

	private AudioSource audioRotation;

	private float volumeRotation;

	[Header("Звуки")]
	[SerializeField]
	private ObjectFoot foot;

	private AnimationCurve animationLook;

	private float timeAnimationLook;

	private Quaternion rotationLookWasX;

	private Quaternion rotationLookWasY;

	private Transform lookTarget;

	private float lookTime;

	private UnityEvent lookEventEnd;

	[SerializeField]
	[Header("Интерфейс")]
	private Interface_KeyHint_Key keyRun;

	private bool hideItem;

	[Header("Предметы")]
	public GameObject item;

	[HideInInspector]
	[Header("Информация")]
	public int blockInteractive;

	private RaycastHit hit;

	public GameObject objectCast;

	public GameObject objectCastInteractive;

	public GameObject objectCastHandInteractive;

	public float distanceCast;

	private int countFloorFix;

	private float timeFloorFix;

	private Vector3 pointFloorFix;

	public void Awake()
	{
	}

	public void StartComponent()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void Animation()
	{
	}

	private void FixedUpdate()
	{
	}

	private Vector3 GetLocalPositionHead()
	{
		return default(Vector3);
	}

	public void ResetPlayer()
	{
	}

	public void PauseGame(bool x)
	{
	}

	public void AnimationPlay(AnimationClip _animationStart, AnimationClip _animationLoop, AnimationClip _animationStop, Transform _position, UnityEvent _eventAnimationStartLoop, List<UnityEvent> _eventsPlayer, bool _keepItem, ObjectAnimationPlayer _scranimation)
	{
	}

	public void AnimationPlayStop()
	{
	}

	public void AnimationStop()
	{
	}

	public void AnimationStopFull()
	{
	}

	public void AnimationFloatSet(bool ab, float _float)
	{
	}

	public void AnimationOtherBlend(AnimationClip _animationClip)
	{
	}

	public void Step()
	{
	}

	public void AnimationFastStop()
	{
	}

	public void AnimationCameraPlay(AnimationCurve _animationCameraX, AnimationCurve _animationCameraY, float _speed)
	{
	}

	public void AnimationCameraStop()
	{
	}

	public void AnimationHandPlay(AnimationClip _animationStart, AnimationClip _animationLoop, AnimationClip _animationStop, UnityEvent _eventAnimationStartLoop, List<UnityEvent> _eventsPlayer, bool _face, bool _keepItem)
	{
	}

	public void AnimationHandPlayFast()
	{
	}

	public void AnimationHandPlayStop()
	{
	}

	public void AnimationHandStop()
	{
	}

	public void TeleportRotate(float _rotation)
	{
	}

	public void TeleportPlayer(Vector3 _position)
	{
	}

	public void TeleportPlayer(Vector3 _position, float _rotation)
	{
	}

	public void TeleportPlayer(Vector3 _position, float _rotation, float _rotationHead)
	{
	}

	private void TeleportPlayerGeneral()
	{
	}

	public void Look(Transform _target, float _time, UnityEvent _event)
	{
	}

	private void LookStop()
	{
	}

	public void Hide(bool x)
	{
	}

	public void SitHold()
	{
	}

	private void ResetCast()
	{
	}

	public void HideBody(bool x)
	{
	}

	public void SitNeed(bool x)
	{
	}

	public void RunNeed(bool x)
	{
	}

	public void BlockInteractive()
	{
	}

	public void SlowTimeMove(float _intensity)
	{
	}

	public void UpdateSettingsCamera()
	{
	}

	public void CameraNoise(float x)
	{
	}

	public void CameraTargetOther(Transform target, AnimationCurve animationCurve, float _speed)
	{
	}

	public void CameraTargetOther(Transform target)
	{
	}

	public void TakeItem(GameObject _item)
	{
	}

	public void RemoveItem()
	{
	}

	public void HideItem(bool x)
	{
	}

	public Transform GetBoneRightItem()
	{
		return null;
	}

	public Transform GetBoneLeftItem()
	{
		return null;
	}
}
