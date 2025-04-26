using System.Collections.Generic;
using NaughtyAttributes;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.Events;

public class Location11_Lift : MonoBehaviour
{
	[SerializeField]
	private UnityEvent eventFinishA;

	[SerializeField]
	private UnityEvent eventStartB;

	[SerializeField]
	private UnityEvent eventFinishB;

	[SerializeField]
	private UnityEvent eventStartUnsit;

	[SerializeField]
	private Transform positionAnimationPlayer;

	[Header("Смерть")]
	[SerializeField]
	private Transform positionAnimationDeath;

	[SerializeField]
	private UnityEvent eventStartKill;

	[SerializeField]
	private UnityEvent eventRestart;

	private bool turretUse;

	[HideInInspector]
	public List<Location11_TurretTrailShot> trailShot;

	[Header("Турель")]
	[SerializeField]
	private Transform targetTurret;

	[SerializeField]
	private Transform turretVertical;

	[SerializeField]
	private Transform turretHorizontal;

	[SerializeField]
	private Transform pointShot;

	[SerializeField]
	private LayerMask layerEnemy;

	[SerializeField]
	private GameObject exampleShot;

	[SerializeField]
	private GameObject particleHit;

	[SerializeField]
	private AudioSource turretAudio;

	[SerializeField]
	private AudioClip[] turretShot;

	[SerializeField]
	private AudioClip shotPipe;

	[SerializeField]
	private AudioClip[] shotColon;

	[SerializeField]
	private AudioClip[] shotEnemy;

	[SerializeField]
	private AudioClip shotDeath;

	[SerializeField]
	private AudioSource turretBulletFall;

	private bool readyTurret;

	private bool readyAttack;

	private float timeCreateEnemy;

	private int checkEnemys;

	private float maxTimeCreateEnemy;

	[HideInInspector]
	public List<GameObject> enemys;

	[SerializeField]
	[Header("Враги")]
	private GameObject enemyExample;

	private FullBodyBipedIK scrfbbik;

	private Transform elbowLeftPlayer;

	private Transform elbowRightPlayer;

	[Header("IK игрока")]
	[SerializeField]
	private Transform pivotHandRight;

	[SerializeField]
	private Transform pivotHandLeft;

	[Header("Звуки")]
	[SerializeField]
	private AudioSource audioMove;

	private float noiseTube;

	[Header("Фуникулер")]
	[SerializeField]
	private Transform[] wheels;

	private bool dialogueRun;

	private bool tetrisReady;

	private bool inLift;

	private int mitafonIndexWait;

	private float mitafonTimeWait;

	[SerializeField]
	[Header("Диалоги")]
	private GameObject[] dialoguesMitafon;

	private GameController scrgc;

	private PlayerMove scrpm;

	private Transform cameraPlayer;

	private Transform playerT;

	private int typePath;

	private float speed;

	private float intensityControlTurret;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	public void StartLift()
	{
	}

	private void CreateEnemy()
	{
	}

	public void TurretUse(bool x)
	{
	}

	private void Shot()
	{
	}

	public void DeathPlayer()
	{
	}

	[Button("Перезапустить", EButtonEnableMode.Always)]
	public void ResetGame()
	{
	}

	public void DialogueFinish()
	{
	}

	public void PlayerInLift(bool x)
	{
	}
}
