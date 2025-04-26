using System;
using UnityEngine;

[Serializable]
public class DataValues_Material
{
	public Renderer rend;

	[ColorUsage(true, true)]
	public Color color;

	public int indexMaterial;
}
