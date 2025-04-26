using UnityEngine;

public class Rigidbody_HingeJoint : MonoBehaviour
{
	private bool limitShot;

	[Header("Звук")]
	public AudioSource audioSource;

	public AudioClip soundMove;

	public AudioClip[] soundsLimit;

	private float angleJoint;

	private HingeJoint hj;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
