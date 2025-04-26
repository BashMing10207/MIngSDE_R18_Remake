using UnityEngine;

public class Rigidbody_FloorFix : MonoBehaviour
{
	public float height;

	public float floorY;

	private float timeDontSound;

	private AudioSource au;

	[Header("Звуки")]
	public AudioClip[] soundsFall;

	[Header("Настройки")]
	public bool isKinematicAfter;

	public bool destroyColliderAfter;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void Fall()
	{
	}
}
