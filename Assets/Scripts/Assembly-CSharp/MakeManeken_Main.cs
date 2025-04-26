using Colorful;
using UnityEngine;
using UnityEngine.UI;

public class MakeManeken_Main : MonoBehaviour
{
	private bool finishGame;

	private float timeFinishGame;

	private float timeShowWin;

	private float timeBed;

	private float timeGood;

	private float timeCameraBack;

	private int indexLampProgress;

	[Header("Сценарий")]
	[SerializeField]
	private GameObject[] lampProgress;

	private string nameFileLanguage;

	private float timeTutorial;

	private int stepTutorial;

	private int stepSubTutorial;

	private float timeAnimationDialogue;

	private bool showDialogue;

	private RectTransform rectDialogue;

	[HideInInspector]
	public bool tutorial;

	[SerializeField]
	[Header("Обучение")]
	private MakeManeken_Interactive[] allInteractives;

	[SerializeField]
	private GameObject interfaceDialogue;

	[SerializeField]
	private Text textSpeak;

	[SerializeField]
	private AnimationCurve animationDialogue;

	[HideInInspector]
	public GameObject objectCast;

	private int typeInfoGame;

	private float timeInfoGame;

	private float timeAfterPause;

	private bool dontCast;

	private RaycastHit hit;

	[Header("Физика")]
	[SerializeField]
	private LayerMask layerCast;

	private float timeCameraAnimation;

	private Vector3 positionCameraWas;

	private Vector3 positionCameraNeed;

	private Vector3 positionCameraAdd;

	private Vector3 positionCameraAddWas;

	private Vector3 positionCameraAddNeed;

	private float FOVCameraWas;

	private float FOVCameraNeed;

	private Camera cameraMain;

	private int positionCamera;

	private Vector3 positionMouse;

	private Vector3 positionMouseNeed;

	private float timeAnimationCameraPositionAdd;

	private float timeRotationCamera;

	private Vector3 cameraRotationWas;

	private Vector3 cameraRotationNeed;

	private Vector3 cameraRotation;

	[Header("Камера")]
	[SerializeField]
	private AnimationCurve animationCameraMove;

	[SerializeField]
	private GaussianBlur gaussian;

	[SerializeField]
	private Canvas canvasGame;

	private string textNeedTip;

	private string textNeedInfo;

	private Text textMonitorTip;

	[Header("Монитор")]
	[SerializeField]
	private Text textTip;

	[SerializeField]
	private Text textInfo;

	private GameObject tapeInstance;

	private bool lookTape;

	[SerializeField]
	[Header("Пленка")]
	private GameObject tapeExample;

	[SerializeField]
	private Texture2D[] tapeTextures;

	private float timeManekenAnimation;

	private float timeManekenThere;

	private float timeAnimationLightScanned;

	private float timeFall;

	private float timeGetBox;

	private int indexBedManeken;

	private int badIndexAnimation;

	private bool lastRedManeken;

	[SerializeField]
	[Header("Манекен")]
	private Light lightManeken;

	[SerializeField]
	private AnimationCurve lightManekenScanned;

	[SerializeField]
	private Animator animManeken;

	[SerializeField]
	private Animator animMita;

	[SerializeField]
	private Animator animPress;

	[SerializeField]
	private Animator animWorld;

	[SerializeField]
	private Animator animFloor;

	[SerializeField]
	private GameObject[] angryObjects;

	[SerializeField]
	private ParticleSystem[] particlesEmotions;

	[SerializeField]
	private SpriteRenderer screenflash;

	[Header("Кнопки")]
	[SerializeField]
	private MakeManeken_Interactive buttonSwitch;

	[SerializeField]
	private GameObject box;

	[SerializeField]
	private MakeManeken_Interactive[] onBox;

	private int monitorPrintSound;

	[SerializeField]
	[Header("Звуки")]
	private AudioSource audioHatch;

	[SerializeField]
	private AudioSource audioMonitorPrint;

	[SerializeField]
	private AudioSource audioMonitorFinish;

	[SerializeField]
	private AudioSource audioSwitchReady;

	[SerializeField]
	private AudioSource audioScanning;

	[SerializeField]
	private AudioSource audioWindCamera;

	[SerializeField]
	private AudioSource audioSignal;

	[SerializeField]
	private AudioClip soundSignalGood;

	[SerializeField]
	private AudioClip soundSignalBed;

	[SerializeField]
	private AnimationCurve animationVolumeWind;

	[SerializeField]
	[Header("Сцена")]
	private Light_Color lightScene;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void Click()
	{
	}

	public void RepositionCamera(int _index)
	{
	}

	public void DontCast(bool x)
	{
	}

	public void Scanned()
	{
	}

	public void LookTape(bool x)
	{
	}

	private void CameraPositionAdd(Vector3 _newPosition)
	{
	}

	private void CameraRotation(Vector3 _newRotation)
	{
	}

	public void ManekenHello()
	{
	}

	public void ButtonAnimation(int _index)
	{
	}

	public void ButtonEmotion(int _index)
	{
	}

	public void SiwtchGet(bool x)
	{
	}

	public void PressReady()
	{
	}

	public void ThrowBox()
	{
	}

	public void MitaGetBox()
	{
	}

	private void ScreenFlash()
	{
	}

	public void TutorialCheckTape(float _posX, float _posY)
	{
	}

	private void PregressMove(bool x)
	{
	}

	private void InfoGame()
	{
	}

	private void InfoGameForce()
	{
	}

	private void FinishGame()
	{
	}

	private void OnGUI()
	{
	}
}
