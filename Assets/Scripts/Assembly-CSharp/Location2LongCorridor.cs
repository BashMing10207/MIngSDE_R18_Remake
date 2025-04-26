using UnityEngine;
using UnityEngine.Events;

public class Location2LongCorridor : MonoBehaviour
{
	public Transform corridorScale;

	public Transform doorExit;

	public UnityEvent eventNear;

	private float audioAdd;

	private AudioSource au;

	private bool destroyGo;

	private float distanceClamp;

	private float distanceNow;

	private Transform playerPosition;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
