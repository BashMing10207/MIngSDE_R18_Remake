using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.UI;

public class Shooter_Main : MonoBehaviour
{
	public static float intensityMouse;

	private bool game;

	private bool finish;

	private float timeStartPlay;

	private bool playWave;

	private float timeDeath;

	private float timeDoorOpen;

	private float timeWin;

	[Header("Игра")]
	[SerializeField]
	private List<Shooter_Main_Wave> waves;

	[SerializeField]
	private Transform positionCreateEnemys;

	[SerializeField]
	private GameObject enemyFight;

	[SerializeField]
	private GameObject enemyShoot;

	[SerializeField]
	private GameObject enemyHealth;

	[SerializeField]
	private GameObject enemyBoss;

	[SerializeField]
	private Animator doorEnemy;

	private float timeCreateBubble;

	[HideInInspector]
	public GameObject objectLife;

	[Header("Мир")]
	[SerializeField]
	private GameObject bubble;

	[SerializeField]
	private List<Vector3> positionsBubbles;

	private int indexWave;

	private int indexEnemy;

	private float timeWave;

	private float timeWaveWin;

	public List<GameObject> enemys;

	private bool anykey;

	[Header("Анимация")]
	[SerializeField]
	private Playable_Animation animationStart;

	[SerializeField]
	private PlayableAsset animationAnyKeyDown;

	[SerializeField]
	private Animator animAnyKey;

	[SerializeField]
	private UnityEvent eventCutceneStartFinish;

	[SerializeField]
	private Playable_Animation animationWin;

	[SerializeField]
	private PlayableAsset animationFinishAnyKeyDown;

	[SerializeField]
	private UnityEvent eventCutceneFinishFinish;

	private int countKills;

	private float timeAnimationWaveLight;

	private bool blackScreen;

	[Header("Интерфейс")]
	[SerializeField]
	private Text textCountEnemys;

	[SerializeField]
	private Image imageWaveLightNow;

	[SerializeField]
	private AnimationCurve animationLightNow;

	[SerializeField]
	private GameObject interfacePlayer;

	[SerializeField]
	private Image imgScreen;

	[Header("Для игры")]
	public List<Vector3> pointsShoot;

	[Header("Звуки")]
	[SerializeField]
	private AudioSource audioSignal;

	[SerializeField]
	private Audio_LowPass musicLowPass;

	private float timeGame;

	private int countSecond;

	private int countMinute;

	private int countHours;

	private int countDeath;

	private int countShot;

	private int countShotHead;

	[HideInInspector]
	public float countDamage;

	private int countJump;

	[SerializeField]
	[Header("Очки")]
	private Text textTime;

	[SerializeField]
	private Text textDeath;

	[SerializeField]
	private Text textShot;

	[SerializeField]
	private Text textShothead;

	[SerializeField]
	private Text textDamage;

	[SerializeField]
	private Text textJump;

	[SerializeField]
	[Header("Настройки")]
	private MinigamesFastMenu fastMenu;

	[SerializeField]
	private Slider sliderMouseSpeed;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void CreateEnemy(int _typeEnemy)
	{
	}

	public void KillEnemy()
	{
	}

	private void UpdateInterface()
	{
	}

	private void WaveStart()
	{
	}

	private void NextWave()
	{
	}

	private void ClearWorld()
	{
	}

	public void PlayerDeath()
	{
	}

	private void RestartPlayer()
	{
	}

	public void RestartFull()
	{
	}

	[Button("Победить", EButtonEnableMode.Always)]
	private void Win()
	{
	}

	public void AnimationStart()
	{
	}

	public void AnimationFinish()
	{
	}

	public void AnimationCanAnykey()
	{
	}

	private void AnimationStartWin()
	{
	}

	private void CutscenePlay(Transform _targetAnimation)
	{
	}

	public void AddScore(int _type, int _count)
	{
	}

	public void UpdateSettings()
	{
	}
}
