using UnityEngine;

public class LightRenderer_Fog : MonoBehaviour
{
	[SerializeField]
	private float fogStart;

	[SerializeField]
	private float fogEnd;

	[ColorUsage(false)]
	[SerializeField]
	private Color fogColor;

	[SerializeField]
	private bool destroyAfterComponent;

	public void Apply(bool x)
	{
	}

	public void ApplyLerp()
	{
	}
}
