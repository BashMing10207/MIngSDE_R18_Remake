using UnityEngine;

public class Location21_CookingEating : MonoBehaviour
{
	private Location21_Cooking main;

	private int playerMitaSit;

	private int indexFoodMitaEat;

	private Transform foodTargetMita;

	private int indexFoodPlayerEat;

	private Transform foodTargetPlayer;

	private int countEatFoodPlayer;

	private int countEatFoodMita;

	private int countBite;

	private float waitFinish;

	private bool mitaEatFinish;

	private bool playerEatFinish;

	private bool autoEating;

	private float timeAutoEatPlayer;

	private float timeAutoEatMita;

	private int indexObjectDialogue;

	private int indexDialogue;

	private bool playerEatingNow;

	private bool mitaEatingNow;

	private bool waitSpeakPlayer;

	private bool waitSpeakMita;

	[Header("Общение")]
	[SerializeField]
	private GameObject[] dialogueStart;

	[SerializeField]
	private GameObject[] dialogueAutoMita;

	[SerializeField]
	private Location21_CookingEating_Dialogues[] dialogues;

	[SerializeField]
	private Interface_KeyHint_Key keyEat;

	[SerializeField]
	private Interface_KeyHint_Key keyDrink;

	[SerializeField]
	private GameObject[] dialogueGoEat;

	[SerializeField]
	private GameObject[] dialogueFinish;

	[Header("Финиширование")]
	[SerializeField]
	private Time_Events mitaStandup;

	[SerializeField]
	private ObjectAnimationPlayer playerStandup;

	private bool mitaTakeCup;

	[Space(50f)]
	[SerializeField]
	[Header("Кушают пиццу")]
	private AnimationClip[] pizzaPartMita;

	[SerializeField]
	private Time_Events[] pizzaAnimationsMitaEat;

	[SerializeField]
	private Time_Events pizzaAnimationMitaDrink;

	[SerializeField]
	private Time_Events[] pizzaAnimationMitaTakePizza;

	[SerializeField]
	private Time_Events pizzaAnimationMitaTakeCup;

	[SerializeField]
	private Time_Events pizzaAnimationMitaRemoveCup;

	[SerializeField]
	private ObjectAnimationPlayer pizzaAnimationPlayerEat;

	[SerializeField]
	private ObjectAnimationPlayer pizzaAnimationPlayerDrink;

	[SerializeField]
	private ObjectAnimationPlayer[] pizzaAnimationPlayerTakeNextPizza;

	[SerializeField]
	[Header("Кушают блины")]
	[Space(50f)]
	private MitaEvent[] pancakesMitaTake;

	[SerializeField]
	private MitaEvent[] pancakesMitaEat;

	[SerializeField]
	private MitaEvent pancakesMitaDrink;

	[SerializeField]
	private MitaEvent pancakesMitaEnd;

	[SerializeField]
	private ObjectAnimationPlayer[] pancakesPlayerTake;

	[SerializeField]
	private ObjectAnimationPlayer[] pancakesPlayerEat;

	[SerializeField]
	private ObjectAnimationPlayer pancakesPlayerDrink;

	[Header("Кушают сендвичи")]
	[SerializeField]
	[Space(50f)]
	private ObjectAnimationPlayer sandwichPlayerDrink;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void PlayerMitaSit()
	{
	}

	public void MitaAutoStartTheme()
	{
	}

	public void MitaAutoChangeTheme()
	{
	}

	public void ChangeTheme(int x)
	{
	}

	private void NextDialogue()
	{
	}

	public void GoStay()
	{
	}

	public void PlayerEat()
	{
	}

	public void PlayerDrink()
	{
	}

	public void PlayerCanEat(bool x)
	{
	}

	private void MitaEatRandom()
	{
	}

	public void MitaCanEat(bool x)
	{
	}

	public void MitaBite()
	{
	}

	public void PlayerBite()
	{
	}

	private void AutoEating()
	{
	}

	public void PizzaMitaTake(Transform _pizzaPart)
	{
	}

	public void PizzaPlayerTake(Transform _pizzaPart)
	{
	}

	public void PancakeMitaTake(Transform _food)
	{
	}

	public void PancakePlayerTake(Transform _food)
	{
	}
}
