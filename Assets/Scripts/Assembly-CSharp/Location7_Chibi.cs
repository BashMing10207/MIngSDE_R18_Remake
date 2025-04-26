using UnityEngine;
using UnityEngine.AI;

public class Location7_Chibi : MonoBehaviour
{
	private Animator anim;

	private NavMeshAgent nma;

	private GameObject objectTextNow;

	private float timeSpeak;

	private bool sit;

	[Header("Грустный")]
	[SerializeField]
	private Transform targetSit;

	[SerializeField]
	private GameObject textSpeak;

	private float timeIgnoryPlayer;

	private float timeCheckPlayer;

	private Transform playerT;

	private float randomPosition;

	private int goEnd;

	private bool readyFinish;

	private float timeVoice;

	private float noneFear;

	[Header("Боится игрока")]
	[SerializeField]
	private LayerMask wall;

	[SerializeField]
	private Transform targetEnd;

	[SerializeField]
	private Location7_DoorChibi componentDoor;

	[SerializeField]
	private Transform[] normalPlace;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Move(Vector3 _point)
	{
	}

	private void StopMove()
	{
	}
}
