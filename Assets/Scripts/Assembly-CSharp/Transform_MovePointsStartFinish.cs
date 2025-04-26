using UnityEngine;
using UnityEngine.Events;

[AddComponentMenu("Functions/Transform/Move start-finish")]
public class Transform_MovePointsStartFinish : MonoBehaviour
{
	public bool onStart;

	public TransformPositionRotation[] points;

	public bool useRotation;

	public bool local;

	public bool loop;

	private Vector3 positionWas;

	private Quaternion rotationWas;

	private bool play;

	private int indexPoint;

	private float animationMoveTime;

	[Header("Animation")]
	public AnimationCurve animationMove;

	public float speedMove;

	[Header("Размер")]
	public bool scaleAnimation;

	private AudioSource au;

	[Header("Звук")]
	public bool audioAnimation;

	public float audioAnimationVolume;

	[Header("События")]
	public UnityEvent eventFinish;

	private bool smoothDestroy;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void StartMove()
	{
	}

	public void Loop(bool _x)
	{
	}

	public void SmoothDestroy()
	{
	}
}
