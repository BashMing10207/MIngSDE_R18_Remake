using UnityEngine;

public class UI_SizeAnimation : MonoBehaviour
{
	private RectTransform rect;

	private float timeAnimation;

	[SerializeField]
	private Vector2 sizeOriginal;

	[SerializeField]
	private Vector2 sizeAnimation;

	[SerializeField]
	private AnimationCurve animationSize;

	[SerializeField]
	private float speedAnimation;

	[SerializeField]
	private bool timeUnscale;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
