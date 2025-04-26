using UnityEngine;

public class Audio_Start : MonoBehaviour
{
	[Header("Settings")]
	public bool destroyOnStart;

	public bool enableRestart;

	[Range(-3f, 3f)]
	[Header("Pitch")]
	public float pitchMax;

	[Range(-3f, 3f)]
	public float pitchMin;

	[Range(0f, 1f)]
	[Header("Time")]
	public float timeStartMin;

	[Range(0f, 1f)]
	public float timeStartMax;

	private bool fs;

	private void OnEnable()
	{
	}

	private void DestroyComponent()
	{
	}

	private void DestroyObject()
	{
	}
}
