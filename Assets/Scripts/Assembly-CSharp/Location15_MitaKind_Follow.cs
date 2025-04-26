using UnityEngine;
using UnityEngine.Events;

public class Location15_MitaKind_Follow : MonoBehaviour
{
	private Transform mitaT;

	[SerializeField]
	private MitaPerson mita;

	[SerializeField]
	private Transform positionSit;

	[SerializeField]
	private UnityEvent eventGoSit;

	[SerializeField]
	private UnityEvent eventStartSit;

	private int checkBack;

	private Transform cameraPlayer;

	private GameObject targetMove;

	private Vector3 playerWantBack;

	[Header("Отойти")]
	[SerializeField]
	private Vector3[] positionBack;

	[SerializeField]
	private LayerMask layerMita;

	private bool follow;

	private Transform playerT;

	private Transform positionPlayerLast;

	private float timeUpdatePositionLast;

	private void Update()
	{
	}

	private void OnEnable()
	{
	}

	private void FixedUpdate()
	{
	}

	public void GoSit()
	{
	}

	public void FollowStop()
	{
	}
}
