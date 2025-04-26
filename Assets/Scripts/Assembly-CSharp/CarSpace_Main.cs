using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarSpace_Main : MonoBehaviour
{
	private int placeInRacing;

	private int money;

	private GameObject obejctMoneys;

	[Header("Дорога")]
	[SerializeField]
	private GameObject worldRacing;

	[SerializeField]
	private List<Vector3> vectorRoad;

	[SerializeField]
	private Transform[] placesCar;

	[SerializeField]
	private SpriteRenderer[] traficLights;

	[SerializeField]
	private GameObject prefabMoney;

	[SerializeField]
	private List<TransformPositionRotation> positionsMoney;

	private Transform carPlayerT;

	[Header("Игрок")]
	public CarSpace_Player carPlayer;

	[SerializeField]
	[Header("Другие гонщики")]
	private CarSpace_Main_Enemy[] enemys;

	private float timeUpdatePlace;

	[Header("Интерфейс")]
	[SerializeField]
	private Text textNumberPlace;

	[SerializeField]
	private Image screenAlpha;

	[SerializeField]
	private GameObject lines;

	[SerializeField]
	private Text textMoneyCount;

	[SerializeField]
	private Image nitroLine;

	private bool finish;

	private float finishTimeAnimaiton;

	private int finishTimeAnimaitonIndex;

	[Header("Финиш")]
	[SerializeField]
	private GameObject[] enemyDestroys;

	[SerializeField]
	private GameObject finishUI;

	[SerializeField]
	private UI_Alpha vignetteFinish;

	[SerializeField]
	private Text[] finishInfo;

	private List<GameObject> objectsInfinity;

	private bool boss;

	private float timeAnimationInterfaceBoss;

	private int indexAnimationInterfaceBoss;

	[HideInInspector]
	public int hpBoss;

	private float timeRestart;

	[SerializeField]
	[Header("Босс")]
	private GameObject worldBoss;

	[SerializeField]
	private CarSpace_Boss bossEnemy;

	[SerializeField]
	private Transform infinityRoad;

	[SerializeField]
	private GameObject[] interfacesBosses;

	[SerializeField]
	private CarSpace_Scanner scanner;

	private bool startCutScene;

	private float timeStartGame;

	private bool anyKey;

	[SerializeField]
	[Header("Старт игры")]
	private Animator animatorCameraPlayer;

	[SerializeField]
	private Animator animatorAnyKey;

	[SerializeField]
	private Animator animatorMita;

	[Header("Звуки")]
	[SerializeField]
	private CarSpace_Music music;

	[SerializeField]
	private Audio_LowPass speedCar;

	[SerializeField]
	private AudioSource audioPlaceCar;

	[SerializeField]
	private AudioSource audioLight;

	[SerializeField]
	private AudioClip[] sounds;

	[SerializeField]
	private AudioSource audioTextBass;

	[Header("Настройки")]
	[SerializeField]
	private MinigamesFastMenu fastmenu;

	private float pauseWas;

	private bool play;

	private int indexTraficTimer;

	private float traficTimer;

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

	private void CheckPlaceInRace()
	{
	}

	private void PlayRacing()
	{
	}

	public void FinishRacing()
	{
	}

	public void SnakePosition(Vector3 _positionHit, float _intensity)
	{
	}

	public void Money()
	{
	}

	private void MoneyReset()
	{
	}

	public void ResetGame()
	{
	}

	private void BossFightStart()
	{
	}

	private void RestartBoss()
	{
	}

	private void InfinityBack()
	{
	}

	public void AddInfinityObject(GameObject _target)
	{
	}

	public void BossDamage()
	{
	}

	[ContextMenu("Boss win")]
	public void BossFinish()
	{
	}

	public void PlayerDestroy()
	{
	}

	public void InfinityClear()
	{
	}

	[ContextMenu("asd")]
	private void AD()
	{
	}
}
