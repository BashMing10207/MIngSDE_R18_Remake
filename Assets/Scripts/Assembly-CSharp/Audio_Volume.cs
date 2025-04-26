using UnityEngine;

public class Audio_Volume : MonoBehaviour
{
	[SerializeField]
	private bool active;

	[SerializeField]
	private float volume;

	[SerializeField]
	private float speed;

	[SerializeField]
	private bool useUnscaled;

	[SerializeField]
	private bool startZeroVolume;

	[SerializeField]
	private bool onDestroyComponent;

	[SerializeField]
	private bool onPlayRandomTime;

	[SerializeField]
	[Header("Музыка")]
	private float volumeMusic;

	private AudioSource au;

	private bool destroyMe;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Volume(float x)
	{
	}

	public void Play()
	{
	}

	public void Activation(bool x)
	{
	}

	public void DestroySmooth()
	{
	}

	public void Speed(float x)
	{
	}

	public void MusicActivation(bool x)
	{
	}

	public void PlayIfZero()
	{
	}
}
