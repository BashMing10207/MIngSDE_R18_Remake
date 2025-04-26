using UnityEngine;
using UnityEngine.UI;

public class UI_AlphaAnimation : MonoBehaviour
{
	private Image img;

	private float timeAnimationAlpha;

	[Header("Настройки")]
	[SerializeField]
	private float visible;

	[SerializeField]
	private float speedAlpha;

	[SerializeField]
	private bool zeroAlphaEnable;

	[Header("Анимация")]
	[SerializeField]
	private bool playAnimation;

	[SerializeField]
	private float speedAnimation;

	[SerializeField]
	private float speedLerp;

	[SerializeField]
	private AnimationCurve animationAlpha;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void PlayAnimation(bool x)
	{
	}

	public void Visible(float x)
	{
	}

	private void OnEnable()
	{
	}
}
