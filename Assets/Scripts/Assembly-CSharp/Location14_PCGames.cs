using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Location14_PCGames : MonoBehaviour
{
	private bool gamePlay;

	private Camera cameraPlayer;

	private bool canMouseMove;

	[Header("Интерфейс")]
	[SerializeField]
	private RectTransform mouse;

	[SerializeField]
	private LayerMask mouseLayer;

	[SerializeField]
	private Transform cameraTargetLerp;

	[SerializeField]
	private UI_Alpha screenBack;

	private bool animationMousePlay;

	private int indexAnimationMouse;

	private float timeAnimaitonMouse;

	private float timeWaitAnimationMouse;

	private Location14_AnimationCursor[] animationMouseClass;

	private Vector3 mousePositionWas;

	[SerializeField]
	[Header("Анимация курсора")]
	private AnimationCurve animationMouse;

	[SerializeField]
	private Location14_AnimationCursor[] animationMouseStartPCPrint;

	[SerializeField]
	private Location14_AnimationCursor[] animationMouseFiles;

	[SerializeField]
	private Location14_AnimationCursor[] animationMouseTree;

	[SerializeField]
	private Location14_AnimationCursor[] animationMouseOffPC;

	public int softGame;

	private int indexGame;

	private int indexKeyPrintNeed;

	private int countNeedText;

	[Header("Написание скрипта")]
	[SerializeField]
	private GameObject windowPrint;

	[SerializeField]
	private Text textPrint;

	[SerializeField]
	private Text textKeyDown;

	[SerializeField]
	private RectTransform iconKey;

	private float timeAnimationKeyScale;

	public AnimationCurve keyAnimationScale;

	public Image keyPrint;

	[TextArea(1, 10)]
	public string code;

	[HideInInspector]
	public int windowFileChange;

	[HideInInspector]
	public List<GameObject> filesRed;

	[HideInInspector]
	public List<GameObject> filesYellow;

	[HideInInspector]
	public List<GameObject> filesGreen;

	[HideInInspector]
	public List<GameObject> filesBlue;

	private GameObject fileHold;

	[Header("Перетаскивание файлов")]
	[SerializeField]
	private GameObject windowFiles;

	[SerializeField]
	private GameObject fileExample;

	[SerializeField]
	private Transform windowRed;

	[SerializeField]
	private Transform windowYellow;

	[SerializeField]
	private Transform windowGreen;

	[SerializeField]
	private Transform windowBlue;

	[SerializeField]
	private GameObject[] windowsReport;

	[SerializeField]
	[Header("Дерево")]
	private GameObject windowTree;

	public Slider treeSliderComponentX;

	public Slider treeSliderComponentY;

	public Slider treeSliderComponentZ;

	[SerializeField]
	private AnimationCurve animationSliderLerp;

	[SerializeField]
	private GameObject[] circles;

	[Header("Змейка")]
	[SerializeField]
	private Location14_PCSnaker snakerGame;

	[SerializeField]
	private UnityEvent eventStartGame;

	[SerializeField]
	private UnityEvent eventStopGame;

	private bool otherDayActive;

	private bool screamerNeed;

	[Header("Рабочий стол")]
	[SerializeField]
	private GameObject iconOtherGame;

	[SerializeField]
	private GameObject iconSnakeGame;

	[SerializeField]
	[Header("Другой день")]
	private UnityEvent screamerMita;

	[Header("звуки")]
	[SerializeField]
	private AudioSource audioInterface;

	[SerializeField]
	private Audio_Data audioKeySpray;

	[SerializeField]
	private AudioSource audioMouse;

	[SerializeField]
	private AudioClip[] soundsMouseClick;

	[SerializeField]
	private AudioClip[] soundsMouseClickDown;

	[SerializeField]
	private AudioClip[] soundsMouseClickUp;

	public AudioClip soundFileTake;

	public AudioClip soundFileDrop;

	public AudioClip soundCircleApply;

	public AudioClip soundCircleCan;

	public AudioClip soundCircleNoCan;

	public AudioClip soundCircleNotApply;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void OnEnable()
	{
	}

	public void StartGame()
	{
	}

	public void StopGame()
	{
	}

	private void PlayAnimationMouse(Location14_AnimationCursor[] animation)
	{
	}

	[Button("Активировать другой день", EButtonEnableMode.Always)]
	public void OtherDayActive()
	{
	}

	private void AudioMouseSound(AudioClip[] _sounds)
	{
	}

	public void SoundPlay(AudioClip _sound)
	{
	}

	public void ProgrammActivated(bool x)
	{
	}

	public void OpenPrintGame()
	{
	}

	public void ClickKey()
	{
	}

	public void OpenFilesGame()
	{
	}

	public void SetPositionsFiles(bool _sharply)
	{
	}

	public void FileHold(GameObject _file)
	{
	}

	public void FileUnhold()
	{
	}

	public void OpenTreeGame()
	{
	}

	public void SliderUpdate()
	{
	}

	public void ClickSnakerGame()
	{
	}

	public void ClickSnakerClose()
	{
	}
}
