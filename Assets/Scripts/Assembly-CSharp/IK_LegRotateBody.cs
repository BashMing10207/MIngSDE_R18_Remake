using RootMotion.FinalIK;
using UnityEngine;

public class IK_LegRotateBody : MonoBehaviour
{
	private FullBodyBipedIK ikMain;

	private float timeAnimation;

	private bool rotateSide;

	private float speedRotate;

	private Vector3 targetRotate;

	private float pivotLegsRotateWas;

	private float pivotLegsRotateNeed;

	private bool stepHalf;

	private Vector3 positionRightLegStay;

	private Vector3 positionLeftLegStay;

	private Vector3 positionLegNeedLeft;

	private Vector3 positionLegNeedRight;

	private Quaternion rotationLegRotateRight;

	private Quaternion rotationLegRotateLeft;

	[SerializeField]
	private Transform legRightBone;

	[SerializeField]
	private Transform legLeftBone;

	[SerializeField]
	private Transform legRightRotate;

	[SerializeField]
	private Transform legLeftRotate;

	[SerializeField]
	private Transform objectLegRotate;

	[SerializeField]
	[Header("Анимация")]
	private AnimationCurve animationRotateBody;

	[SerializeField]
	private AnimationCurve animationLegUp;

	[SerializeField]
	private float heightLegUp;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void StartTarget(Vector3 _target)
	{
	}

	public void StopRotate()
	{
	}

	public void RotateTarget(Vector3 _position)
	{
	}

	public void RotateTarget(Transform _target)
	{
	}
}
