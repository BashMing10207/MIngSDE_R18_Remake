using System.Collections.Generic;
using Coffee.UIEffects;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class QuadLinerMain : MonoBehaviour
{
	private float timeRestart;

	private bool play;

	private bool win;

	private float timeWin;

	[SerializeField]
	[Header("Игра")]
	private QuadLinerMain_Wave[] waves;

	[SerializeField]
	private GameObject objectEnemy;

	[SerializeField]
	private string achievement;

	[SerializeField]
	private bool secondPhase;

	[SerializeField]
	[Header("Выход")]
	private RectTransform lineExit;

	[SerializeField]
	private UnityEvent eventExitGame;

	private float timeLosePlayer;

	private AnimationCurve animaitonLosePlayer;

	private bool dontMove;

	private float moveTime;

	[Header("Игрок")]
	[SerializeField]
	private RectTransform player;

	[SerializeField]
	private Image lineShoot;

	private float snakeFrameGame;

	private float timeUpdateSnake;

	private bool hideLineNext;

	private float lineSize;

	[Header("Интерфейс")]
	[SerializeField]
	private GameObject objectWave;

	[SerializeField]
	private RectTransform lineWave;

	[SerializeField]
	private RectTransform rectFrameGame;

	[SerializeField]
	private UIShiny effectShiny;

	[SerializeField]
	private Sprite spriteShield;

	[SerializeField]
	private Text textNumberLevel;

	[SerializeField]
	private Image imageWin;

	private AudioSource audioExit;

	private int indexAudio;

	[Header("Звуки")]
	[SerializeField]
	private GameObject audioMusic;

	[SerializeField]
	private GameObject audioMusicFight;

	[SerializeField]
	private AudioSource[] audioSounds;

	[SerializeField]
	private AudioClip[] sounds;

	private int waveNow;

	private float timeWave;

	private List<GameObject> enemyes;

	private List<int> linesVert;

	private float sizeWas;

	private float sizeNeed;

	private float timaAnimationSize;

	private float rotateWas;

	private float rotateNeed;

	private float timaAnimationRotate;

	private AnimationCurve animationLerp;

	private void Start()
	{
	}

	[Button("Запуск", EButtonEnableMode.Always)]
	public void StartGame()
	{
	}

	private void Update()
	{
	}

	private void RestartGame()
	{
	}

	private void ExitGame()
	{
	}

	private void Shoot()
	{
	}

	private void Move(bool _right)
	{
	}

	public void Lose()
	{
	}

	private void Win()
	{
	}

	private void ClearWave()
	{
	}

	private void CreateNextWave()
	{
	}

	public void AudioPlayIndex(int _index)
	{
	}

	private void AudioPlay(AudioClip _sound, float _pitch, float _volume)
	{
	}
}
