using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;

public class Dialogue_3DText : MonoBehaviour
{
	public enum Dialogue3DTheme
	{
		Mita = 0,
		MitaOld = 1,
		MitaNew = 2,
		Player = 3,
		ChibiMita = 4,
		MitaKnow = 5,
		Creepy = 6,
		LittleMita = 7,
		White = 8,
		Limping = 9,
		MitaDark = 10,
		MitaDream = 11,
		MitaGlasses = 12,
		MitaFon = 13
	}

	public enum Alignment3DText
	{
		Left = 0,
		Middle = 1,
		Right = 2
	}

	[SerializeField]
	private float sizeHeight;

	[SerializeField]
	private float sizeWidth;

	[SerializeField]
	[Foldout("Префаб")]
	private MeshRenderer boxVisible;

	[Foldout("Префаб")]
	[SerializeField]
	private Font font;

	public int indexString;

	[Range(0f, 0.3f)]
	[SerializeField]
	private float noiseStart;

	[SerializeField]
	private float noise;

	[Foldout("Префаб")]
	public GameObject exampleSymbol;

	public Dialogue3DTheme themeDialogue;

	[SerializeField]
	private Alignment3DText align;

	[SerializeField]
	private float timeShow;

	private bool wasTimeRandomLook;

	private GameObject wasLookObject;

	[Header("Говорящий")]
	[SerializeField]
	private GameObject speaker;

	[SerializeField]
	private EmotionType emotionStart;

	[SerializeField]
	private EmotionType emotionFinish;

	[SerializeField]
	private bool lookOnPlayer;

	[Space(20f)]
	[Header("Конец диалога")]
	[SerializeField]
	private float timeFinish;

	public UnityEvent eventFinish;

	private bool eventFinishOk;

	public UnityEvent eventFinishPrint;

	public GameObject nextText;

	private bool audioPrint;

	private int nextpop;

	private AudioClip audioVoice;

	private float timeSound;

	[HideInInspector]
	public bool voicePlay;

	public DataValues_Sounds sounds;

	[SerializeField]
	private bool voiceNext;

	[Foldout("Настройки")]
	[SerializeField]
	private bool dontSubtitles;

	[Foldout("Настройки")]
	[SerializeField]
	private bool showSubtitles;

	[Foldout("Настройки")]
	[SerializeField]
	private bool dontVoice;

	[Foldout("Настройки")]
	[SerializeField]
	private UnityEvent eventDontVoice;

	private Transform cameraPlayer;

	private GameController scrgc;

	private float timePrint;

	[HideInInspector]
	public bool stop;

	private float xPrint;

	private int indexChar;

	private string textPrint;

	private float sizeSymbol;

	[HideInInspector]
	public string textPrintNow;

	private CharacterInfo ch;

	private List<GameObject> symbolObjects;

	private void Start()
	{
	}

	public void LoadVoice(AudioClip _voice)
	{
	}

	private void Update()
	{
	}

	public void DestroySymbol(GameObject _object)
	{
	}

	public void SymbolJump()
	{
	}

	public void AllJumps()
	{
	}

	public void StopNextDialogue()
	{
	}

	public void StopFastNextDialogue()
	{
	}

	private void SetStyleFont()
	{
	}

	private void SkipDialogue()
	{
	}
}
