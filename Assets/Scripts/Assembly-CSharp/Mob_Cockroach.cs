using UnityEngine;

public class Mob_Cockroach : MonoBehaviour
{
	private Transform player;

	[Header("Layers")]
	public LayerMask layerWalls;

	private RaycastHit hit;

	private float timeMoveRandom;

	private float timeMoveForward;

	private float timeRotationRandom;

	private float timeRotation;

	private float speed;

	private bool smoothDestroy;

	private AudioSource audioSource;

	[Header("Settings")]
	public float timeDestroySmooth;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void SmoothDestroy()
	{
	}
}
