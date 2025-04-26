using UnityEngine;

public class DataMaterialShaders : MonoBehaviour
{
	[ColorUsage(false)]
	[Header("Линии мира")]
	public Color[] colorsLine;

	[ColorUsage(false)]
	public Color[] colorsLineHalloween;

	public Material materialLine;
}
