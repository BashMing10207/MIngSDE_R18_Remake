using System;
using UnityEngine;

[Serializable]
public class Material_EmissionLight_Audio
{
	[Range(0f, 1f)]
	public float volumeMin;

	[Range(0f, 1f)]
	public float volumeMax;

	public AudioSource audioSource;
}
