using System.Collections.Generic;
using NaughtyAttributes;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.Events;

public class Location21_Cooking : MonoBehaviour
{
	[Header("Основное")]
	public Location21_World main;

	[SerializeField]
	[Header("Диалоги")]
	private GameObject[] dialoguesStart;

	[SerializeField]
	private GameObject[] dialoguesPlayerExit;

	[SerializeField]
	private GameObject[] dialoguesFinish;

	[SerializeField]
	[Header("Выбор игрока")]
	private Location21_IconQuest iconQuest;

	[SerializeField]
	private UnityEvent eventClickQuest;

	[SerializeField]
	[Header("События")]
	private UnityEvent eventStart;

	[SerializeField]
	private UnityEvent eventFinish;

	private PlayerMove scrpm;

	private FullBodyBipedIK scrfbbik;

	private bool ikActive;

	private Transform elbowRightPlayer;

	private Transform playerRightItem;

	[Header("IK")]
	[SerializeField]
	private Transform pivotHandRight;

	public Transform mitaRightItem;

	[SerializeField]
	private Transform mitaRightItem2;

	private bool game;

	private int gameCooking;

	private float inputIntensity;

	private bool inputIntensityNeed;

	private float progress;

	private float progressOffest;

	private Vector2 movePlane;

	private float timeAnimationGame;

	private float timeAnimationGame2;

	private Color color1;

	private int indexQuest;

	private int progressQuest;

	[Space(50f)]
	[HideInInspector]
	public int food;

	private int playerChangeWork;

	private int indexSausagePartCut;

	private float timeUseSausageParts;

	[SerializeField]
	[Header("Пицца")]
	[Label("Части колбасы")]
	private Location21_Cooking_Sausage[] partsSausage;

	[SerializeField]
	private ParticleSystem cheeseParticles;

	[Label("Диалоги старта")]
	[SerializeField]
	private GameObject[] dialoguesStartPizza;

	[SerializeField]
	private UnityEvent startCookingPizza;

	[SerializeField]
	private UnityEvent eventMitaPizzaStartCheese;

	[SerializeField]
	private UnityEvent eventMitaPizzaStartSausage;

	[SerializeField]
	private ObjectAnimationPlayer animationPlayerReadyCutSausage;

	[SerializeField]
	private ObjectAnimationPlayer animationPlayerReadyCutCheese;

	[Label("Добавлю сыр")]
	[SerializeField]
	private GameObject[] dialoguesPizzaMitaAddCheese;

	[Label("Добавлю колбасу")]
	[SerializeField]
	private GameObject[] dialoguesPizzaMitaAddSausage;

	[Label("Добавь сыр")]
	[SerializeField]
	private GameObject[] dialoguesPizzaPlayerAddCheese;

	[Label("Добавь колбасу")]
	[SerializeField]
	private GameObject[] dialoguesPizzaPlayerAddSausage;

	[SerializeField]
	[Label("Всё добавили на тесто")]
	private GameObject[] dialoguesPizzaDoughReady;

	[SerializeField]
	private AnimationClip animationPlayerAddCheese;

	[SerializeField]
	private ObjectAnimationPlayer animationPlayerTakeAgainCheese;

	[SerializeField]
	private GameObject cheeseInHand;

	[SerializeField]
	private Location21_Cooking_CheeseDisk[] cheeseDisk;

	[SerializeField]
	private ObjectAnimationPlayer animationPlayerReadyAddedCheese;

	[SerializeField]
	private ObjectAnimationPlayer animationPlayerAddSausage;

	[SerializeField]
	private Transform pointAddSausage;

	[SerializeField]
	private AnimationCurve animationDropSausage;

	[SerializeField]
	private ObjectAnimationPlayer animationPlayerTakeMoreSausage;

	[SerializeField]
	private ObjectAnimationPlayer animationPlayerSausageReady;

	private GameObject pancakeMitaWork;

	private GameObject pancakePlayerWork;

	private GameObject cutletWork;

	private int indexMitaAnimationMakePancake;

	private bool playerWaitPancake;

	private bool mitaReadyPancake;

	private int indexPlayerMakePancake;

	[Header("Блины")]
	[SerializeField]
	private GameObject[] dialoguesStartPancakes;

	[SerializeField]
	private UnityEvent startCookingPancakes;

	[SerializeField]
	private GameObject pancakePrefab;

	[SerializeField]
	private Transform pancakePosMitaRetake;

	[SerializeField]
	private Transform pancakePosMitaRetakeBoard;

	[SerializeField]
	private AnimationClip[] pancakePlaeyrAnimationTakeCutlet;

	[SerializeField]
	private GameObject[] pancakePlaeyrTakeCutlet;

	[SerializeField]
	private GameObject[] pancakePlaeyrReadyCutlet;

	[SerializeField]
	private Transform[] pancakePlaeyrReadyCutletPos;

	[SerializeField]
	private ObjectAnimationPlayer pancakeAnimationPlayerMake;

	[SerializeField]
	private Transform pancakePosPlayerRetakeBoard;

	[SerializeField]
	private Transform pancakeMixturePivot;

	[SerializeField]
	private SpriteRenderer pancakeMixtureRotate;

	[SerializeField]
	private SpriteRenderer pancakeMixtureReady;

	[SerializeField]
	private GameObject[] pancakeMixtureReadyDestroy;

	[SerializeField]
	private Interface_KeyHint_Key pancakeKeyTakePancake;

	[SerializeField]
	private MitaEvent[] pancakeMitaMake;

	[SerializeField]
	private MitaEvent pancakeMitaAddMixture;

	[SerializeField]
	private MitaEvent pancakeMitaTurnPacnake;

	[SerializeField]
	private List<TimePointInt> pancakeMitaLastPancake;

	[SerializeField]
	private ObjectAnimationPlayer pancakeAnimationPlayerRetakePlate;

	[SerializeField]
	private ObjectAnimationPlayer pancakeAnimationPlayerRetakePlateLast;

	[SerializeField]
	private Time_Events pancakePlayerReadyCutlet;

	[SerializeField]
	private UnityEvent pancakeEventPlayerChangeCutlet;

	[SerializeField]
	private UnityEvent pancakeEventPlayerChangePancake;

	[SerializeField]
	private UnityEvent pancakeEventPancakeReady;

	private float mixtureSpeed;

	private float mixtureSpeedAdd;

	private bool mixtureReady;

	[Header("Сендвичи")]
	[SerializeField]
	private GameObject[] dialoguesStartSandwiches;

	[SerializeField]
	private UnityEvent startCookingSandwiches;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void StartCooking()
	{
	}

	public void PlayerStartQuest()
	{
	}

	public void PlayerExit()
	{
	}

	public void StartQuest()
	{
	}

	private void IKStop()
	{
	}

	private void IKActivation(bool x)
	{
	}

	private void StartGame()
	{
	}

	private void ProgressAdd()
	{
	}

	public void PlayerStartGame(int x)
	{
	}

	public void PlayerMitaReady()
	{
	}

	public void ClickPizza()
	{
	}

	public void StartCookingPizza()
	{
	}

	public void PizzaChangeCheese()
	{
	}

	public void PizzaChangeSausage()
	{
	}

	public void PizzaMitaGoWorkCheeseSausage()
	{
	}

	public void SausageCutPart()
	{
	}

	public void PizzaCheeseSausageWasAddedOnDough()
	{
	}

	public void PizzaPlayerStartCheeseDough()
	{
	}

	public void PizzaPlayerCheeseCanAdd()
	{
	}

	public void PizzaPlayerMitaStartSausageDough(bool _player)
	{
	}

	public void PizzaMitaPlayerTakeSausage(bool _player)
	{
	}

	public void MitaStartDropSausage()
	{
	}

	public void MitaDropSausage()
	{
	}

	public void PizzaPlayerSausageCanAdd()
	{
	}

	public void PizzaPlayerDropSausage()
	{
	}

	public void PizzaMitaReadyAddedCheeseSausageDough()
	{
	}

	public void ClickPancakes()
	{
	}

	public void StartCookingPancakes()
	{
	}

	public void PancakesPlayerChange(int x)
	{
	}

	public void PancakesMitaAddWater()
	{
	}

	public void PancakesMitaTurnPancake()
	{
	}

	public void PancakesMitaRetakePancake()
	{
	}

	public void PancakesMitaMakePancake()
	{
	}

	public void PancakesMakeTake(GameObject _target)
	{
	}

	public void PancakesMitaReadyWaitPancake()
	{
	}

	public void PancakesMitaCheckNextPancake()
	{
	}

	public void PancakesPlayerAddWater()
	{
	}

	public void PancakesPlayerTurnPancake()
	{
	}

	public void PancakesPlayerRetakePancake()
	{
	}

	public void PancakesPlayerMakePancake()
	{
	}

	public void PancakesPlayerReadyWaitPancake()
	{
	}

	public void PancakesPlayerRetakeOnPlate()
	{
	}

	public void PancakesPlayerTakeCutletNext()
	{
	}

	public void PancakesCutletIn()
	{
	}

	public void PancakesReady()
	{
	}

	public void PancakesMixtureRotate()
	{
	}

	public void PancakesMixtureReady()
	{
	}

	public void ClickSandwiches()
	{
	}

	public void StartCookingSandwiches()
	{
	}

	public void StartFinishDialogue()
	{
	}

	public void Finish()
	{
	}
}
