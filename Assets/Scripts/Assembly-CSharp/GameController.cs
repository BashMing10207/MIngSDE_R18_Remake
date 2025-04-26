using System.Collections.Generic;
using Colorful;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
	public static bool tetrisRemove;

	private PlayerMove scrpm;

	private PlayerPersonIK scrppik;

	[HideInInspector]
	public float crosshairSize;

	private bool crosshairHide;

	private bool crosshairHideOnly;

	private Camera cameraPlayer;

	private bool showCursor;

	private DialogueChanger dialogueChanger;

	private float timeHideCrosshair;

	private float timeShowKeyRemoveTetris;

	[Header("Интерфейс")]
	public bool canChangeItemForHands;

	public bool showInventoryForHands;

	public Image imgMouseCast;

	public Image imgMouse;

	public GameObject prefabFastMenu;

	private GameObject fastMenuObject;

	public GameObject prefabPhotoMode;

	private GameObject photomodeObject;

	[HideInInspector]
	public bool photomode;

	public Animator hintScreen;

	private float timeShowHint;

	[HideInInspector]
	public bool showHint;

	public AudioClip soundHintShow;

	public AudioClip soundHintHide;

	[SerializeField]
	private Interface_KeyHint_Key keyEscapeTetris;

	private AsyncOperation asyncLoadNextScene;

	[Header("Интерфейс загрузки")]
	public Image imgLoadingAsync;

	private float timePrint;

	[HideInInspector]
	public List<TextDialogueMemory> dialoguesMemory;

	[HideInInspector]
	public float timePrintWas;

	private bool orderText;

	private Dialogue_3DText dialogueTextNow;

	[Header("Интерфейс диалог")]
	public Image imageFrameDialogue;

	public Text textDialogueA;

	public Text textDialogueB;

	[HideInInspector]
	public bool isPaused;

	private Component[] soundsPauseA;

	private Component[] soundsPauseB;

	private Component[] audioReverbs;

	private Component[] canvasesPause;

	private bool pauseWasBlur;

	private float timeScaleWas;

	private bool isLoadingPause;

	private bool mouseWasVisible;

	private CursorLockMode mouseWasLock;

	[HideInInspector]
	public UnityEvent scriptEventPauseStart;

	[HideInInspector]
	public UnityEvent scriptEventPauseStop;

	[Header("Пауза")]
	public GaussianBlur blurCamera;

	[SerializeField]
	private GameObject[] objectsHidePause;

	private RaycastHit hit;

	[HideInInspector]
	public int timeLightCast;

	[Header("Слои")]
	public LayerMask layerPlayer;

	public LayerMask layerWall;

	public LayerMask layerMouse;

	public LayerMask layerPhysic;

	public LayerMask layerPhysicSound;

	private List<GameObject> inventoryKeysCase;

	[Header("Инвентарь")]
	public GameObject inventoryKeysCaseExample;

	[HideInInspector]
	public UnityEvent eventItemKeyAdd;

	[HideInInspector]
	public UnityEvent eventItemKeyRemove;

	[HideInInspector]
	public bool cutsceneRun;

	private bool canCastOff;

	[Header("Каст")]
	public GameObject objectCast;

	[HideInInspector]
	public bool firstPersonPlay;

	private float timeAFK;

	private bool needTetris;

	[HideInInspector]
	public bool tetrisPlay;

	[Header("Бездействует")]
	public TetrisGame tetrisComponent;

	public GameObject tetrisObject;

	public ObjectAnimationPlayer animationPlayerTetris;

	private float audioBrainIntensity;

	[Header("Звуки")]
	[SerializeField]
	private AudioChorusFilter audioBrain;

	private float timeGameplay;

	private void Awake()
	{
	}

	public void StartComponent()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	public void CutscenePlay(Transform _cameraTarget)
	{
	}

	public void CutsceneStop()
	{
	}

	public void FastMenuClose()
	{
	}

	public void FastMenuOpen()
	{
	}

	public void Pause(bool x, bool _isLoading)
	{
	}

	public void ExitGame()
	{
	}

	private void CursorSave(bool _save)
	{
	}

	public void HideCrosshireOnly(bool x)
	{
	}

	public void HideCrosshair(bool x)
	{
	}

	public void HideCrosshair(bool _crosshair, bool _cursor)
	{
	}

	public void ShowCursor(bool x)
	{
	}

	public void DialogueChangerStart(DialogueChanger _object)
	{
	}

	public void ShowHint(string _text, Vector2 _position)
	{
	}

	public void HintNull()
	{
	}

	public void PrintDialogue(Dialogue_3DText _componentDialogue, bool _boxVisible)
	{
	}

	public void DialogueAdd(Dialogue_3DText _componentDialogue, string _text)
	{
	}

	public void AddKeyItem(GameObject _item)
	{
	}

	public void RemoveKeyItem(GameObject _item)
	{
	}

	public int GetKeyItem(GameObject _item)
	{
		return 0;
	}

	public void FirstPersonPlay(bool x)
	{
	}

	public void StartSceneLoadAsync(AsyncOperation _async)
	{
	}

	public void FinishSceneLoadAsync()
	{
	}

	public void SceneLoadAsyncReady()
	{
	}

	public void CastObjects(bool x)
	{
	}

	public void AudioBrain(float _intensity)
	{
	}

	public void TetrisPlay(bool x)
	{
	}

	public void TetrisStop()
	{
	}

	public void NeedTetris()
	{
	}

	public void PhotomodeActive(bool x)
	{
	}

	[ContextMenu("Тестировать тетрис")]
	public void TetrisStart()
	{
	}

	public void ResetPlayer()
	{
	}
}
