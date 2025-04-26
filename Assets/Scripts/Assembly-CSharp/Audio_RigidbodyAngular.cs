using UnityEngine;

public class Audio_RigidbodyAngular : MonoBehaviour
{
	public float intensity;

	[Range(0f, 1f)]
	public float min;

	[Header("Pitch")]
	public bool pitchRandomLowVolume;

	public float pitchMin;

	public float pitchMax;

	[Header("Speed")]
	public bool speedVelocity;

	private Rigidbody rb;

	private AudioSource au;

	private float velocityAngular;

	private float velocitySpeed;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void SoundAdd(float x)
	{
	}
}
