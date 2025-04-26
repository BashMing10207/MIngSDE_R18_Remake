using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Tamagotchi_Main : MonoBehaviour
{
	public int energy;

	public int money;

	private GameObject castObject;

	private Camera cmr;

	[Header("Чиби Мита")]
	[SerializeField]
	private LayerMask layerChibi;

	[SerializeField]
	private GameObject chibiMita;

	[SerializeField]
	private ParticleSystem heartChibi;

	[SerializeField]
	[Header("Дом")]
	private GameObject objectHouse;

	[SerializeField]
	private Tamagotchi_Room[] rooms;

	[SerializeField]
	private int indexRoomShow;

	[SerializeField]
	private Color colorAmbientReal;

	[SerializeField]
	private Color colorAmbientTamagotchi;

	private float timeAnimationGetMoney;

	private bool buttonsMove;

	[Header("Интерфейс")]
	[SerializeField]
	private bool showInterface;

	[SerializeField]
	private bool showButtonShop;

	[SerializeField]
	private bool showButtonGames;

	[SerializeField]
	private bool sprBlackScreenHide;

	[SerializeField]
	private GameObject objectDialogue;

	[SerializeField]
	private RectTransform rectLife;

	[SerializeField]
	private Text textMoney;

	[SerializeField]
	private ButtonMouseClickBubble buttonRight;

	[SerializeField]
	private ButtonMouseClickBubble buttonLeft;

	[SerializeField]
	private RectTransform blackLeft;

	[SerializeField]
	private RectTransform blackRight;

	[SerializeField]
	private RectTransform buttonShop;

	[SerializeField]
	private RectTransform buttonGame;

	[SerializeField]
	private RectTransform rectCoins;

	[SerializeField]
	private GameObject buttonCloseWindows;

	[SerializeField]
	private GameObject buttonCloseMiniGame;

	[SerializeField]
	private Image imageScreen;

	[SerializeField]
	private GameObject frameAddMoney;

	[SerializeField]
	private SpriteRenderer spriteBlackScreen;

	[SerializeField]
	private Text textEnergy;

	[SerializeField]
	private AnimationCurve aniamtionEnergyAlpha;

	private float timeEnergyAlpha;

	[SerializeField]
	private RectTransform lineHunger;

	[SerializeField]
	private RectTransform lineMood;

	[SerializeField]
	private Tamagotchi_BuyCase[] casesBuy;

	[SerializeField]
	private RectTransform backgroundGame;

	[SerializeField]
	private RectTransform backgroundShop;

	[SerializeField]
	private AnimationCurve animationGetMoney;

	private bool addoneWindowActive;

	[SerializeField]
	[Header("Дополнительные окна")]
	private Tamagotchi_WindowButtons windowShop;

	[SerializeField]
	private Tamagotchi_WindowButtons windowMiniGames;

	private Transform cameraTransform;

	private bool play;

	private Tamagotchi_MiniGame minigameNow;

	private bool playMinigame;

	[Header("Сюжетная часть")]
	[SerializeField]
	private Location1Main worldLocation1;

	private bool animationCameraZoom;

	private float timeCameraAnimation;

	[SerializeField]
	private AnimationCurve animationCurveCameraZoom;

	[SerializeField]
	private UnityEvent eventAnimationZoomBack;

	private bool zoomBack;

	[SerializeField]
	private UnityEvent eventAnimationZoomStop;

	[Header("Звуки")]
	[SerializeField]
	private AudioSource audioOpenShop;

	[SerializeField]
	private AudioSource audioOpenMinigame;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	public void GameStart()
	{
	}

	public void GameStop()
	{
	}

	public void RightRoom()
	{
	}

	public void LeftRoom()
	{
	}

	public void ButtonShop()
	{
	}

	public void ButtonMiniGames()
	{
	}

	public void ButtonCloseWindowButtons()
	{
	}

	public void MoneyAdd(int x)
	{
	}

	public void MiniGamePlay(Tamagotchi_MiniGame _game)
	{
	}

	public void MiniGameStop()
	{
	}

	public void EnergyAlphaAnimation()
	{
	}

	public void NewDay()
	{
	}

	public void DayMiniGame()
	{
	}

	public void ShowInterface(bool x)
	{
	}

	public void ShowButtonGames(bool x)
	{
	}

	public void ShowButtonShop(bool x)
	{
	}

	public void HideFastBlackScreen(bool x)
	{
	}

	public void BlinkBlackScreen()
	{
	}

	public void HideBlackScreen(bool x)
	{
	}

	public void UpdateCasesBuy()
	{
	}

	public void CameraChangeRoomFast(int _index)
	{
	}

	public void BlackScreenClick()
	{
	}

	public void CanMoveRoom(bool x)
	{
	}

	public void AnimationCameraZoom()
	{
	}

	private void CameraFix()
	{
	}
}
