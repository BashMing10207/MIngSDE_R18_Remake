using UnityEngine;

public class Tamagotchi_Music : MonoBehaviour
{
	private bool audioMusicActive;

	[SerializeField]
	private bool effectAudioMobile;

	[Header("Звуки")]
	public AudioSource audioMusic;

	public AudioHighPassFilter audioMusicEffect;

	private float timeBlock;

	private void Update()
	{
	}

	public void AudioActivation(bool x)
	{
	}

	public void AudioVolumeZero()
	{
	}

	public void AudioEffectActive(bool x)
	{
	}
}
