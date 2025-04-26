using RootMotion.FinalIK;
using UnityEngine;

public class Character_LookSimple : MonoBehaviour
{
	[SerializeField]
	private bool active;

	[SerializeField]
	private bool dontMove;

	[SerializeField]
	private LookAtIK lookAtIK;

	[SerializeField]
	private Transform targetLook;

	[SerializeField]
	private float speed;

	[SerializeField]
	[Header("Предметы (кости)")]
	private Transform objectFixRightItem;

	[SerializeField]
	private Transform boneRightItem;

	[Space(5f)]
	[SerializeField]
	private Transform objectFixLeftItem;

	[SerializeField]
	private Transform boneLeftItem;

	private float dotLook;

	[Header("Угол")]
	[SerializeField]
	private Transform useDot;

	[SerializeField]
	private float dotAngle;

	[Header("Анимация")]
	[SerializeField]
	private bool useAnimation;

	[SerializeField]
	private AnimationCurve animationWeight;

	[Header("Ограничения")]
	[SerializeField]
	private bool activeLimitY;

	[SerializeField]
	private Vector2 limitY;

	[SerializeField]
	private bool activeLimitZ;

	[SerializeField]
	private Vector2 limitZ;

	[Header("При старте")]
	[SerializeField]
	private bool startTargetLookCamera;

	private float weightIK;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	public void Activation(bool x)
	{
	}

	public void TargetLook(Transform _target)
	{
	}

	public void TargetLookCamera()
	{
	}

	public void DontMove(bool x)
	{
	}
}
