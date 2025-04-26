using UnityEngine;
using UnityEngine.Events;

public class Location3WalkToToilet : MonoBehaviour
{
	public UnityEvent eventFinish;

	public Animator_FunctionsOverride mitaScript;

	public float distance;

	public Transform positionPlayerAnimation;

	public AnimationClip animationMitaWalk;

	public AnimationClip animationMitaIdle;

	public AnimationClip animationPlayerWalk;

	public AnimationClip animationPlayerIdle;

	[Header("Animation")]
	public AnimationCurve animationPosZ;

	public AnimationCurve animationRotY;

	public float walkDistance;

	[Header("Doors")]
	public GameObject doorKitchen;

	public GameObject doorMain;

	public float distanceOpenMain;

	private bool doorMainOpen;

	public GameObject doorToilet;

	public float distanceOpenToilet;

	private bool doorToiletOpen;

	public AnimationClip animaitonOpen;

	private Vector3 positionPlayerStart;

	private float speedWalkNow;

	private float timeWalk;

	private PlayerMove playerScript;

	private float timeDatamosh;

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}
}
