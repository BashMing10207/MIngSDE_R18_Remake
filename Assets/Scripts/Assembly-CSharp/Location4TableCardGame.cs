using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Location4TableCardGame : MonoBehaviour
{
	[Header("Установки")]
	[SerializeField]
	private Location4TableCardGame_CardMemory[] cardsGeneral;

	[SerializeField]
	private Location4TableCardGame_CardHold[] cardsPlayer;

	[SerializeField]
	private Location4TableCardGame_CardHold[] cardsMita;

	private bool playerHoldCards;

	private bool mitaHoldCards;

	[Header("Механика")]
	[SerializeField]
	private Animator animMita;

	[SerializeField]
	private GameObject fishka;

	[SerializeField]
	private Mesh[] meshFishka;

	[SerializeField]
	private GameObject exampleCard;

	[SerializeField]
	private BoxCollider boxZoom;

	private FullBodyBipedIK scrfbbik;

	private int indexCard;

	private int indexCardThrow;

	private bool showCards;

	private bool canShowCards;

	private Transform elbowRightPlayer;

	[Header("Игрок")]
	[SerializeField]
	private Transform pivotCardsPlayer;

	[SerializeField]
	private Transform rightHandPlayer;

	[SerializeField]
	private ObjectAnimationPlayer animationThrowPlayer;

	[SerializeField]
	private Transform positionThrowPlayer;

	[SerializeField]
	private Transform boneRightItemPlayer;

	private Transform boneRightItemPlayerOrigin;

	private int indexCardMitaThrow;

	private int indexCardMitaTakeForThrow;

	[Header("Мита")]
	[SerializeField]
	private Transform pivotCardsMita;

	[SerializeField]
	private Transform positionThrowMita;

	[SerializeField]
	private Transform mitaBoneLeftItem;

	[SerializeField]
	private Transform mitaBoneLeftItemLate;

	[SerializeField]
	private Transform mitaBoneRightItem;

	[SerializeField]
	private Transform mitaBoneRightItemLate;

	private int _cnt;

	private int typeFishkaNow;

	private float stepGame;

	private int countSteps;

	private float timeStepGame;

	private float StopGameTime;

	private bool gameStop;

	private bool play;

	private int scorePlayer;

	private int scoreMita;

	[SerializeField]
	[Header("Прерывание игры")]
	private UnityEvent eventStopGame;

	[SerializeField]
	private UnityEvent eventCloseScarf;

	private bool cardMitaShow;

	[Header("Интерфейс")]
	[SerializeField]
	private RectTransform rectCardMita;

	[SerializeField]
	private RectTransform rectFishka;

	[SerializeField]
	private RectTransform rectTableScore;

	[SerializeField]
	private Text textScore;

	[SerializeField]
	private Sprite iconHeart;

	[SerializeField]
	private Sprite iconDamage;

	[SerializeField]
	private Sprite iconShield;

	[SerializeField]
	[Header("Кнопки")]
	private Interface_KeyHint_Key buttonShowCards;

	[SerializeField]
	private Interface_KeyHint_Key buttonHideCards;

	[SerializeField]
	private Interface_KeyHint_Key buttonThrowCard;

	[SerializeField]
	private Interface_KeyHint_Key buttonRightCard;

	[SerializeField]
	private Interface_KeyHint_Key buttonLeftCard;

	[Header("Диалоги")]
	[SerializeField]
	private GameObject[] dialogues;

	[Header("Звук")]
	[SerializeField]
	private AudioClip[] soundsCardDrop;

	[SerializeField]
	private AudioClip[] soundsCardTake;

	[SerializeField]
	private AudioClip[] soundsChangeCard;

	[SerializeField]
	private AudioClip soundCardShow;

	[SerializeField]
	private AudioClip soundCardHide;

	[SerializeField]
	private AudioSource audioCardStackPlayer;

	[SerializeField]
	private AudioSource audioCardStackMita;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void RightCard()
	{
	}

	private void LeftCard()
	{
	}

	public void StartGame()
	{
	}

	private void StopGame()
	{
	}

	private void MitaStartThrowCard()
	{
	}

	private void PlayerChangeCard()
	{
	}

	private void ShowCard(bool x)
	{
	}

	private void LookResult()
	{
	}

	private void LookResultSpeak()
	{
	}

	public void PlayerTakeCard()
	{
	}

	public void MitaTakeCard()
	{
	}

	public void ReChangeFishka()
	{
	}

	public void MitaThrowCard()
	{
	}

	public void MitaTakeLeftHandCard()
	{
	}

	public void PlayerTakeCardInLeftHand()
	{
	}

	public void PlayerThrowCard()
	{
	}
}
