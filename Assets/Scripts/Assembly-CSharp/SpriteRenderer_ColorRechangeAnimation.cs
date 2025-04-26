using UnityEngine;

public class SpriteRenderer_ColorRechangeAnimation : MonoBehaviour
{
	[SerializeField]
	private AnimationCurve animationColor;

	[SerializeField]
	private Color[] colors;

	[SerializeField]
	private float speedLerp;

	private float timeAnimation;

	private SpriteRenderer spriteRend;

	private Color colorWas;

	private Color colorNeed;

	private void Update()
	{
	}

	public void ColorLerp(int _colorIndex)
	{
	}
}
