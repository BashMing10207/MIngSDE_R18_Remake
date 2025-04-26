using Coffee.UIEffects;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Location18_Novella : MonoBehaviour
{
	[Header("Глобальные настройки")]
	[SerializeField]
	private UnityEvent pauseStart;

	[SerializeField]
	private UnityEvent pauseStop;

	private bool controllDialogue;

	private bool dialogueShow;

	private float timeAlphaDialogue;

	private float alphaButtonNext;

	private UIGradient gradientText;

	[Header("Диалог")]
	[SerializeField]
	private GameObject personagesSpriteExample;

	[SerializeField]
	private Location18_Personage[] personages;

	[SerializeField]
	private Text textDialogueName;

	[SerializeField]
	private Text textDialogue;

	[SerializeField]
	private Image imageDialogueFrame;

	[SerializeField]
	private Image imageDialogueNext;

	[SerializeField]
	private AnimationCurve animationNext;

	private float timeAnimationNext;

	private Location18_Dialogue dialoguePlay;

	private int indexStringDialogue;

	private int indexDialogue;

	private bool playPrint;

	private float timeNextPrint;

	private int countSoundPlay;

	private int countSoundPlayMax;

	private string textNeed;

	private Sprite spriteBackground;

	private GameObject objectActiveRechangeBackground;

	private UnityEvent eventRechangeBackground;

	[Header("Фон")]
	[SerializeField]
	private Image background;

	[SerializeField]
	private RectTransform screenPersonages;

	[SerializeField]
	private Transform cameraT;

	private float shak;

	private int indexAudioNext;

	[Header("Звуки")]
	[SerializeField]
	private AudioSource audioMain;

	[SerializeField]
	private AudioSource audio1;

	[SerializeField]
	private AudioSource audio2;

	[SerializeField]
	private AudioSource audio3;

	[SerializeField]
	private AudioSource audio4;

	[SerializeField]
	private AudioSource audio5;

	[SerializeField]
	private AudioSource audioNext;

	[SerializeField]
	private AudioSource audioReady;

	private float timeWasObject;

	private GameObject objectImageSelect;

	public void StartComponent()
	{
	}

	private void Update()
	{
	}

	private void UpdateDialogue()
	{
	}

	private void DialoguePrintFinish()
	{
	}

	public void PlayDialogue(Location18_Dialogue _dialogue)
	{
	}

	public void NextDialogue()
	{
	}

	private void StyleText(Location18_Personage _personage)
	{
	}

	public void PauseStart()
	{
	}

	public void PauseStop()
	{
	}

	public void CanControll(bool x)
	{
	}

	public void HideAllPersonages()
	{
	}

	public void FinishNovella()
	{
	}

	public void NextBackground(Sprite _sprite)
	{
	}

	public void NextBackgroundFast(Sprite _sprite)
	{
	}

	public void NextBackgroundSimpleFast(Sprite _sprite)
	{
	}

	public void Shak(float x)
	{
	}

	public void AudioNext(AudioClip _sound)
	{
	}

	public void AudioPlay(AudioClip _sound)
	{
	}

	public void EventRechangeBackground(UnityEvent _event)
	{
	}

	public void ObjectActiveRechangeBackground(GameObject _object)
	{
	}

	public void EnterMouse(GameObject _object)
	{
	}

	public void ExitMouse()
	{
	}
}
