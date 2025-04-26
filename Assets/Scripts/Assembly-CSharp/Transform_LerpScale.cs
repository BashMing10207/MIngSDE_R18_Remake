using UnityEngine;

public class Transform_LerpScale : MonoBehaviour
{
	private Vector3 scaleOrigin;

	private Vector3 scaleWas;

	private Vector3 scaleNeed;

	private bool destroyTime;

	public AnimationCurve animationScale;

	private float timeAnimationScale;

	public float speed;

	[Header("При старте")]
	public bool onStart;

	public Vector3 startScale;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void ScaleOneLerp(float x)
	{
	}

	public void ScaleZeroDestroy()
	{
	}
}
