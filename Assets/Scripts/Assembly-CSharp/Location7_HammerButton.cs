using UnityEngine;
using UnityEngine.UI;

public class Location7_HammerButton : MonoBehaviour
{
	private int hpPlayer;

	private int hpMita;

	private bool canButtonDown;

	private float timeTimerMili;

	private int timeTimer;

	private float reactionTimeMita;

	private bool playerWantButtonDown;

	private bool playerWantButtonDownBed;

	private float timeStartPlay;

	private float timePlayerWin;

	private float timeMitaWin;

	[Header("Интерфейс")]
	[SerializeField]
	private Image[] heartsPlayer;

	[SerializeField]
	private Image[] heartsMita;

	[SerializeField]
	private Text timer;

	[SerializeField]
	private Image imgCanButton;

	[SerializeField]
	private Image imgCantButton;

	[SerializeField]
	private Sprite spriteHeartBroke;

	[SerializeField]
	private Image imgSad;

	[SerializeField]
	private Image imgSmile;

	[Header("Анимации")]
	[SerializeField]
	private Location7_HammerButton_Animations animations;

	[SerializeField]
	private Animator animButton;

	[SerializeField]
	private Interface_KeyHint_Key keyDownButton;

	private int playerDialogueActive;

	private int MitaDialogueActive;

	[Header("События")]
	[SerializeField]
	private GameObject[] playerDialogueWin;

	[SerializeField]
	private GameObject[] mitaDialogueWin;

	private float noiseTimer;

	[Header("Звуки")]
	[SerializeField]
	private AudioSource audioInterface;

	[SerializeField]
	private AudioClip soundTik;

	[SerializeField]
	private AudioClip soundStop;

	[SerializeField]
	private AudioClip soundGo;

	private bool smoothDestroy;

	[SerializeField]
	[Header("Плавное удаление")]
	private Image imgSmoothDestroy;

	[SerializeField]
	private GameObject[] objectsDestroy;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void AudioPlay(AudioClip _sound)
	{
	}

	private void StartTimer()
	{
	}

	public void ButtonOn()
	{
	}

	public void PlayGame()
	{
	}

	public void ButtonDownPlayer()
	{
	}

	public void ButtonDownMita()
	{
	}

	private void PlayerDamage()
	{
	}

	private void MitaDamage()
	{
	}

	public void KeyButtonPlayer()
	{
	}

	public void MitaHammerDrop()
	{
	}

	public void PlayerHammerDrop()
	{
	}

	public void SmoothDestroy()
	{
	}
}
