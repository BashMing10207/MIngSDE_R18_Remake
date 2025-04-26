using NaughtyAttributes;
using UnityEngine;

public class ObjectDoor : MonoBehaviour
{
	[Header("Settings")]
	public bool lockDoor;

	[SerializeField]
	private ObjectDoor[] bundleDoors;

	private bool otherBundleDoorOpen;

	private Quaternion rotationWas;

	[Header("Анимация")]
	[SerializeField]
	private AnimationCurve animationClose;

	private float animationCloseTime;

	[SerializeField]
	private float animationCloseSpeed;

	[SerializeField]
	private EventPoint[] eventsAnimation;

	protected Animator anim;

	protected AnimatorOverrideController animatorOverrideController;

	private float timeAnimationStop;

	private int timeClosedDoor;

	private float timeOpenDoor;

	private bool openAngle;

	private float openAngleRotate;

	private float animationTimeAngle;

	private Quaternion rotateAngleWas;

	private float angleJoint;

	[Header("Звуки")]
	[SerializeField]
	private AudioClip[] soundsOpen;

	[SerializeField]
	private AudioClip[] soundsClose;

	[SerializeField]
	private AudioSource audioSource;

	[SerializeField]
	private AudioSource audioMove;

	private bool offOptimization;

	[Header("Оптимизация")]
	[SerializeField]
	private bool onX;

	[SerializeField]
	private bool onZ;

	[SerializeField]
	private GameObject[] objectsRight;

	[SerializeField]
	private GameObject[] objectsLeft;

	[Header("Дверь (Инфо)")]
	public bool open;

	[SerializeField]
	private float angleNow;

	private Transform playerT;

	private Quaternion rotationOrigin;

	private Vector3 positionOrigin;

	private HingeJoint hj;

	private Rigidbody rb;

	private bool fs;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void DoorClosed()
	{
	}

	private void DoorOpened()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Lock(bool x)
	{
	}

	public void LockSharply()
	{
	}

	public void AnimationPlay(AnimationClip _clip)
	{
	}

	public void AnimationPlayTime(AnimationClip _clip)
	{
	}

	public void AnimationStop()
	{
	}

	public void OpenAngle(float _angle)
	{
	}

	public void OpenAngleStop()
	{
	}

	public void EV(int _index)
	{
	}

	public void NewEvent(int _index)
	{
	}

	public void OptimizationActive(bool x)
	{
	}

	public void OptimizationObjectsActivation()
	{
	}

	[Button("Перезаписать позицию", EButtonEnableMode.Always)]
	public void ResetOriginPosition()
	{
	}

	[Button("Перезаписать вращение", EButtonEnableMode.Always)]
	public void ResetOriginRotation()
	{
	}

	public void RotateDoorData()
	{
	}
}
