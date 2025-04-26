using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.Events;

public class Location20_Arena : MonoBehaviour
{
	private bool playerMoveCan;

	private float rotateMovePlayer;

	private float animFloatRun;

	private bool sidePlayer;

	private bool cameraOnPlayer;

	private float timeReset;

	private bool activeLook;

	private float timeNextLookIK;

	private Transform lookTarget;

	[Header("Игрок")]
	[SerializeField]
	private Animator animPlayer;

	[SerializeField]
	private Rigidbody[] playerRagdolls;

	[SerializeField]
	private Transform playerPivot;

	[SerializeField]
	private Transform cameraPivot;

	[SerializeField]
	private float speedMovePlayer;

	[SerializeField]
	private Transform[] objectsLook;

	[SerializeField]
	private LookAtIK lookAtIK;

	[SerializeField]
	[Header("Конечности")]
	private Transform[] limbs;

	[SerializeField]
	private GameObject[] limbsBlood;

	[SerializeField]
	private GameObject[] limbObjects;

	[SerializeField]
	private Vector3[] limbObjectsPositions;

	[SerializeField]
	private Quaternion[] limbObjectsRotations;

	private AnimatorOverrideController animPlayerOver;

	private Location20_PlayerAnimation targetAnimation;

	private float timeAnimationPlayer;

	private float timeIdle;

	private float timeRun;

	private float weightOtherAnimation;

	private bool canUseSwitch;

	private int lastUpShield;

	private float timeShieldUp;

	private float noiseCamera;

	[SerializeField]
	[Header("Игра")]
	private LayerMask layerBomb;

	[SerializeField]
	private Interface_KeyHint_Key keyRightSwitch;

	[SerializeField]
	private Interface_KeyHint_Key keyLeftSwitch;

	[SerializeField]
	private GameObject[] shields;

	[SerializeField]
	private bool[] shieldsUp;

	[SerializeField]
	private Transform mita;

	[SerializeField]
	private GameObject bomb;

	[SerializeField]
	private GameObject bombExplosion;

	[SerializeField]
	private GameObject playerBlood;

	[SerializeField]
	private Transform mitaRightHand;

	[SerializeField]
	private Transform mitaLeftHand;

	[SerializeField]
	private Transform playerT;

	[SerializeField]
	private UnityEvent eventPlayerDeath;

	[SerializeField]
	private UnityEvent eventPlayerReset;

	[SerializeField]
	private AnimationClip[] animationsMita;

	private float timeMitaAnimation;

	private float timeAnimationThrowBomb;

	private bool mitaNeedKillPlayer;

	private bool playPhase;

	private int phase;

	private bool negativeTime;

	private bool phase0ShowRule;

	private float phase0ShowRuleStop;

	private float phase0RotateCamera;

	private float phase0SpeedRotate;

	private float playerTimeMove;

	private float timeStartDontMovePlayer;

	private bool musicPlay;

	private float timeMusicSwitch;

	[Header("Фаза 1")]
	[SerializeField]
	private UnityEvent eventRestartPhase1;

	[SerializeField]
	private UnityEvent eventStartPhase1;

	[SerializeField]
	private Time_Events timeReadyPhase1;

	[SerializeField]
	private ParticleSystem recorderParticle;

	[SerializeField]
	private AudioSource recorderButton;

	[SerializeField]
	private Time_Events animationMitaClick;

	[SerializeField]
	private Time_Events animationMitaThrowBombRecorder;

	private float timeCloseEyes;

	private bool mitaCloseEyes;

	private float timeCheckCastPlayer;

	[Header("Фаза 2")]
	[SerializeField]
	private UnityEvent eventRestartPhase2;

	[SerializeField]
	private UnityEvent eventStartPhase2;

	[SerializeField]
	private Time_Events timeMitaCloseEyes;

	[SerializeField]
	private Time_Events timeMitaOpenEyes;

	[SerializeField]
	private Time_Events timeReadyPhase2;

	[SerializeField]
	private Time_Events animationMitaThrowBombSarch;

	[SerializeField]
	private Transform playerCast;

	[SerializeField]
	private Transform mitaHead;

	private float timeStartAttack;

	private bool firstBomb;

	[SerializeField]
	[Header("Фаза 3")]
	private UnityEvent eventRestartPhase3;

	[SerializeField]
	private UnityEvent eventStartPhase3;

	[SerializeField]
	private Time_Events animationMitaThrowBombFirst;

	[SerializeField]
	private Time_Events animationMitaThrowBombAttack;

	private bool fallPlayer;

	private float timeForward;

	private float gravityY;

	[Header("Падение")]
	[SerializeField]
	private UnityEvent eventPlayerFall;

	[SerializeField]
	[Header("Звуки")]
	private AudioClip[] soundsBomb;

	[SerializeField]
	private AudioClip soundsShieldUp;

	[SerializeField]
	private AudioClip soundsShieldDestroy;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void ResetPhase()
	{
	}

	public void PlayerMoveCan(bool x)
	{
	}

	public void PlayPhase(int x)
	{
	}

	public void PlayerAnimationPlay(Location20_PlayerAnimation _target)
	{
	}

	public void PlayerUseSwitch()
	{
	}

	public void MitaThrowBomb(bool x)
	{
	}

	public void PlayerDeath()
	{
	}

	private void CreatePartGore(int _indexPart)
	{
	}

	public void SnakeCamera(float _x)
	{
	}

	private void NextLook()
	{
	}

	public void ExplosionBomb(Vector3 _position)
	{
	}

	public void DialogueRuleEnd()
	{
	}

	public void MitaSwitchRecorder()
	{
	}

	public void MitaCloseEyes(bool x)
	{
	}
}
