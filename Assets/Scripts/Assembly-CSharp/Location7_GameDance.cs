using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Location7_GameDance : MonoBehaviour
{
	private int indexScreenGame;

	private bool screenNextStart;

	[SerializeField]
	[Header("Экран")]
	private GameObject imgMainScreen;

	[SerializeField]
	private Image imgScreen;

	[SerializeField]
	private GameObject objectMenu;

	[SerializeField]
	private GameObject objectGame;

	[Header("Освещение")]
	[SerializeField]
	private Color colorDance;

	[SerializeField]
	private Color[] colorDanceSide;

	private float timeButtonMidLight;

	private float timeButtonRightLight;

	private float timeButtonLeftLight;

	[Header("Кнопки")]
	[SerializeField]
	private MeshRenderer[] buttonsLight;

	[SerializeField]
	[ColorUsage(true, true)]
	private Color[] buttonsLightColors;

	[Header("Меню музыки")]
	[SerializeField]
	private Image imgLeft;

	[SerializeField]
	private Image imgRight;

	[SerializeField]
	private Image imgLeftAlpha;

	[SerializeField]
	private Image imgRightAlpha;

	[SerializeField]
	private Text textNameMusic;

	private int musicIndexPlay;

	private float timeMusicPlay;

	private int countSpheres;

	private AudioSource audioMusic;

	private float timeUpdateTimeMusic;

	[Header("Музыка")]
	[SerializeField]
	private Location7_GameDance_Music[] music;

	[SerializeField]
	private AudioSource audioTap;

	private int scorePlayer;

	private int scoreMita;

	private int timeStart;

	private float timeStartMili;

	private float timeFinishMusic;

	private bool canMiss;

	private bool playMusic;

	private bool needUpdateSphere;

	[Header("Игровые объекты")]
	[SerializeField]
	private GameObject exampleSphere;

	[SerializeField]
	private ParticleSystem particleLeftOk;

	[SerializeField]
	private ParticleSystem particleMidOk;

	[SerializeField]
	private ParticleSystem particleRightOk;

	[SerializeField]
	private ParticleSystem particleLeftNo;

	[SerializeField]
	private ParticleSystem particleMidNo;

	[SerializeField]
	private ParticleSystem particleRightNo;

	[SerializeField]
	private Image[] imageOk;

	[SerializeField]
	private RectTransform[] lines;

	[SerializeField]
	private float[] noiseLines;

	[SerializeField]
	private Text textScore;

	[SerializeField]
	private Text textTime;

	[SerializeField]
	private AnimationCurve animaitonTimeText;

	private float timeAnimationTimeText;

	[SerializeField]
	private GameObject[] keysPlayer;

	private bool mitaStayOnDance;

	private float timeMitaAnimationOrder;

	private int sideGo;

	[SerializeField]
	[Header("Танец Миты")]
	private Animator_FunctionsOverride animatorMita;

	[SerializeField]
	private Time_Events animationMitaChangeRight;

	[SerializeField]
	private Time_Events animationMitaChangeMid;

	[SerializeField]
	private Time_Events animationMitaChangeLeft;

	[SerializeField]
	private Time_Events animationMitaStartDance;

	[SerializeField]
	private Time_Events animationMitaStopDance;

	[SerializeField]
	private Time_Events[] animationsMitaDance;

	private float timeAnimationPlayerJump;

	private float playerJumpSide;

	[Header("Танцует игрок")]
	[SerializeField]
	private AnimationCurve animationPlayerJump;

	[SerializeField]
	private Transform playerPositionDance;

	[Header("Звуки")]
	[SerializeField]
	private AudioClip soundChangeMusic;

	[SerializeField]
	private AudioClip soundTikTime;

	private int goNextMusicMita;

	private int indexFinishMita;

	private int indexDialogue;

	private int indexDialogueNext;

	[SerializeField]
	[Header("Сюжет")]
	private Time_Events[] mitaFinish;

	[SerializeField]
	private GameObject[] dialgouesWin;

	[SerializeField]
	private GameObject[] dialgouesLose;

	[SerializeField]
	private GameObject[] dialgouesDraw;

	[SerializeField]
	private GameObject[] dialgouesNext;

	[Header("События")]
	[SerializeField]
	private UnityEvent eventFinishPlayer;

	[SerializeField]
	private UnityEvent eventReadyAllMusic;

	[SerializeField]
	private UnityEvent eventDestroyGame;

	[Header("INFO")]
	[SerializeField]
	private List<Location7_GameDance_Sphere> spheres;

	[SerializeField]
	private AnimationCurve animationSphereMoveNow;

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void CreateSphere(int _side)
	{
	}

	private void SpheresUpdate()
	{
	}

	private void MitaJump(int _indexSphere)
	{
	}

	private void RestartDataSpheres()
	{
	}

	private void ScoreAdd(int x)
	{
	}

	private void ScoreShowSize(bool _big)
	{
	}

	public void ButtonSide(int x)
	{
	}

	public void PlayGame()
	{
	}

	public void ButtonMoveMenu(int x)
	{
	}

	public void MitaStayDance(bool x)
	{
	}

	public void PlayGamePlayer()
	{
	}

	public void MitaStopDance()
	{
	}

	public void MitaSpeakResult()
	{
	}

	public void MitaGoNext()
	{
	}

	public void EndGame()
	{
	}

	public void MitaJumpButton(int x)
	{
	}

	private void ChangeMusic()
	{
	}

	private void UpdateTimeMusic()
	{
	}
}
