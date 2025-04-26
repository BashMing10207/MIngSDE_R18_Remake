using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class Location7 : MonoBehaviour
{
	private bool mitaCapFree;

	private bool carrotFall;

	private float carrotTimeDouble;

	private float carrotTimeStop;

	private int countCarrot;

	private List<GameObject> carrotCopy;

	[SerializeField]
	[Header("Морковка")]
	private GameObject carrot;

	[SerializeField]
	private AudioSource carrotAudio;

	[SerializeField]
	private GameObject dialogueCarrot;

	[SerializeField]
	[Header("Сидеть и ждать")]
	private UnityEvent eventMitaStopSit;

	[SerializeField]
	private AnimationClip animationPlayerSitAgain;

	[SerializeField]
	private ObjectAnimationPlayer animationPlayerSit;

	[SerializeField]
	private GameObject objectKeyStandup;

	[SerializeField]
	private AudioClip soundSitAgain;

	private bool bye;

	private float timeWaitBye;

	private int indexBye;

	[SerializeField]
	[Header("Прощание")]
	private GameObject[] dilaoguesBye;

	[SerializeField]
	private GameObject[] dilaoguesByeCap;

	private Transform playerT;

	private bool tetrisUsed;

	private bool takeTetris;

	private float timeDrop;

	private GameController scrgc;

	private bool againTetrisBool;

	private GameObject tetrisCopy;

	[Header("Тетрис")]
	[SerializeField]
	private NavMeshAgent navigationCheck;

	[SerializeField]
	private Transform handRightMita;

	[SerializeField]
	private LayerMask layerDef;

	[SerializeField]
	private Transform animationMitaTetris;

	[SerializeField]
	private Transform animationPlayerTetris;

	[SerializeField]
	private Location34_Communication communication;

	[SerializeField]
	private UnityEvent eventMitaGoTetris;

	[SerializeField]
	private UnityEvent againTetris;

	[SerializeField]
	private AudioClip tetrisDrop;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	public void MitaCapFree()
	{
	}

	public void CarrotFall()
	{
	}

	public void PlayerSit(bool x)
	{
	}

	public void ByePlayer()
	{
	}

	public void UpdateTimeBye()
	{
	}

	public void TakeTetris()
	{
	}

	public void DropTetris()
	{
	}
}
