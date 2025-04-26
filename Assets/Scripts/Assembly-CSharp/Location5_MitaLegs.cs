using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class Location5_MitaLegs : MonoBehaviour
{
	private Animator anim;

	private Transform player;

	private NavMeshAgent nma;

	private Transform targetMove;

	private bool eventOk;

	[Header("Navigation")]
	public Transform positionFirst;

	public Transform positionSecond;

	public UnityEvent eventStartPlayer;

	private bool ending;

	[Header("Ending")]
	public Transform positionAnimation;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
