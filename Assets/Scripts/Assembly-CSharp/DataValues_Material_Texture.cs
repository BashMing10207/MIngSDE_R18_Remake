using System;
using UnityEngine;

[Serializable]
public class DataValues_Material_Texture
{
	public Renderer rend;

	public Texture2D textrue;

	public Texture2D textrueEmission;

	public int indexMaterial;

	[Space(20f)]
	public bool useColor;

	[ColorUsage(true, true)]
	public Color color;
}
