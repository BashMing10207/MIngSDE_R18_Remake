using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Metroidvania_Interactive : MonoBehaviour
{
	public bool active;

	public UnityEvent eventInteractive;

	public float distance;

	public bool destroyAfter;

	[Header("Изображения")]
	public Image imgCircle;

	public Image imgCircleLight;

	public Text textKey;

	public AnimationCurve animationAlpha;

	private Transform playerT;

	private float distanceNow;

	private bool destroySmooth;

	private float alphaColor;

	private float timeActiveAlpha;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void ColorAlpha()
	{
	}

	private void Interactive()
	{
	}

	public void Activation(bool x)
	{
	}
}
