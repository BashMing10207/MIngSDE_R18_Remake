using NaughtyAttributes;
using UnityEngine;

public class Transform_ScaleLerp : MonoBehaviour
{
	[SerializeField]
	private AnimationCurve animationSize;

	[SerializeField]
	private float speed;

	private float sizeWas;

	private float sizeNeed;

	private float timeAnimationSize;

	private bool deactiveAfter;

	private bool fs;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void SizeLerp(float x)
	{
	}

	[Button("Выключить", EButtonEnableMode.Always)]
	public void SizeLerpZeroDeactive()
	{
	}

	[Button("Включить", EButtonEnableMode.Always)]
	public void SizeLerpOneActive()
	{
	}
}
