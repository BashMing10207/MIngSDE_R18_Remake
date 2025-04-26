using UnityEngine;

public class SpriteRenderer_ColorAnimation : MonoBehaviour
{
	private SpriteRenderer spr;

	private Color colorWas;

	private Color colorNeed;

	[Header("Анимация")]
	public AnimationCurve animationColor;

	private float timeAnimationColor;

	public float animationSpeed;

	public bool fastStart;

	public bool materialColor;

	private bool destroy;

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	public void ColorAnimationDestroy()
	{
	}

	public void DestroyObject()
	{
	}
}
