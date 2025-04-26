using UnityEngine;

public class IK_HandPoserClick : MonoBehaviour
{
	public PlayerHandIK_Prefab handPose;

	public bool useLimbHand;

	[Header("Pivot")]
	public Transform handPivot;

	public bool usePosition;

	public Vector3 position;

	public bool useRotate;

	public Vector3 rotation;

	private PlayerPersonIK scrppik;

	private void Start()
	{
	}

	public void Click()
	{
	}
}
