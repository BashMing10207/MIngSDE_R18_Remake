using UnityEngine;

public class IK_HandTrigger : MonoBehaviour
{
	[Header("Правая рука")]
	public Transform handPivotRight;

	public PlayerHandIK_Prefab handPoseRight;

	public bool handToWallRight;

	public float distanceHandToWallRight;

	[Space(10f)]
	public bool handFaceRight;

	public Vector3 handFacePositionRight;

	[Header("Левая рука")]
	public Transform handPivotLeft;

	public PlayerHandIK_Prefab handPoseLeft;

	public bool handToWallLeft;

	public float distanceHandToWallLeft;

	[Space(10f)]
	public bool handFaceLeft;

	public Vector3 handFacePositionLeft;

	[Header("Общее")]
	[Space(30f)]
	public bool active;

	public bool rotateOnPlayer;

	public Vector3 rotateOnPlayerAdd;

	private PlayerMove scrpm;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Activation(bool _x)
	{
	}
}
