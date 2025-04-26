using UnityEngine;
using UnityEngine.UI;

public class Tamagotchi_Dialogue : MonoBehaviour
{
	[Header("Мита")]
	public GameObject mitaCamera;

	public Camera mitaCameraCam;

	public AnimationCurve animationCameraClipping;

	public AnimationCurve animationCameraClippingActive;

	public Animator_FunctionsOverride animMitaCamera;

	public MitaPerson mita;

	public Character_Look mitaIkLook;

	[Header("Interface")]
	public Text textDialogue;

	public Text textName;

	public AnimationCurve animationAlpha;

	public Image imageFrame;

	public AudioSource audioStartSound;

	[Space(15f)]
	public Image imgNext;

	public Text textNext;

	private bool play;

	private string stringDialogueNeed;

	private string stringDialogueNow;

	private float timeNextSymbol;

	private Tamagotchi_Dialogue_Mob dialogueRun;

	private int dialogueIndex;

	private float timeDialoueSound;

	private AudioSource audioDialogue;

	private AudioClip[] soundsDialogue;

	private AudioClip audioVoice;

	[Header("Audio")]
	public AudioSource audioNext;

	public AudioSource audioSpeak;

	private float animationMitaPlayNow;

	private float timeAnimationCameraShow;

	private float enableAnimationTime;

	private bool enableDialogue;

	private float timeAnimationMitaCamera;

	private AnimationClip animationIdleAfterMitaCamera;

	private bool showMitaCameraNeed;

	private bool showMitaCemera;

	private float timeWasPause;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void StartDialogue(Tamagotchi_Dialogue_Mob _dialogueRun)
	{
	}

	public void CloseDialogue()
	{
	}

	public void FastCloseDialoue()
	{
	}

	public void NextDialogue()
	{
	}

	public void KeyNextDialogue()
	{
	}

	public void LoadVoice()
	{
	}

	public void ShowCameraMita(bool x)
	{
	}

	public void StopNextIdleAnimation()
	{
	}
}
