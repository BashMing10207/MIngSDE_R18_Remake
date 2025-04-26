using UnityEngine;

public class Audio_Data : MonoBehaviour
{
	public AudioSource audioSound;

	public AudioClip[] sounds;

	[Header("Рандом")]
	[Range(-10f, 10f)]
	public float pitchMax;

	[Range(-10f, 10f)]
	public float pitchMin;

	[Header("Старт")]
	public bool onStartRandomPitch;

	public bool onStartRandom;

	public bool onEnableRandomPitch;

	public bool onEnableRandom;

	private float timeOutNow;

	[Header("Настройки")]
	public float timeOut;

	private int lastSound;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnEnable()
	{
	}

	public void SoundPlay(int x)
	{
	}

	public void RandomPlay()
	{
	}

	public void RandomPlayPitch()
	{
	}

	public void SoundPlayPitch(int x)
	{
	}

	public void Play()
	{
	}

	private int FixRandomSound()
	{
		return 0;
	}

	public void ClipPlay(AudioClip _clip)
	{
	}
}
