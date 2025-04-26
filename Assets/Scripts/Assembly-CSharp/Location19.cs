using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class Location19 : MonoBehaviour
{
	private Transform playerT;

	private GameController scrgc;

	private float timePush;

	private bool pushCan;

	private int pushType;

	private UnityEvent eventPushReady;

	[Header("Отжимания")]
	[SerializeField]
	private Time_Events animPushJust;

	[SerializeField]
	private Time_Events animPushFingers;

	[Header("Одежда")]
	[SerializeField]
	private GameObject mitaBody;

	[SerializeField]
	private GameObject mitaSkirt;

	[SerializeField]
	private GameObject mitaBodyTowel;

	private float timeCheckTalkOut;

	private bool playerInToilet;

	[Header("Моется")]
	[SerializeField]
	private GameObject[] washesDialogueOut;

	private float timeAnimation;

	private float timeRandomBlink;

	[Header("Двери")]
	[SerializeField]
	private GameObject otherDoors;

	[SerializeField]
	private Location19_OtherDoor[] doors;

	[SerializeField]
	private SkinnedMeshRenderer[] headPlayers;

	[SerializeField]
	private AnimationCurve animationBlink;

	[Header("Глюки")]
	[SerializeField]
	private UnityEvent eventGlitchPlay;

	[SerializeField]
	private UnityEvent eventGlitchStop;

	private int indexCarrotPosition;

	private Vector3 carrotScale;

	private float timeAnimationCarrot;

	private int indexDialogueCarrot;

	[Header("Морковка")]
	[SerializeField]
	private Transform carrot;

	[SerializeField]
	private Transform carrotParticle;

	[SerializeField]
	private List<TransformFull> positionsCarrot;

	[SerializeField]
	private AnimationCurve animationCarrot;

	[SerializeField]
	private GameObject[] dialogueCarrot;

	private bool canCommunication;

	private bool tetrisUsed;

	private bool takeTetris;

	private GameObject tetrisCopy;

	[SerializeField]
	[Header("Тетрис")]
	private NavMeshAgent navigationCheck;

	[SerializeField]
	private Transform handRightMita;

	[SerializeField]
	private Transform animationMitaTetris;

	[SerializeField]
	private Transform animationPlayerTetris;

	[SerializeField]
	private Location34_Communication communication;

	[SerializeField]
	private UnityEvent eventMitaGoTetris;

	private bool dontLookPlayer;

	[Header("Стена баг")]
	[SerializeField]
	private Character_Look milaLook;

	private float timeKnockersStop;

	[Header("Переключатель")]
	[SerializeField]
	private AudioSource audioKnockers;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	public void GlitchPlay(bool x)
	{
	}

	public void DoorOpenFirst()
	{
	}

	public void DoorOpen()
	{
	}

	public void DoorClose()
	{
	}

	public void DoorReady()
	{
	}

	private void RandomBlink()
	{
	}

	public void ClothTowel(bool x)
	{
	}

	public void InToilet(bool x)
	{
	}

	public void PushCan(bool x)
	{
	}

	public void PushDown()
	{
	}

	public void TypePush(int _type)
	{
	}

	public void EventPushUp(Events_Data _event)
	{
	}

	public void LookOnCarrot()
	{
	}

	private void CarrotReposition()
	{
	}

	public void CanCommunity(bool x)
	{
	}

	public void TakeTetris()
	{
	}

	public void RemoveTetris()
	{
	}

	public void DontLookPlayer(bool x)
	{
	}

	public void ClickKnock()
	{
	}
}
