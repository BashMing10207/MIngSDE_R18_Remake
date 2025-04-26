using UnityEngine;
using UnityEngine.Events;

public class Trigger_Teleport : MonoBehaviour
{
	[SerializeField]
	private Transform targetTeleport;

	[SerializeField]
	private bool rotationReverse;

	[SerializeField]
	private UnityEvent eventTeleport;

	private PlayerMove scrpm;

	private float timeDontTP;

	private Transform tPos;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnDestroy()
	{
	}
}
