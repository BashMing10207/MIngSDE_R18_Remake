using Coffee.UIEffects;
using NaughtyAttributes;
using UnityEngine;

public class UIEffector_Blur : MonoBehaviour
{
	private UIEffect effect;

	private float timeAnimation;

	private bool deactivated;

	private float blurWas;

	private float blurNeed;

	[SerializeField]
	private AnimationCurve animationBlur;

	[SerializeField]
	private float speed;

	private bool fs;

	private void Start()
	{
	}

	private void Update()
	{
	}

	[Button("Включить", EButtonEnableMode.Always)]
	public void ActivatedOne()
	{
	}

	[Button("Выключить", EButtonEnableMode.Always)]
	public void DeactivatedZero()
	{
	}

	public void DeactiveFast()
	{
	}
}
