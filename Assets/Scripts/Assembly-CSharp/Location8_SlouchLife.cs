using UnityEngine;
using UnityEngine.Events;

public class Location8_SlouchLife : MonoBehaviour
{
	[SerializeField]
	private Animator animatorSlouch;

	[SerializeField]
	private AnimationClip animationWalkSlouch;

	[SerializeField]
	private Animator doorAnim;

	[SerializeField]
	private Location8_Slouch slouch;

	[SerializeField]
	private UnityEvent eventScreamer;

	[SerializeField]
	private UnityEvent eventRestart;

	[SerializeField]
	private Location8_MitaBrokeLife mita;

	[SerializeField]
	private Location8_InfinityRoom world;

	[Header("Звуки")]
	[SerializeField]
	private AudioSource[] audioSourcesSlouch;

	private bool delete;

	private float timeSlow;

	private float timeAnimationWalkSlouch;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void RestartWalk()
	{
	}

	public void SlouchBack()
	{
	}

	public void StartLife()
	{
	}

	public void StopLife()
	{
	}

	public void Restart()
	{
	}

	public void Screamer()
	{
	}

	public void SlowTime()
	{
	}
}
