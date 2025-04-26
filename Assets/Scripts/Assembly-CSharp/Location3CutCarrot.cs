using UnityEngine;
using UnityEngine.Events;

public class Location3CutCarrot : MonoBehaviour
{
	public float[] timesCut;

	public GameObject[] partsCarrot;

	public AnimationClip animationLength;

	public UnityEvent eventFinish;

	[Header("Интерфейс")]
	public Animator animHint;

	[Header("Звуки")]
	public AudioSource audioCut;

	public AudioClip[] soundsCut;

	private int indexCarrotFall;

	private int indexTimeCut;

	private float animationTime;

	private Animator animPlayer;

	private bool play;

	private bool keyDown;

	private string stateName;

	private float timeStart;

	private bool autoCut;

	private void Update()
	{
	}

	private void Cut()
	{
	}

	public void CutStart()
	{
	}

	public void CutFinish()
	{
	}
}
