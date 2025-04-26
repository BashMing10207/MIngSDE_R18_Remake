using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class Location14_PlayerQuest : MonoBehaviour
{
	[SerializeField]
	private Location14_GameQuestPlayer main;

	private Animator anim;

	private Transform targetAnimation;

	private float speedWalk;

	private bool go;

	private Vector3 positionMove;

	private NavMeshAgent nma;

	private UnityEvent eventMoveFinish;

	[SerializeField]
	[Header("Шаги")]
	private LayerMask layerFloor;

	[SerializeField]
	private AudioSource audioStep;

	[SerializeField]
	private AudioClip[] soundsStep;

	[SerializeField]
	private AudioClip[] soundsStepCover;

	private float speedRotate;

	private float timeDontMove;

	private float timeAnimationRotate;

	private float rotationWas;

	private float rotationNeed;

	[Header("Анимация")]
	[SerializeField]
	private AnimationCurve animationRotate;

	[Header("Сюжетное")]
	[SerializeField]
	private Transform targetSit;

	[SerializeField]
	private Transform targetSpeak;

	[SerializeField]
	private Transform targetStartSpawn;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Move(Vector3 _pos, UnityEvent _event)
	{
	}

	private void MoveFinish()
	{
	}

	public void RotateOnTarget(Transform _lookTarget)
	{
	}

	private void RotateOnPosition(Vector3 _pos)
	{
	}

	public void Step()
	{
	}

	public void StepAnim()
	{
	}

	public void AnimationPlay(Transform _targetAnimation, string _nameTrigger)
	{
	}

	private void Teleport()
	{
	}

	public void TeleportStart()
	{
	}

	public void TeleportSit()
	{
	}

	public void TeleportSpeak()
	{
	}
}
