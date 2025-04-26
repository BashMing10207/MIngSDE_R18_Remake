using System;
using UnityEngine;

[Serializable]
public class Material_EmissionLight_Object
{
	[ColorUsage(false, true)]
	public Color colorMin;

	[ColorUsage(false, true)]
	public Color colorMax;

	public float intensity;

	public Renderer rend;

	public int[] materialsEmission;

	public Material_EmissionLight_Audio audioVolume;
}
