using System;
using UnityEngine;

[Serializable]
public class AudioPoint
{
	[HideInInspector]
	public AudioSource au;

	public AudioClip[] sounds;

	[Header("Settings")]
	public bool randomPitch;

	public float pitchRandomMin;

	public float pitchRandomMax;
}
