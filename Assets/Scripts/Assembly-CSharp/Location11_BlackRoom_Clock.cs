using UnityEngine;
using UnityEngine.Events;

public class Location11_BlackRoom_Clock : MonoBehaviour
{
	private bool look;

	private float timeLook;

	private bool part1;

	private bool part2;

	private bool part3;

	private bool part4;

	[Header("Визуал")]
	[SerializeField]
	private SkinnedMeshRenderer objectCrack;

	[SerializeField]
	private ParticleSystem particlePart1;

	[SerializeField]
	private ParticleSystem particlePart2;

	[SerializeField]
	private ParticleSystem particlePart3;

	[SerializeField]
	private ParticleSystem particlePart4;

	[SerializeField]
	private ParticleSystem particlePart5;

	[SerializeField]
	private Location11_BlackRoom_ClockTime clock;

	[SerializeField]
	private Location11_BlackRoom main;

	[SerializeField]
	private AudioSource audioBack;

	[Header("События")]
	[SerializeField]
	private UnityEvent eventReady;

	private void Update()
	{
	}

	private void SoundBack()
	{
	}

	public void Look(bool x)
	{
	}
}
