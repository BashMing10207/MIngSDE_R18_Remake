using UnityEngine;

public class Light_LensFlareLerp : MonoBehaviour
{
	[SerializeField]
	private Color[] colors;

	[SerializeField]
	private AnimationCurve animationColor;

	[SerializeField]
	private float speed;

	private LensFlare lens;

	private Color colorWas;

	private Color colorNeed;

	private float timeAnimation;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void ColorAnimation(int x)
	{
	}
}
