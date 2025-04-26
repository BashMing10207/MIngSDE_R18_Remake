using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Location14_Days : MonoBehaviour
{
	[SerializeField]
	private int days;

	[SerializeField]
	private float speedDay;

	private bool black;

	[Header("Интерфейс")]
	[SerializeField]
	private Text number1;

	[SerializeField]
	private Text number2;

	[SerializeField]
	private Text number3;

	[SerializeField]
	private Image blackScreen;

	[SerializeField]
	private Animator animFrameDay;

	private int indexEventDay;

	private float timeNextHint;

	private float timeBlackLerp;

	private int objectsTrashIndex;

	[Header("Дни")]
	[SerializeField]
	private UnityEvent eventNewDay;

	[SerializeField]
	private UnityEvent eventStartLastDay;

	[SerializeField]
	private UnityEvent eventStartSkipDay;

	[SerializeField]
	private Location14_DaysPart[] parts;

	[SerializeField]
	private GameObject hintSitBed;

	[SerializeField]
	private GameObject hintStayBed;

	[SerializeField]
	private Location14_PCGames pcGames;

	[SerializeField]
	private ArrayObjects[] objectsTrash;

	private float skipDaysTimeNextAnimation;

	private float skipDaysTimeNextAnimationMax;

	private bool playAnimationSkipDays;

	private float timeAnimationSkipDays;

	[Header("Анимация")]
	[SerializeField]
	private AnimationCurve animationSkipDays;

	[SerializeField]
	private GameObject objectHint;

	[SerializeField]
	private GameObject[] objectsHint;

	[SerializeField]
	private AudioSource audioSkipDays;

	[Header("Костюм")]
	[SerializeField]
	private GameObject suitOffice;

	[SerializeField]
	private GameObject suitSleep;

	[SerializeField]
	[Header("Звуки")]
	private AudioSource[] audiosUsual;

	[SerializeField]
	private GameObject[] audiosObjectUsual;

	[SerializeField]
	private AudioClip soundTickFast;

	[SerializeField]
	private AudioSource audioTick;

	private bool night;

	[Header("Освещение")]
	[SerializeField]
	private float timeDay;

	[SerializeField]
	private float timeDayNeed;

	[SerializeField]
	private AnimationCurve animationLighting;

	[SerializeField]
	private AnimationCurve animationLightingA;

	[SerializeField]
	private AnimationCurve animationLightingB;

	[SerializeField]
	private Animator animatorSun;

	[SerializeField]
	private RealRoom_Lamp lamp;

	[SerializeField]
	private MeshRenderer[] meshesWindow;

	[SerializeField]
	private MeshRenderer[] streetLight;

	[SerializeField]
	[ColorUsage(false, true)]
	private Color colorWindowMorning;

	[SerializeField]
	[ColorUsage(false, true)]
	private Color colorWindowDay;

	[SerializeField]
	[ColorUsage(false, true)]
	private Color colorWindowEvening;

	[SerializeField]
	private Color colorLightingMorning;

	[SerializeField]
	private Color colorLightingDay;

	[SerializeField]
	private Color colorLightingEvening;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void StartGame()
	{
	}

	[ContextMenu("Следующий день")]
	private void NextDay()
	{
	}

	[ContextMenu("Запустить ускорение")]
	private void StartSkipDays()
	{
	}

	private void TimeBlackLerp(AnimationClip animationClip)
	{
	}

	private void BlackAnimationEnd()
	{
	}

	public void AudioActivation(bool x)
	{
	}

	public void GoStopSleep()
	{
	}

	public void GoSitBed()
	{
	}

	public void GoStayBed()
	{
	}

	public void GoWashUp()
	{
	}

	public void GoDressMe()
	{
	}

	public void GoCook()
	{
	}

	public void GoSitPC()
	{
	}

	public void GoOnPC()
	{
	}

	public void GoEat()
	{
	}

	public void GoStopEatStartWork()
	{
	}

	public void GoFinishWork()
	{
	}

	public void GoUndressMe()
	{
	}

	public void GoWashDown()
	{
	}

	public void GoLieDown()
	{
	}

	public void GoSleep()
	{
	}

	private void UpdateLightDay()
	{
	}

	public void SuitPlayer(bool x)
	{
	}
}
