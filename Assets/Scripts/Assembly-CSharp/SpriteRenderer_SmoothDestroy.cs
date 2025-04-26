using UnityEngine;

public class SpriteRenderer_SmoothDestroy : MonoBehaviour
{
	public float speedAlpha;

	[Header("Alpha start")]
	public bool alphaStart;

	[Range(0f, 1f)]
	public float alphaStartIntensity;

	public float alphaStartSpeed;

	private SpriteRenderer sr;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
