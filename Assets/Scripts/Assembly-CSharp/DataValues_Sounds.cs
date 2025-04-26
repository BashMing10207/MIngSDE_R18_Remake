using UnityEngine;

public class DataValues_Sounds : MonoBehaviour
{
	public AudioSource audioSource;

	public AudioClip[] sounds;

	[Header("Loop sound")]
	public AudioClip soundLoop;

	public float volumeSoundLoop;

	public float speedOffLoop;

	[HideInInspector]
	public string nameFileLocation;

	[HideInInspector]
	public World wrld;

	private bool fs;

	public void StartComponent()
	{
	}

	private void Update()
	{
	}
}
