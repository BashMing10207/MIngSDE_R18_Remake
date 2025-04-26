using UnityEngine;

public class Audio_LowPass : MonoBehaviour
{
	private AudioLowPassFilter flt;

	private float was;

	private float need;

	private float timeAnimation;

	[SerializeField]
	private float speed;

	[SerializeField]
	private AnimationCurve animationLow;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void LowPassLerp(float x)
	{
	}

	public void LowPassReturn()
	{
	}
}
