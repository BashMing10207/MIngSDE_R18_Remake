using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Location15_ScreenID : MonoBehaviour
{
	private string IDplayer;

	[Header("Тексты")]
	[SerializeField]
	private Text[] textScreens;

	[SerializeField]
	private Text textMainScreen;

	[SerializeField]
	private GameObject[] boxesZoom;

	private bool win;

	private float timeReady;

	private string textEnter;

	private int indexChange;

	private bool play;

	[SerializeField]
	[Header("Управление")]
	private GameObject[] casesNum;

	[SerializeField]
	private RectTransform caseChange;

	[SerializeField]
	private Sprite spriteOk;

	[SerializeField]
	private UnityEvent eventReady;

	[SerializeField]
	private Interface_KeyHint_Key keyCancel;

	[SerializeField]
	private Interface_KeyHint_Key keyInteractive;

	private float timeAnimationJump;

	[Header("Анимации")]
	[SerializeField]
	private AnimationCurve animationJump;

	[SerializeField]
	private RectTransform rectCheck;

	[SerializeField]
	private RectTransform rectOpenDoor;

	[Header("Звуки")]
	[SerializeField]
	private Audio_Data audioInput;

	[SerializeField]
	private AudioSource audioMonitor;

	[SerializeField]
	private AudioClip soundEnterOpen;

	[SerializeField]
	private AudioClip soundEnterNone;

	[SerializeField]
	private AudioClip soundReset;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void PlayPlayer()
	{
	}

	public void StopPlayer()
	{
	}

	private void ChangeUpdate()
	{
	}

	private void ClickButton()
	{
	}
}
