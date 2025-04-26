using UnityEngine;
using UnityEngine.Events;

public class ObjectInteractiveItemTake : MonoBehaviour
{
	[Header("Общее")]
	public Transform pivotHand;

	[Header("Right")]
	public PlayerHandIK_Prefab rightHand;

	public Quaternion rotationRightHand;

	public Vector3 positionRightHand;

	public Quaternion[] rotationsRightFingers;

	[Header("Left")]
	public PlayerHandIK_Prefab leftHand;

	public Quaternion rotationLeftHand;

	public Vector3 positionLeftHand;

	public Quaternion[] rotationsLeftFingers;

	[Header("События")]
	public UnityEvent eventTake;

	private bool lerpPositionInHand;

	private Vector3 positionInHand;

	private Quaternion rotationInHand;

	private Transform player;

	[HideInInspector]
	public PlayerHandIK_Prefab handTake;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Take()
	{
	}

	public void TakeInHand(Transform _parent)
	{
	}

	public void TakeDestroy()
	{
	}

	private void GetPositionInHand(GameObject _objectHand)
	{
	}
}
