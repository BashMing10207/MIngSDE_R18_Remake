using UnityEngine;
using UnityEngine.Events;

public class Location18_Blink : MonoBehaviour
{
	[SerializeField]
	private UnityEvent eventBlink;

	[SerializeField]
	private UnityEvent eventFinish;

	[SerializeField]
	private AnimationCurve animationBlink;

	[SerializeField]
	private RectTransform blinkUp;

	[SerializeField]
	private RectTransform blinkDown;

	private float timeBlink;

	private int blink;

	private void Update()
	{
	}

	[ContextMenu("Моргнуть")]
	public void Blink()
	{
	}
}
