using UnityEngine;

public class Light_Color : MonoBehaviour
{
	private Light lg;

	private float timeAnimationColor;

	private Color colorWas;

	private Color colorNeed;

	[Header("Анимация")]
	[SerializeField]
	private AnimationCurve animationColor;

	[SerializeField]
	private float speed;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void ColorInstant(Color _color)
	{
	}

	public void ColorAnimation(Color _color)
	{
	}
}
