using System.Collections.Generic;
using RootMotion.FinalIK;
using UnityEngine;

public class Location17_PumpkinClicker : MonoBehaviour
{
	private PlayerMove scrpm;

	[Header("Интерактив")]
	[SerializeField]
	private ObjectInteractive interactiveMain;

	[SerializeField]
	private Animator[] pumpkinAnim;

	[SerializeField]
	private Transform[] pumpkinClick;

	[SerializeField]
	private ParticleSystem[] pumpkinParticleClick;

	[SerializeField]
	private Interface_KeyHint_Key keyCancel;

	private AnimationCurve animationLerp;

	private float animationClick;

	private Vector3 positionHandWas;

	[SerializeField]
	[Header("Анимации")]
	private ObjectAnimationPlayer animationPlayer;

	[SerializeField]
	private AnimationClip animationStart;

	[SerializeField]
	private AnimationCurve animationClickHand;

	private float timeAnimationHandIK;

	private FullBodyBipedIK ikPlayer;

	[Header("Рука")]
	[SerializeField]
	private Transform handPivot;

	[Header("Звуки")]
	[SerializeField]
	private AudioClip soundYes;

	[SerializeField]
	private AudioClip soundNo;

	[SerializeField]
	private AudioClip soundStart;

	[SerializeField]
	private AudioClip soundClick;

	[SerializeField]
	private AudioClip soundStop;

	private float timeStart;

	private bool play;

	private bool playGeneral;

	private bool win;

	private int pumpkinChange;

	private int pumpkinChangeNow;

	private List<int> orderClick;

	private int timeClick;

	private float timeCheckLogic;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void Click()
	{
	}

	private void CheckLogic()
	{
	}

	public void StartClicker()
	{
	}

	public void End()
	{
	}

	public void Activation(bool x)
	{
	}
}
