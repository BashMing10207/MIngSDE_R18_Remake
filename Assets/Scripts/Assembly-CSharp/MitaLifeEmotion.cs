using UnityEngine;
using UnityEngine.Events;

public class MitaLifeEmotion : MonoBehaviour
{
	public enum TypeEmotionLonfSe
	{
		shy = 0,
		dialogue = 1
	}

	private float timeDontActive;

	[Header("Поведение")]
	public bool active;

	private float timeShy;

	private int levelShy;

	private int indexDialogueShy;

	private float timeIgnoryActivation;

	[SerializeField]
	[Header("Смотрим на персонажа")]
	private TypeEmotionLonfSe typeEmotionLongSee;

	[SerializeField]
	private GameObject[] dialogueShy;

	[SerializeField]
	private Location21_World location21;

	[SerializeField]
	private string emotionStart;

	[SerializeField]
	private string emotionStop;

	[SerializeField]
	private UnityEvent eventDialogueStart;

	private bool randomEmotion;

	private float timeRanomEmotion;

	private bool lookFullPlayer;

	private float timeLookFullPlayer;

	private int orderLookFullPlayer;

	private int dialogueFarAwayIndex;

	private int dialogueCloselyIndex;

	private float dialogueFarAwayTime;

	private float dialogueCloselyTime;

	[Header("Прочие разговоры")]
	[SerializeField]
	private float speedTimeOtherDiaolgue;

	[SerializeField]
	private GameObject[] dialogueFarAway;

	[SerializeField]
	private GameObject[] dialogueClosely;

	[SerializeField]
	private UnityEvent eventOtherDialogueStart;

	private bool lookHead;

	[Header("Взгляд игрока")]
	public LayerMask layerPart;

	public SphereCollider colliderHead;

	private PlayerMove scrpm;

	private GameController scrgc;

	private Transform cameraPlayer;

	private MitaPerson mita;

	private Transform mitaT;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	public void Activation(bool x)
	{
	}

	private void StopEmotion()
	{
	}

	private void TimeDontActive(float _x)
	{
	}
}
