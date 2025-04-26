using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Location20_RunCorridor : MonoBehaviour
{
	private bool showKeys;

	[Header("Кнопки")]
	[SerializeField]
	private Interface_KeyHint_Key keyRight;

	[SerializeField]
	private Interface_KeyHint_Key keyLeft;

	[SerializeField]
	private Interface_KeyHint_Key keyOpen;

	[SerializeField]
	private Interface_KeyHint_Key keyJump;

	private bool waitEnd;

	private Vector3 positionEnd;

	private bool waitJump;

	private Vector3 positionStartJump;

	private bool waitDoor;

	private Vector3 positionStartDoor;

	private Animator door;

	private bool waitRotate;

	private float timeRotatePlayer;

	private Quaternion rotateWas;

	private Quaternion rotateNeed;

	private Vector3 positionRotateFinish;

	private bool changeSide;

	private bool needChangeSide;

	private bool playerKeyDown;

	private bool hideAll;

	private bool stopGenerate;

	private int countForFinish;

	private bool run;

	private float speedRun;

	private float timeAnimationRun;

	private float speedTimeAnimationRun;

	[HideInInspector]
	[SerializeReference]
	private AnimationCurve animationCurveRun;

	private Vector3 positionAnimationPlayerStart;

	private Vector3 positionAnimationPlayerEnd;

	private int rotate;

	private Vector3 positionCreate;

	private Vector3 positionRunCreate;

	private int countForwardRotate;

	private int countForwardDoor;

	private int countSideObstacle;

	private int countForwardJump;

	private Transform corridorRotateForward;

	[Header("Генерация")]
	[SerializeField]
	private GameObject corridorForward;

	[SerializeField]
	private GameObject corridorRotate;

	[SerializeField]
	private GameObject corridorStop;

	[SerializeField]
	private GameObject corridorDoor;

	[SerializeField]
	private GameObject[] otherObjectsRestart;

	[SerializeField]
	private GameObject obstacleSideRight;

	[SerializeField]
	private GameObject obstacleSideLeft;

	[SerializeField]
	private GameObject obstacleJump;

	[HideInInspector]
	public List<Location20_RunCorridor_Part> objectsRun;

	private Transform playerT;

	private float needSide;

	private float sidePlayer;

	[Header("Анимации")]
	[SerializeField]
	private Transform positionMove;

	[SerializeField]
	private Transform positionPlayer;

	[SerializeField]
	private ObjectAnimationPlayer animPlayerRight;

	[SerializeField]
	private ObjectAnimationPlayer animPlayerLeft;

	[SerializeField]
	private ObjectAnimationPlayer animPlayerOpenDoor;

	[SerializeField]
	private ObjectAnimationPlayer animPlayerKickDoor;

	[SerializeField]
	private ObjectAnimationPlayer animPlayerJump;

	[SerializeField]
	private ObjectAnimationPlayer animPlayerFailJump;

	[SerializeField]
	private ObjectAnimationPlayer animPlayerKickRight;

	[SerializeField]
	private ObjectAnimationPlayer animPlayerKickLeft;

	[SerializeField]
	private AnimationCurve animationRunDoorOpen;

	[SerializeField]
	private AnimationCurve animationRunDoorKick;

	[SerializeField]
	private AnimationCurve animationRunJump;

	[SerializeField]
	private AnimationCurve animationRunFailJump;

	[SerializeField]
	private ObjectAnimationPlayer animationKillPlayerEnd;

	[SerializeField]
	private ObjectAnimationPlayer animationKillPlayerSlow;

	private float timeVelocity;

	[Header("Разрушение двери")]
	[SerializeField]
	private Transform doorMain;

	[SerializeField]
	private Location20_RunCorridor_DoorDestroy[] partsDoor;

	private float timeKillSlow;

	private int health;

	private bool mitaDistanceActive;

	[Header("Мита")]
	[SerializeField]
	private Transform mita;

	private float timeSpeedWalk;

	[SerializeField]
	[Header("Анимации на старте")]
	private UnityEvent eventStart;

	[SerializeField]
	private AnimationCurve animationSpeedWalk;

	[SerializeField]
	[Header("Рестарт")]
	private UnityEvent eventRestart;

	private bool startDestroy;

	private bool finish;

	[SerializeField]
	[Header("Финиш")]
	private ObjectAnimationPlayer animationStopRun;

	[SerializeField]
	private GameObject objectNextQuest;

	[SerializeField]
	private UnityEvent eventPreFinish;

	[SerializeField]
	private UnityEvent eventFinish;

	private ObjectFoot playerFoot;

	[SerializeField]
	[Header("Звуки")]
	private AudioSource audioPlayer;

	[SerializeField]
	private AudioClip[] soundsJump;

	[SerializeField]
	private AudioClip[] soundsFailJump;

	[SerializeField]
	private AudioClip[] soundsKickDoor;

	[SerializeField]
	private AudioClip[] soundsOpenDoor;

	[SerializeField]
	private AudioClip[] soundsKickSide;

	[SerializeField]
	private AudioClip[] soundsKillPlayer;

	[SerializeField]
	private AudioSource[] audiosReset;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void FinishRun()
	{
	}

	private void StartRotate()
	{
	}

	private void StartRotateSide(int _rotateNextRight, int _rotateNextLeft)
	{
	}

	private void StartOpenDoor()
	{
	}

	public void StartJump()
	{
	}

	public void StartEnd()
	{
	}

	public void StartSlow()
	{
	}

	private void CreateGeneration()
	{
	}

	private void AddCountGenerate(int x)
	{
	}

	private void CreatePart(int _type, bool _canObstacle)
	{
	}

	private void HideOtherObjects()
	{
	}

	private void AudioPlay(AudioClip[] _sounds)
	{
	}

	public void Damage()
	{
	}

	public void PlayWalk()
	{
	}

	public void PlayRun()
	{
	}

	public void RestartGame()
	{
	}

	public void KickRight()
	{
	}

	public void KickLeft()
	{
	}

	public void MitaFollowPlayer()
	{
	}

	public void DestroyDoor()
	{
	}

	public void KillPlayerStart()
	{
	}

	public void KeyDownChangeRotate(bool _x)
	{
	}

	public void KeyDownObstacle()
	{
	}
}
