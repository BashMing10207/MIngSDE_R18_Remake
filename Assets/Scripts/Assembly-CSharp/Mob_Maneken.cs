using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class Mob_Maneken : MonoBehaviour
{
	[SerializeField]
	private bool active;

	[SerializeField]
	private bool dontKill;

	[SerializeField]
	private float speedNav;

	[SerializeField]
	private SkinnedMeshRenderer rend;

	[SerializeField]
	private MeshRenderer rendVisible;

	[SerializeField]
	private LayerMask layerFindPlayer;

	private bool castPlayer;

	private Transform playerT;

	private bool playStart;

	private float timeStartAnimation;

	[Header("Условие для начала")]
	[SerializeField]
	private AnimationClip animationStart;

	private float timeCheckKill;

	private float animationTimeKill;

	[SerializeField]
	[Header("Убийство")]
	private AnimationClip animationKill;

	[SerializeField]
	private UnityEvent eventKillStart;

	[SerializeField]
	private UnityEvent eventKillStop;

	[SerializeField]
	private Transform animationPlayerKill;

	[SerializeField]
	private AudioSource audioKillPlayer;

	[SerializeField]
	private AudioSource audioAttack;

	private AnimatorOverrideController animOver;

	[Header("Настройки ходьбы")]
	[SerializeField]
	private AnimationClip animaionWalk;

	[SerializeField]
	private AudioSource audioStep;

	[SerializeField]
	private AudioClip soundStepMarble;

	[SerializeField]
	private AudioClip[] soundsStepWater;

	[SerializeField]
	private Transform legRight;

	[SerializeField]
	private Transform legLeft;

	[SerializeField]
	private Transform particleWater;

	private bool destroyed;

	[Header("Уничтожение")]
	[SerializeField]
	private ParticleSystem[] particlesDestroy;

	[SerializeField]
	private AudioSource audioDestroy;

	[SerializeField]
	private AnimationClip animationDeath;

	[SerializeField]
	private List<ParticleSystem> redEyes;

	[Header("Красноглазая")]
	[SerializeField]
	private AudioSource audioRedVoice;

	private float timeDontmove;

	private bool stop;

	private AudioSource ad;

	private Animator anim;

	private float timeVis;

	private NavMeshAgent nma;

	private NavMeshObstacle nmo;

	private Transform player;

	private int invalidStatus;

	private bool fs;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnEnable()
	{
	}

	public void Play()
	{
	}

	public void StartKillPlayer()
	{
	}

	[Button("Перезапустить", EButtonEnableMode.Always)]
	public void ResetManeken()
	{
	}

	public void Stop(bool x)
	{
	}

	public void DeactivationManeken()
	{
	}

	public void Step(int _rightStep)
	{
	}

	public void Activation(bool x)
	{
	}

	public void BitePlayer()
	{
	}
}
