using UnityEngine;

public class MenuAuthorLocation : MonoBehaviour
{
	[SerializeField]
	private AnimationCurve animationScale;

	[SerializeField]
	private GameObject objectWith;

	[SerializeField]
	private RectTransform content;

	[SerializeField]
	[Header("Автоспуск")]
	private float contentAutoSlide;

	private float timeAnimation;

	private bool activation;

	private float timeContentFix;

	private float timeAudoSlide;

	private float slideNow;

	private bool autoslide;

	private void Update()
	{
	}

	private void OnEnable()
	{
	}

	public void Activation(bool x)
	{
	}
}
