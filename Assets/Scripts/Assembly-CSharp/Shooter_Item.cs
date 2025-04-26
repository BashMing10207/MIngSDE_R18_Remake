using UnityEngine;

public class Shooter_Item : MonoBehaviour
{
	[SerializeField]
	private GameObject particleTake;

	private Transform playerT;

	private float timeAnimationFly;

	private AnimationCurve animationFly;

	private bool onFloor;

	private Vector3 positionFloor;

	private LayerMask layerFloor;

	private RaycastHit hit;

	private Rigidbody rb;

	private float rotateTime;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void TakeItem()
	{
	}
}
