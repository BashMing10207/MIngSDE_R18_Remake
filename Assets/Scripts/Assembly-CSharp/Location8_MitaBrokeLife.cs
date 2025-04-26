using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class Location8_MitaBrokeLife : MonoBehaviour
{
	[SerializeField]
	private Location8_SlouchLife slouchLife;

	[SerializeField]
	private Transform[] pointsRandomTeleport;

	private PlayerMove scrPlayer;

	private Transform player;

	private float timeDontMolest;

	private float timeCanWalk;

	private float timeMolestStart;

	private bool oneTime;

	private bool canWalk;

	private bool molest;

	private int dialoguesIndex;

	private GameController gameController;

	[Header("Мита пристаёт")]
	[SerializeField]
	private MitaPerson maitaPerson;

	[SerializeField]
	private NavMeshAgent nma;

	[SerializeField]
	private Character_Look mitaIK;

	[SerializeField]
	private Renderer meshVisibleMita;

	[SerializeField]
	private Interface_KeyHint_Key keyHintDropMolest;

	[SerializeField]
	private ObjectAnimationPlayer animationPlayerMolest;

	[SerializeField]
	private UnityEvent eventMolestStart;

	[SerializeField]
	private UnityEvent eventMolestStop;

	[SerializeField]
	private Transform pointToPlayer;

	[SerializeField]
	private GameObject[] dialogues;

	[SerializeField]
	[Header("Мита пристаёт первый раз")]
	private UnityEvent eventMolestStartOne;

	[SerializeField]
	private UnityEvent eventMolestStopOne;

	[SerializeField]
	private ObjectAnimationPlayer animationPlayerMolestOneTime;

	[SerializeField]
	[Header("Звуки")]
	private AudioSource audioMolest;

	[SerializeField]
	private AudioSource audioMolestStart;

	private bool fs;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void MolestStart()
	{
	}

	public void MolestPlayerDrop()
	{
	}

	public void MolestFinish()
	{
	}

	public void MolestOneTime()
	{
	}

	public void OffOneTime()
	{
	}

	public void TeleportRandom()
	{
	}

	public void StopWalk()
	{
	}

	public void DontMolestTime()
	{
	}
}
