using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Location34_Communication : MonoBehaviour
{
	public UnityEvent eventStartAddon;

	private float checkNearPosition;

	private Transform playerT;

	private Transform cameraT;

	private float timeStopNextCheck;

	private bool eventWalkReadyAddonActive;

	private UnityEvent eventWalkReadyAddon;

	private string roomPlayer;

	private bool mitaNeedToPoint;

	private float timeRotateToPlayer;

	private float timeFinishPoint;

	[Header("Точки для Миты")]
	public bool mitaCanWalk;

	public Location34_PositionForMita[] positionsForMita;

	public MitaPerson mita;

	public UnityEvent eventWalkStart;

	public UnityEvent eventWalkReady;

	public AnimationClip mitaAnimationIdle;

	public AnimationClip mitaAnimationWalk;

	[SerializeField]
	private CapsuleCollider capsulePlaceMita;

	[HideInInspector]
	public List<Location34_OtherInteractiveDeactive> wasOtherInteractive;

	[Header("Взаимодействия")]
	public bool onStartActiveAddon;

	[SerializeField]
	private ObjectInteractive[] otherInteractive;

	public GameObject[] addonInteractive;

	public GameObject[] addonOnStartActive;

	public GameObject[] addonObjectsInteractive;

	public GameObject[] addonObjectsReverseInteractive;

	public UnityEvent eventStartInteractive;

	public UnityEvent eventStopInteractive;

	private bool eventDontWalk;

	[SerializeField]
	private UnityEvent eventStartDontWalk;

	[SerializeField]
	private UnityEvent eventStopDontWalk;

	[HideInInspector]
	public int indexSwitchAnimation;

	private float timeRandomSwitchAnimation;

	private float timeSwitchAnimation;

	[HideInInspector]
	public float timeAnimationSafe;

	private int playTypeOhterAnimation;

	[Header("Другие анимации")]
	public Animator_FunctionsOverride mitaAnimator;

	public Location34_OtherAnimationWalk[] otherAnimation;

	public AnimationClip[] animationsBehaviour;

	[SerializeField]
	private List<bool> animationsBehaviourIK;

	public AudioClip[] soundAnimationBehaviour;

	public GameObject[] objectInHandsMita;

	[Header("Звуки")]
	[SerializeField]
	private AudioSource audioMitaMove;

	[SerializeField]
	[Header("Настройки")]
	private float timeCheckPointStopMove;

	public bool mitaFixPosition;

	public GameObject objectLookAfter;

	private float timeInputMove;

	private float timeUninputMove;

	private Vector3 positionPlayerBlock;

	private float timeMitaBlock;

	private LayerMask layerMob;

	private LayerMask layerDefault;

	private bool mitaForwardBlock;

	[Header("Инфо")]
	[Space(30f)]
	public bool play;

	public bool interactiveNow;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void LateUpdate()
	{
	}

	public void MitaStopPoint()
	{
	}

	public void SwitchAnimationClassic()
	{
	}

	public void ActivationOtherAnimation(bool x)
	{
	}

	private void MitaGoPoint(Vector3 _point)
	{
	}

	private void CheckNearPosition()
	{
	}

	private void SwitchOtherAnimation(int _index)
	{
	}

	private void PlayBehaviourAnimation(int _index)
	{
	}

	private void MitaBlockPlayer()
	{
	}

	private void CancelBlockPlayer()
	{
	}

	public void DeactiveObjectsAddonAnimationMita()
	{
	}

	public void PlayerInRoom(string _r)
	{
	}

	public void ActivationAddon(bool x)
	{
	}

	public void ActivationCanWalk(bool x)
	{
	}

	public void StartAddon()
	{
	}

	public void StopAddon()
	{
	}

	public void InteractiveActive(bool x)
	{
	}

	public void InteractiveActiveWithoutCheckPosition(bool x)
	{
	}

	public void MitaWalkToPoint(Transform _position)
	{
	}

	public void TakeEventWhenReadyWalk(Events_Data _event)
	{
	}

	public void TakeEventWhenReadyWalkIgnoryAnimation(Events_Data _event)
	{
	}

	public void TimeAddOtherAnimation(Time_Events _timeEvent)
	{
	}

	public void ChangeLookAfter(GameObject _object)
	{
	}

	public void ChangeLookAfterPlayer()
	{
	}

	public void StopCheckPointTime(float x)
	{
	}

	public void UpdateCapsulaPosition()
	{
	}

	public void MitaInstantAnimation(bool _offIK)
	{
	}

	public void MitaNormalizeIK()
	{
	}

	public void MitaOffIK()
	{
	}

	public void AnimationReWalk(AnimationClip _animationClip)
	{
	}

	public void AnimationReIdle(AnimationClip _animationClip)
	{
	}
}
