using UnityEngine;
using UnityEngine.Events;

public class Location17_MitaWalk : MonoBehaviour
{
	[SerializeField]
	private MitaPerson mita;

	[SerializeField]
	private UnityEvent eventReadyWalk;

	private int checkBack;

	private Transform cameraPlayer;

	private Transform mitaT;

	private GameObject targetMove;

	private Vector3 playerWantBack;

	[Header("Отойти")]
	[SerializeField]
	private Vector3[] positionBack;

	[SerializeField]
	private LayerMask layerMita;

	private bool mitaCanWalk;

	private Transform playerT;

	private Transform positionPlayerLast;

	private float timeUpdatePositionLast;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	public void MitaCanWalk(bool x)
	{
	}
}
