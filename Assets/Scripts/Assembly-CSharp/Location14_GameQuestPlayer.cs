using Coffee.UIEffects;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Location14_GameQuestPlayer : MonoBehaviour
{
	private int indexAnimation;

	private Vector3 cameraSavePositionOrigin;

	private Quaternion cameraSaveRotationOrigin;

	[Header("Стартовая анимация")]
	public UnityEvent eventFinishStart;

	[SerializeField]
	private Transform cameraPosition;

	[SerializeField]
	private Transform cameraAniamtion;

	[SerializeField]
	private Location14_MonitorScreenLoad loadScreenshots;

	private int indexInside;

	private bool nextDayPlay;

	[Header("Игра")]
	[SerializeField]
	private Location14_MonitorScreenLoad screenMonitor;

	[SerializeField]
	private Location14_QuestInteractive interactiveChair;

	[SerializeField]
	private GameObject[] interactives;

	[SerializeField]
	private UnityEvent eventNewDay;

	[SerializeField]
	private UnityEvent event3Inside;

	[SerializeField]
	private UnityEvent eventBackDayLite;

	[SerializeField]
	private UnityEvent eventBackDayLast;

	[SerializeField]
	private UnityEvent eventLastClickPlayer;

	[Header("Интерфейс")]
	[SerializeField]
	private Image blackScreen;

	[SerializeField]
	private Transform cameraScreenShot;

	private float timeDontClickSkip;

	private Location14_Dialogue componentDialogue;

	private int indexDialogue;

	private int indexDialogueSpeaker;

	private bool dialoguePrint;

	private float timeDialoguePrint;

	private string dialogueTextNeed;

	private bool waitQuest;

	private Location14_Dialogue.Loc14WhioSpeak whoSpeak;

	[SerializeField]
	[Header("Диалог")]
	private Image frameDialogue;

	[SerializeField]
	private Text textDialogue;

	[SerializeField]
	private Location14_ButtonChangeDialogue changeDialogueLeft;

	[SerializeField]
	private Location14_ButtonChangeDialogue changeDialogueRight;

	[SerializeField]
	private UIGradient gradientDialogue;

	[SerializeField]
	private UIShadow textShadow;

	[SerializeField]
	private Color[] colorPlayer;

	[SerializeField]
	private Color[] colorMita;

	private bool ikActive;

	private Transform targetLook;

	private int cursorOther;

	private Camera cameraMain;

	[HideInInspector]
	public bool canObjectMouse;

	[HideInInspector]
	public GameObject objectMouse;

	[Header("Управление игроком")]
	[SerializeField]
	private LayerMask layerMousePlane;

	[SerializeField]
	private Location14_PlayerQuest player;

	[SerializeField]
	private ParticleSystem particlePointer;

	[SerializeField]
	private Texture2D cursorLook;

	[SerializeField]
	private Texture2D cursorWalk;

	[SerializeField]
	private Transform[] pointerLook;

	[SerializeField]
	private LookAtIK[] ikPlayer;

	[HideInInspector]
	public AudioSource au;

	[SerializeField]
	[Header("Звуки")]
	private AudioSource audioSpeaker;

	[SerializeField]
	private AudioClip soundSpeakMita;

	[SerializeField]
	private DataValues_Sounds soundSpeakPlayer;

	[SerializeField]
	private AudioClip soundSpace;

	[SerializeField]
	private AudioClip soundChange;

	public AudioClip soundEnterChange;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	public void ClickMouse()
	{
	}

	public void DialoguePlay(Location14_Dialogue _dialogue)
	{
	}

	private void DialogueNext()
	{
	}

	private void DialogueStop()
	{
	}

	public void ChangeDialogue(bool _side)
	{
	}

	public void PrintFinish()
	{
	}

	public void EnterDialogueChange()
	{
	}

	public void PlayerLookTarget(Transform _targetLook)
	{
	}

	public void PlayerLookStop()
	{
	}

	public void NewDay()
	{
	}

	public void StartNextDay()
	{
	}

	public void StopQuestGame()
	{
	}

	public void PlayerActivationIK(bool x)
	{
	}

	public void ActiveInteractives(bool x)
	{
	}
}
