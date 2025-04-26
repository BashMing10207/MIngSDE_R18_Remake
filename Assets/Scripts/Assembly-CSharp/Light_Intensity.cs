using UnityEngine;

public class Light_Intensity : MonoBehaviour
{
	private Light lg;

	[Header("Свет")]
	public float intensity;

	public AnimationCurve animationLerp;

	private float animationLerpTime;

	private float intensityWas;

	public float speedLerp;

	private float animationNoiseTime;

	[Header("Шум")]
	public AnimationCurve animationNoise;

	public bool playNoise;

	private int indexColorNeed;

	private float timeColor;

	private Color colorWas;

	[Header("Цвета")]
	public Color[] colorsLight;

	private bool fs;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void NoisePlay(bool _x)
	{
	}

	public void Intensity(float _x)
	{
	}

	public void IntenityLerp(float _x)
	{
	}

	public void ColorLerpStart(int _indexColor)
	{
	}

	public void ColorSharp(int _indexColor)
	{
	}
}
