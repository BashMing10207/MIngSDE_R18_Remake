using RootMotion.FinalIK;
using UnityEngine;

public class Location8_Hand : MonoBehaviour
{
	private Transform playerHead;

	private float timeStart;

	private bool nearTrigger;

	private float timeNoiseHead;

	private AudioSource au;

	private AudioSource auparent;

	[SerializeField]
	private Transform targetLimb;

	[SerializeField]
	private LimbIK ikHand;

	[SerializeField]
	private AudioClip[] soundsKick;

	private bool sDestroy;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void AudioPlay()
	{
	}

	public void SmoothDestroy()
	{
	}
}
