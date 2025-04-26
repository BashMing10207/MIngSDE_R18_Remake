using NaughtyAttributes;
using UnityEngine;

public class Material_ColorVariables : MonoBehaviour
{
	[SerializeField]
	private GameObject[] meshes;

	[SerializeField]
	private string nameVariable;

	[SerializeField]
	private string nameVariableAddon;

	public Color colorChange;

	[SerializeField]
	private bool onStart;

	[SerializeField]
	private bool loop;

	private Color colorWas;

	private float timeAnimation;

	private float timeAnimationLoop;

	[Header("Анимация")]
	[ColorUsage(true, true)]
	public Color colorAnimation;

	[ColorUsage(true, true)]
	[SerializeField]
	private Color colorAnimationLoop;

	[SerializeField]
	private AnimationCurve animationColor;

	[SerializeField]
	private AnimationCurve animationColorLoop;

	[SerializeField]
	private float speedLoop;

	[SerializeField]
	[ColorUsage(true, true)]
	[Header("Дополнение")]
	private Color[] otherColors;

	private void Start()
	{
	}

	private void Update()
	{
	}

	[Button("Установить цвет", EButtonEnableMode.Always)]
	public void ColorChange()
	{
	}

	public void AnimationStop()
	{
	}

	public void AnimationPlay()
	{
	}

	public void ReColorChange(int _index)
	{
	}

	public void LoopActive(bool x)
	{
	}
}
