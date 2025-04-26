using System.Collections.Generic;
using UnityEngine;

public class Location19_Game2 : MonoBehaviour
{
	[SerializeField]
	private Location19_GlitchGame main;

	private bool finish;

	private float timeAnimationCamera;

	[Header("Камера")]
	[SerializeField]
	private Transform cameraTarget;

	[SerializeField]
	private AnimationCurve cameraAnimation;

	private float timeAnimationPoint;

	[Header("Точки")]
	[SerializeField]
	private List<Location19_Game2_Point> points;

	private int indexPointHold;

	private bool useSphere;

	private float timeLerpSphere;

	private Vector3 spherePosWas;

	[SerializeField]
	[Header("Шарик")]
	private GameObject objectSphere;

	private bool clickHalf;

	private int indexPointNeed;

	private float timeClick;

	private Vector3 positionHand;

	private Vector3 positionHandDistance;

	[Header("Рука")]
	[SerializeField]
	private Transform hand;

	[SerializeField]
	private AnimationCurve handAnimationButton;

	[SerializeField]
	private AnimationCurve handTakeSphere;

	private AudioSource audioHand;

	[Header("Звуки")]
	[SerializeField]
	private Audio_Data audioHandTake;

	[SerializeField]
	private Audio_Data audioSphereDrop;

	[SerializeField]
	private Audio_Data audioSphereMagnet;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void TakeSphere(bool x)
	{
	}

	public void PointCLick(int _index)
	{
	}
}
