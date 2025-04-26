using System.Collections.Generic;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Location7_RingWork : MonoBehaviour
{
	[SerializeField]
	private Image loadCircle;

	[SerializeField]
	private List<Location7_RingWork_Sphere> spheres;

	[SerializeField]
	private GameObject sphereExample;

	private bool createSphere;

	private bool destroySphere;

	private bool jointSphere;

	private int indexSphereWork;

	private int indexSphereJoin;

	private Vector2 positionMove;

	private float timeUseHand;

	private Animator animRingWork;

	[SerializeField]
	private bool handUse;

	[SerializeField]
	[Header("IK Миты")]
	private FullBodyBipedIK ikMita;

	[SerializeField]
	private Transform targetHand;

	[SerializeField]
	private Transform targetHandKnee;

	[SerializeField]
	private Transform targetLookSlow;

	[SerializeField]
	private RectTransform rectPositionHand;

	[SerializeField]
	private AnimationCurve animationMoveHand;

	private Vector2 positionMoveWas;

	private float timeAnimationMoveHand;

	[SerializeField]
	[Header("Звуки")]
	private AudioSource audioClick;

	[SerializeField]
	private AudioClip soundClick;

	[SerializeField]
	private AudioClip soundDelete;

	[SerializeField]
	private AudioClip soundJoin;

	private bool ready;

	[SerializeField]
	[Header("Время закончилось")]
	private UnityEvent eventReadyStart;

	[SerializeField]
	private UnityEvent eventReady;

	[SerializeField]
	[Header("Проверки")]
	private Location34_Communication communication;

	[SerializeField]
	private UnityEvent mitaCapAngry;

	[SerializeField]
	private UnityEvent mitaCapAngrySay;

	private bool capInteractive;

	[SerializeField]
	[Header("Кепка")]
	private bool capWait;

	[SerializeField]
	private GameObject helloCap;

	private float startWork;

	private bool work;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void AudioPlay(AudioClip _sound)
	{
	}

	private void CreateSphere(Vector2 _position)
	{
	}

	private void CreateEventHand()
	{
	}

	private void ChangeSphereWork()
	{
	}

	public void ReadyTime()
	{
	}

	private void StopWork()
	{
	}

	public void CapActivated()
	{
	}

	public void DialogueAngryCap()
	{
	}

	public void CapInteractive(bool x)
	{
	}
}
