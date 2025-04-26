using NaughtyAttributes;
using UnityEngine;

public class AudioDialogue : MonoBehaviour
{
	private float volumeOriginal;

	[Label("Персонаж")]
	[SerializeField]
	private Dialogue_3DText.Dialogue3DTheme person;

	[Label("Без озвучки")]
	public bool personNotVoice;

	[Label("Источник звука")]
	public AudioSource audioVoice;

	private void Start()
	{
	}

	public void ResetVoice()
	{
	}

	public void SetAudioVoice(AudioSource _audioSource)
	{
	}
}
