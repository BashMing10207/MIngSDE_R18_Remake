using UnityEngine;

public class Sound_Several : MonoBehaviour
{
	public AudioSource[] soundsSource;

	public float[] soundsVolume;

	[Space(10f)]
	public float timeMinNext;

	public float timeMaxNext;

	public float speedVolume;

	private int soundIndexWork;

	private float timeNext;

	private float timeNextNeed;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void NextSound()
	{
	}
}
