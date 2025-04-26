using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class BlackScreenAnimation : MonoBehaviour
{
	public Image blackScreen;

	private bool tStart;

	public float time1Start;

	public float time1Finish;

	public UnityEvent eventStop1;

	private bool tStop;

	public float time0Start;

	public float time0Finish;

	public UnityEvent eventStop0;

	private bool play;

	private float timeBlack;

	private void Update()
	{
	}

	public void Play()
	{
	}
}
