using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class MT_GameCnowballs : MonoBehaviour
{
	[SerializeField]
	[Header("Установки для игры")]
	private MT_GameCnowballs_Level[] levels;

	[SerializeField]
	private Transform cameraT;

	[Header("Префабы и частицы")]
	[SerializeField]
	private GameObject Ball;

	[SerializeField]
	private GameObject prefabParticleBall;

	private Rigidbody rbMita;

	private float timeCheckNear;

	private float noiseCamera;

	[SerializeField]
	[Header("Игроки")]
	private Rigidbody playerRb;

	[SerializeField]
	private NavMeshAgent navigationMita;

	[SerializeField]
	private Animator animPlayer;

	[SerializeField]
	private Animator animEmemy;

	[SerializeField]
	private AnimationCurve animationDamage;

	private float timeAnimationDamagePlayer;

	private float timeAnimationDamageMita;

	[SerializeField]
	private ParticleSystem particleMoveMita;

	[SerializeField]
	private ParticleSystem particleMovePlayer;

	[SerializeField]
	private TrailRenderer[] trailsPinguins;

	[SerializeField]
	private Renderer materialPlayer;

	[SerializeField]
	private Renderer materialMita;

	private float countStart;

	private float timeStart;

	[Header("Интерфейс")]
	[SerializeField]
	private Text textSnowPlayer;

	[SerializeField]
	private Text textSnowMita;

	[SerializeField]
	private Text textStart;

	[SerializeField]
	private AnimationCurve animationText;

	private float timeTextPlayer;

	private float timeTextMita;

	private float timeWin;

	[HideInInspector]
	public List<GameObject> ballsObjects;

	private int scorePlayer;

	private int scoreMita;

	private int scorePlayerResult;

	private int scoreMitaResult;

	private bool play;

	private bool resultShow;

	private float resultTimeShow;

	private int countSnowBall;

	private float timeAnimationCountSnowball;

	private List<Vector3> positionsSnowballMita;

	private List<Vector3> positionsSnowballPlayer;

	[HideInInspector]
	public List<GameObject> snowball;

	[HideInInspector]
	public List<float> snowballTime;

	private float timeResultReady;

	[Header("Результаты")]
	[SerializeField]
	private AnimationCurve circleX;

	[SerializeField]
	private AnimationCurve circleY;

	[SerializeField]
	private GameObject prefabSnowballFloor;

	[Header("Звуки")]
	[SerializeField]
	private AudioSource audioMove;

	[SerializeField]
	private Audio_Data audioKick;

	[SerializeField]
	private AudioClip soundKick;

	[SerializeField]
	private Audio_Data audioSnowTake;

	[SerializeField]
	private Audio_Data audioSnowFall;

	[SerializeField]
	private AudioSource ResultWin;

	[SerializeField]
	private AudioClip soundTimeStart;

	[SerializeField]
	private AudioClip soundWin;

	private int countPlayed;

	[Header("Сюжет")]
	public MinigamesTelevisionGame gameController;

	[SerializeField]
	private int changeLevel;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	public void TakeSnowball(bool _player, Vector3 _positionTake, GameObject _objectBall)
	{
	}

	private void NextSnowballs()
	{
	}

	private void Finish()
	{
	}

	[ContextMenu("Рестарт")]
	public void RestartWorld()
	{
	}

	public void Play()
	{
	}

	[ContextMenu("Начать отчет")]
	public void PlayTimeStart()
	{
	}

	public void CollisionPinguin(bool _player)
	{
	}

	public void ResultStart()
	{
	}

	public void ResultReady()
	{
	}

	private void ResultSnowballReady()
	{
	}

	public void Continue()
	{
	}
}
