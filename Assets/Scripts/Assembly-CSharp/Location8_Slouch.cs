using UnityEngine;

public class Location8_Slouch : MonoBehaviour
{
	public Location8_SlouchLife slouchLife;

	private float timeEyeLook;

	private Vector2 eyesRotations;

	[Header("Глаза")]
	[SerializeField]
	private Transform eyeL;

	[SerializeField]
	private Transform eyeR;

	private Transform playerHeadT;

	[SerializeField]
	[Header("Звук")]
	private LayerMask layerWall;

	[SerializeField]
	private AudioSource audioLife;

	[SerializeField]
	private AudioSource audioStep;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void EyesLook()
	{
	}

	public void StepFoot()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
